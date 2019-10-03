using Database.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Database
{
    public class DatabaseAccess : IDatabaseUpdateCallback
    {
        public const string ConnectionString_MySQL = "SERVER = {0}; DATABASE={1}; UID={2}; PASSWORD={3}; SslMode=none;Connection Timeout = 20";

        public static DatabaseAccess CreateInstance(string name) { return new DatabaseAccess(name); }
        private DatabaseAccess(string name) { Name = name; }

        public string Name { get; private set; }

        // Logging
        private IDatabaseAccess logBack;
        private readonly LoggingLevel loggingLevel = LoggingLevel.Some;
        private DatabaseMap databaseMap;

        //Connection
        private string connectionString;
        private string provider;
        private string schema;

        // Extra info
        private string server;
        private string database;
        private string user;

        // Variables
        private DbState state = DbState.InTheVoid;
        private DbQueue<DbQueueObject> workingList;
        private Thread dbQueueWorker;
        private bool keepRunning = true;

        // Update 
        private UpdateManager updateMgr;



        public void Initialize(IDatabaseAccess logBack, string connectionString, string provider, string schema)
        {
            State = DbState.Initializing;
            if (this.logBack != null && this.logBack.Equals(logBack) &&
                !string.IsNullOrEmpty(this.connectionString) && this.connectionString.Equals(connectionString))
            {
                // Already initialized
                State = DbState.Running;
                return;
            }
            this.logBack = logBack;
            this.connectionString = connectionString;
            this.provider = provider;
            this.schema = schema;
            LoadInfoFromString(connectionString);

            // Test the connection (will throw exception when failed)
            try
            {
                if (!string.IsNullOrEmpty(server))
                {
                    LogBackInfo("Testing connection to " + server + ", schema=" + schema + ", uid=" + user);
                }

                TestConnection(GetConnection());
                updateMgr = new UpdateManager(this);
                // Workers
                try
                {
                    keepRunning = true;
                    workingList = new DbQueue<DbQueueObject>(200, loggingLevel);
                    dbQueueWorker = new Thread(new ThreadStart(ProcessQueue));
                    State = DbState.Initialized;
                }
                catch (Exception e1)
                {
                    State = DbState.Error;
                    LogBackError(new DbException(DbExceptionType.InitialisationFailure, e1));
                }
            }
            catch (Exception e2)
            {
                State = DbState.Error;
                LogBackError(new DbException(DbExceptionType.InitialisationFailure, e2));
            }
        }

        public DbState State
        {
            get { return state; }
            set
            {
                state = value;
                OnLogBackState(value);
            }
        }

        public void Start()
        {
            dbQueueWorker.Start();
            State = DbState.Running;
        }

        private void TestConnection(DbConnection connection)
        {
            using (connection)
            {
                connection.Open();
                string sql = "SELECT 1;";
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandTimeout = 5;

                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                }
            }
        }

        private void LoadInfoFromString(string connectionString)
        {
            server = "";
            database = "";
            user = "";
            if (!string.IsNullOrEmpty(connectionString))
            {
                string[] split = connectionString.Split(';');
                foreach (string s in split)
                {
                    string[] paramval = s.Split('=');
                    if (paramval.Length == 2)
                    {
                        switch (paramval[0].Trim().ToUpper())
                        {
                            case "SERVER": server = paramval[1]; break;
                            case "DATABASE": database = paramval[1]; break;
                            case "UID": user = paramval[1]; break;
                            default: break;
                        }
                    }
                }
            }
        }

        public void CloseDown()
        {
            keepRunning = false;
            try
            {
                if (dbQueueWorker != null)
                {
                    dbQueueWorker.Interrupt();
                    State = DbState.InTheVoid;
                }
            }
            catch
            {
                // Noting we can do..
            }
        }

        public DbScriptParser UpdateScriptParser
        {
            get { return updateMgr.ScriptParser; }
        }

        public void ExecuteAllUpdates(CancellationToken cancellationToken, int majorVersion, int minorVersion, int buildVersion)
        {
            State = DbState.Updating;

            Task.Factory.StartNew(() =>
            {
                try
                {
                    // Load all scripts
                    updateMgr.LoadUpdateScripts(
                        (int)UpdateScriptState.Failed, 
                        (int)UpdateScriptState.Pending);

                    // Execute all scripts
                    updateMgr.ExecuteScripts(majorVersion, minorVersion, buildVersion, this);

                    // Done
                    State = DbState.Updated;
                }
                catch (Exception e)
                {
                    State = DbState.Error;
                    LogBackError(new DbException(DbExceptionType.UpdateFailure, e));
                }
            }, cancellationToken);
        }

        void IDatabaseUpdateCallback.DbUpdateCallback(string message)
        {
            LogBackInfo("Database updates: " + message);
        }

        #region USEFULL

        public DatabaseMap DatabaseMap
        {
            get
            {
                if (databaseMap == null)
                {
                    databaseMap = new DatabaseMap(schema, () => GetConnection());
                }
                return databaseMap;
            }
        }

        public List<DbTable> GetAllTables()
        {
            DatabaseMap.UpdateData();
            return DatabaseMap.Tables;
        }

        public List<DbProcedure> GetAllProcedures()
        {
            return DatabaseMap.Procedures;
        }

        #endregion

        #region DB-METHODS

        public DbConnection GetConnection()
        {
            DbConnection connection = (DbConnection)Activator.CreateInstance(Type.GetType(provider), connectionString);
            return connection;
        }

        public IEnumerable<T> SelectAll<T>() where T : IDbInstance, new()
        {
            List<T> list = new List<T>();
            T t = new T();
            DbConnection connection = null;
            DbCommand cmd = null;
            try
            {
                string sql = schema + "." + t.GetScript(ActionType.SelectAll);

                using (connection = GetConnection())
                {
                    connection.Open();
                    using (cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //AddDbValue(cmd, "tableName", t.TableName);

                        using (DbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                t = new T();
                                t.InitFromReader(reader);

                                list.Add(t);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                LogBackError(new DbException(DbExceptionType.QueryFailed, e, "Select all for " + t.GetType().Name + " failed", t, cmd, ActionType.SelectAll));
            }

            return list;
        }

        public T SelectById<T>(long id) where T : IDbObject, new()
        {
            T t = new T();
            string sql = schema + "." + t.GetScript(ActionType.SelectById);
            using (DbConnection connection = GetConnection())
            {
                connection.Open();
                using (DbCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.StoredProcedure;

                    AddDbValue(cmd, "selectId", id);
                    AddDbValue(cmd, "tableName", t.TableName);
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            t.InitFromReader(reader);
                        }
                        else
                        {
                            t = default(T);
                        }
                    }
                }
            }

            return t;
        }

        public IEnumerable<long> FindIds(string sql, Action<DbCommand> filter)
        {
            List<long> list = new List<long>();
            DbConnection connection = null;
            DbCommand cmd = null;
            try
            {
                using (connection = GetConnection())
                {
                    connection.Open();
                    using (cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.StoredProcedure;
                        filter(cmd);
                        using (DbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(reader.GetInt64(0));
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                LogBackError(new DbException(DbExceptionType.QueryFailed, e, "Select all for failed", null, cmd, ActionType.SelectAll));
            }

            return list;
        }

        public IEnumerable<T> Select<T>(string sql, Action<DbCommand> addQueryParams) where T : IDbInstance, new()
        {
            List<T> list = new List<T>();
            T t = new T();
            DbConnection connection = null;
            DbCommand cmd = null;
            try
            {
                using (connection = GetConnection())
                {
                    connection.Open();
                    using (cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.StoredProcedure;
                        addQueryParams(cmd);
                        using (DbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                t = new T();
                                t.InitFromReader(reader);

                                list.Add(t);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                LogBackError(new DbException(DbExceptionType.QueryFailed, e, "Select all for " + t.GetType().Name + " failed", t, cmd, ActionType.SelectAll));
            }

            return list;
        }

        public void Select(Action<DbCommand> createCommand, Action<DbDataReader> onRead)
        {
            DbConnection connection = null;
            DbCommand cmd = null;
            try
            {
                using (connection = GetConnection())
                {
                    connection.Open();
                    using (cmd = connection.CreateCommand())
                    {
                        createCommand(cmd);
                        using (DbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                onRead(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                LogBackError(new DbException(DbExceptionType.QueryFailed, e));
            }
        }

        public void ExecuteScript(string script)
        {
            DbConnection connection = null;
            DbCommand cmd = null;

            using (connection = GetConnection())
            {
                connection.Open();
                using (cmd = connection.CreateCommand())
                {
                    cmd.CommandText = script;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ExecuteScript(string sql, Action<DbCommand> addParams) 
        {
            DbConnection connection = null;
            DbCommand cmd = null;
            try
            {
                using (connection = GetConnection())
                {
                    connection.Open();
                    using (cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (addParams != null)
                        {
                            addParams(cmd);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                LogBackError(new DbException(DbExceptionType.QueryFailed, e, "Execute failed", null, cmd, ActionType.Custom));
            }
        }

        public void ExecuteScript(string script, Action<DbDataReader> onRead)
        {
            DbConnection connection = null;
            DbCommand cmd = null;

            using (connection = GetConnection())
            {
                connection.Open();
                using (cmd = connection.CreateCommand())
                {
                    cmd.CommandText = script;
                    cmd.CommandType = CommandType.Text;
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            onRead(reader);
                        }
                    }
                }
            }
        }

        public void Insert(IDbInstance dbInstance)
        {
            if (dbInstance == null) throw new DbException(DbExceptionType.InvalidInstance, new NullReferenceException(), "Insert of invalid instance", null, null, ActionType.Insert);
            AddToQueue(new DbQueueObject(dbInstance, ActionType.Insert));
        }

        public Task InsertTask(IDbInstance dbInstance)
        {
            if (dbInstance == null) throw new DbException(DbExceptionType.InvalidInstance, new NullReferenceException(), "Insert of invalid instance", null, null, ActionType.Insert);
            return Task.Factory.StartNew((obj) =>
            {
                IDbInstance instance = (IDbInstance)obj;
                string sql = "";
                try
                {
                    sql = schema + "." + instance.GetScript(ActionType.Insert);
                }
                catch (Exception e)
                {
                    OnDbQueryFailed(instance, new DbException(DbExceptionType.QueryFailed, e, "Failed to load script", instance, null, ActionType.SelectById));
                    return;
                }
                using (DbConnection connection = GetConnection())
                {
                    connection.Open();
                    using (DbCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.StoredProcedure;
                        DbInsertInstance(instance, cmd);
                    }
                }

            }, dbInstance);
        }

        public void Update(IDbInstance dbInstance)
        {
            if (dbInstance == null) throw new DbException(DbExceptionType.InvalidInstance, new NullReferenceException(), "Update of invalid instance", null, null, ActionType.Update);
            AddToQueue(new DbQueueObject(dbInstance, ActionType.Update));
        }

        public Task UpdateTask(IDbInstance dbInstance)
        {
            if (dbInstance == null) throw new DbException(DbExceptionType.InvalidInstance, new NullReferenceException(), "Update of invalid instance", null, null, ActionType.Update);
            return Task.Factory.StartNew((obj) =>
            {
                IDbInstance instance = (IDbInstance)obj;
                string sql = "";
                try
                {
                    sql = schema + "." + instance.GetScript(ActionType.Update);
                }
                catch (Exception e)
                {
                    OnDbQueryFailed(instance, new DbException(DbExceptionType.QueryFailed, e, "Failed to load script", instance, null, ActionType.Update));
                    return;
                }
                using (DbConnection connection = GetConnection())
                {
                    connection.Open();
                    using (DbCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.StoredProcedure;
                        DbUpdateInstance(instance, cmd);
                    }
                }

            }, dbInstance);
        }

        public void Delete(IDbInstance dbInstance)
        {
            if (dbInstance == null) throw new DbException(DbExceptionType.InvalidInstance, new NullReferenceException(), "Delete of invalid instance", null, null, ActionType.Delete);
            AddToQueue(new DbQueueObject(dbInstance, ActionType.Delete));
        }

        public Task DeleteTask(IDbInstance dbInstance)
        {
            if (dbInstance == null) throw new DbException(DbExceptionType.InvalidInstance, new NullReferenceException(), "Delete of invalid instance", null, null, ActionType.Delete);
            return Task.Factory.StartNew((obj) =>
            {
                IDbInstance instance = (IDbInstance)obj;
                string sql = "";
                try
                {
                    sql = schema + "." + instance.GetScript(ActionType.Delete);
                }
                catch (Exception e)
                {
                    OnDbQueryFailed(instance, new DbException(DbExceptionType.QueryFailed, e, "Failed to load script", instance, null, ActionType.Delete));
                    return;
                }
                using (DbConnection connection = GetConnection())
                {
                    connection.Open();
                    using (DbCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.CommandType = CommandType.StoredProcedure;
                        DbDeleteInstance(instance, cmd);
                    }
                }

            }, dbInstance);
        }

        public void SaveCustomValue(IDbInstance dbInstance)
        {
            if (dbInstance == null) throw new DbException(DbExceptionType.InvalidInstance, new NullReferenceException(), "Save of invalid custom instance", null, null, ActionType.SaveCustomValue);
            AddToQueue(new DbQueueObject(dbInstance, ActionType.SaveCustomValue));
        }

        private void AddToQueue(DbQueueObject dbQueueObject)
        {
            if (workingList == null) throw new DbException(DbExceptionType.QueueError, new NullReferenceException());
            if (!workingList.IsRunning) throw new DbException(DbExceptionType.QueueError, null, "Queue is not running");
            try
            {
                workingList.Put(dbQueueObject);
            }
            catch (Exception e)
            {
                throw new DbException(DbExceptionType.QueueError, e, "Insert into queue failed");
            }
        }

        #endregion

        #region CALL-BACK

        private void OnDbInstanceDone<T>(T dbInstance, ActionType queryType) where T : IDbInstance
        {
            Task.Run(() => dbInstance.OnChanged(queryType));
            LogBackInfo(queryType.ToString() + " " + dbInstance.ToString());
        }

        private void OnDbQueryFailed<T>(T dbInstance, DbException exception) where T : IDbInstance
        {
            Task.Run(() => dbInstance.OnFailed(exception));
        }

        private void OnLogBackState(DbState state)
        {
            if (logBack != null)
            {
                Task.Run(() => logBack.DbLogBackState(state));
            }
        }

        private void LogBackInfo(string message)
        {
            if (logBack != null)
            {
                Task.Run(() => logBack.DbLogInfo(message));
            }
        }

        private void LogBackError(DbException exception)
        {
            if (logBack != null)
            {
                Task.Run(() => logBack.DbQueryFailed(exception));
            }
        }

        #endregion

        #region WORKING-QUEUE

        // Call this on thread!
        private void ProcessQueue()
        {
            while (keepRunning)
            {
                if (workingList.Take(out DbQueueObject queueObject))
                {
                    if (queueObject != null)
                    {
                        try
                        {
                            using (DbConnection connection = GetConnection())
                            {
                                connection.Open();
                                bool hasMoreWork;
                                do
                                {
                                    HandleQueueObject(queueObject, connection);

                                    if (workingList.Count > 0)
                                    {
                                        workingList.Take(out queueObject);
                                        hasMoreWork = true;
                                    }
                                    else
                                    {
                                        hasMoreWork = false;
                                    }
                                }
                                while (hasMoreWork && keepRunning);
                            }
                        }
                        catch (Exception e)
                        {
                            LogBackError(new DbException(
                                DbExceptionType.QueueError,
                                e,
                                e.Message,
                                queueObject.DbInstance));
                        }
                    }
                }
            }
        }

        private void HandleQueueObject(DbQueueObject queueObject, DbConnection connection)
        {
            if (queueObject != null)
            {
                IDbInstance dbInstance = queueObject.DbInstance;
                string sql = "";

                try
                {
                    sql = schema + "." + dbInstance.GetScript(queueObject.QueryType);
                }
                catch (Exception e)
                {
                    OnDbQueryFailed(dbInstance, new DbException(DbExceptionType.QueryFailed, e, "Failed to load script", dbInstance, null, ActionType.SelectById));
                    return;
                }

                using (DbCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.StoredProcedure;
                    switch (queueObject.QueryType)
                    {
                        case ActionType.Insert:
                            DbInsertInstance(dbInstance, cmd);
                            break;

                        case ActionType.Update:
                            DbUpdateInstance(dbInstance, cmd);
                            break;

                        case ActionType.Delete:
                            DbDeleteInstance(dbInstance, cmd);
                            break;

                        case ActionType.SaveCustomValue:
                            DbSaveCustomValue(dbInstance, cmd);
                            break;
                    }
                }

            }
        }

        private void DbInsertInstance(IDbInstance dbInstance, DbCommand cmd)
        {
            try
            {
                dbInstance.AddSqlParameters(cmd);
                DbParameter p = AddDbOutValue(cmd, "lid");
                cmd.ExecuteNonQuery();
                dbInstance.Id = Convert.ToInt64(p.Value);
                OnDbInstanceDone(dbInstance, ActionType.Insert);
            }
            catch (Exception e)
            {
                OnDbQueryFailed(dbInstance, new DbException(DbExceptionType.QueryFailed, e, "Failed to insert", dbInstance, cmd, ActionType.Insert));
            }
        }

        private void DbUpdateInstance(IDbInstance dbInstance, DbCommand cmd)
        {
            try
            {
                dbInstance.AddSqlParameters(cmd);
                AddDbValue(cmd, "updateId", dbInstance.Id);

                cmd.ExecuteNonQuery();
                OnDbInstanceDone(dbInstance, ActionType.Update);
            }
            catch (Exception e)
            {
                OnDbQueryFailed(dbInstance, new DbException(DbExceptionType.QueryFailed, e, "Failed to update", dbInstance, cmd, ActionType.Update));
            }
        }

        private void DbDeleteInstance(IDbInstance dbInstance, DbCommand cmd)
        {
            try
            {
                //AddDbValue(cmd, "tableName", dbInstance.TableName);
                if (dbInstance is IDbObject dbo)
                {
                    AddDbValue(cmd, "dId", dbo.Id);
                }
                if (dbInstance is IDbLink link)
                {
                    AddDbValue(cmd, link.PrimaryKeyName, link.PrimaryKey.Id);
                    AddDbValue(cmd, link.ForeignKeyName, link.ForeignKey.Id);
                }

                cmd.ExecuteNonQuery();
                OnDbInstanceDone(dbInstance, ActionType.Delete);
            }
            catch (Exception e)
            {
                OnDbQueryFailed(dbInstance, new DbException(DbExceptionType.QueryFailed, e, "Failed to delete", dbInstance, cmd, ActionType.Delete));
            }
        }

        private void DbSaveCustomValue(IDbInstance dbInstance, DbCommand cmd)
        {
            try
            {
                dbInstance.AddSqlParameters(cmd);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                OnDbQueryFailed(dbInstance, new DbException(DbExceptionType.QueryFailed, e, "Failed to save custom value", dbInstance, cmd, ActionType.SaveCustomValue));
            }
        }


        #endregion

        #region STATIC-HELPERS

        public static void AddDbValue(DbCommand command, string paramName, object value)
        {
            if (command is MySql.Data.MySqlClient.MySqlCommand) ((MySql.Data.MySqlClient.MySqlCommand)command).Parameters.AddWithValue("@" + paramName, value);
            //else if (command is System.Data.OracleClient.OracleCommand) command.Parameters.Add(new SqlParameter(":" + paramName, value));
            else if (command is SqlCommand) command.Parameters.Add(new SqlParameter("@" + paramName, value));
        }

        public static DbParameter AddDbOutValue(DbCommand command, string paramName)
        {
            if (command is MySql.Data.MySqlClient.MySqlCommand)
            {
                MySql.Data.MySqlClient.MySqlParameter parameter = new MySql.Data.MySqlClient.MySqlParameter
                {
                    ParameterName = "@" + paramName,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(parameter);
                return parameter;
            }
            else
            {
                SqlParameter parameter = new SqlParameter()
                {
                    ParameterName = "@" + paramName,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(parameter);
                return parameter;
            }

        }

        public static T RGetObject<T>(DbDataReader r, string fieldName) { return RGetObject(r, fieldName, default(T)); }
        public static T RGetObject<T>(DbDataReader r, string fieldName, T defaultValue)
        {
            T t = defaultValue;
            int ordinal = r.GetOrdinal(fieldName);
            if (!r.IsDBNull(ordinal))
            {
                object o = r.GetValue(ordinal);
                try
                {
                    t = (T)Convert.ChangeType(o, typeof(T));
                }
                catch (Exception e)
                {
                    Debug.WriteLine("RGetObject failed: " + e);
                }
            }
            return t;
        }

        public static string RGetString(DbDataReader r, string fieldName) { return RGetString(r, fieldName, ""); }
        public static string RGetString(DbDataReader r, string fieldName, string defaultValue)
        {
            string s = defaultValue;
            int ordinal = r.GetOrdinal(fieldName);
            if (!r.IsDBNull(ordinal)) { s = r.GetString(ordinal); }
            return s;
        }

        public static int RGetInt(DbDataReader r, string fieldName) { return RGetInt(r, fieldName, 0); }
        public static int RGetInt(DbDataReader r, string fieldName, int defaultValue)
        {
            int i = defaultValue;
            int ordinal = r.GetOrdinal(fieldName);
            if (!r.IsDBNull(ordinal)) { i = r.GetInt32(ordinal); }
            return i;
        }

        public static double RGetDouble(DbDataReader r, string fieldName) { return RGetDouble(r, fieldName, 0); }
        public static double RGetDouble(DbDataReader r, string fieldName, double defaultValue)
        {
            double d = defaultValue;
            int ordinal = r.GetOrdinal(fieldName);
            if (!r.IsDBNull(ordinal)) { d = r.GetDouble(ordinal); }
            return d;
        }

        public static long RGetLong(DbDataReader r, string fieldName) { return RGetLong(r, fieldName, 0); }
        public static long RGetLong(DbDataReader r, string fieldName, long defaultValue)
        {
            long l = defaultValue;
            int ordinal = r.GetOrdinal(fieldName);
            if (!r.IsDBNull(ordinal)) { l = r.GetInt64(ordinal); }
            return l;
        }

        public static decimal RGetDecimal(DbDataReader r, string fieldName) { return RGetDecimal(r, fieldName, 0); }
        public static decimal RGetDecimal(DbDataReader r, string fieldName, decimal defaultValue)
        {
            decimal d = defaultValue;
            int ordinal = r.GetOrdinal(fieldName);
            if (!r.IsDBNull(ordinal)) { d = r.GetDecimal(ordinal); }
            return d;
        }

        public static bool RGetBool(DbDataReader r, string fieldName) { return RGetBool(r, fieldName, false); }
        public static bool RGetBool(DbDataReader r, string fieldName, bool defaultValue)
        {
            bool b = defaultValue;
            int ordinal = r.GetOrdinal(fieldName);
            if (!r.IsDBNull(ordinal)) { b = r.GetBoolean(ordinal); }
            return b;
        }

        public static DateTime RGetDateTime(DbDataReader r, string fieldName) { return RGetDateTime(r, fieldName, DateTime.MinValue); }
        public static DateTime RGetDateTime(DbDataReader r, string fieldName, DateTime defaultValue)
        {
            DateTime dt = defaultValue;
            int ordinal = r.GetOrdinal(fieldName);
            try
            {
                if (!r.IsDBNull(ordinal)) { dt = r.GetDateTime(ordinal); }
            }
            catch
            {
                dt = defaultValue;
            }

            return dt;
        }

        public static DateTime RGetDate(DbDataReader r, string fieldName) { return RGetDate(r, fieldName, DateTime.MinValue.Date); }
        public static DateTime RGetDate(DbDataReader r, string fieldName, DateTime defaultValue)
        {
            DateTime dt = defaultValue;
            int ordinal = r.GetOrdinal(fieldName);
            try
            {
                if (!r.IsDBNull(ordinal)) { dt = r.GetDateTime(ordinal); }
            }
            catch
            {
                dt = defaultValue;
            }

            return dt.Date;
        }
        #endregion
    }
}
