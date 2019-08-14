using Database;
using Petoetron.Classes;
using Petoetron.Classes.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Petoetron.Dal
{
    public class DataAccess : IDatabaseAccess
    {
        // Singleton
        private static readonly DataAccess INSTANCE = new DataAccess();
        public static DataAccess Dal { get { return INSTANCE; } }
        
        // Databases
        private DatabaseAccess Db { get; set; }

        // Cache
        private readonly IDictionary<Type, IDataList> cache;
        private INotifyDataChanged dataListener;
        private IDataInvoker dataInvoker;

        private DataAccess()
        {
            cache = new Dictionary<Type, IDataList>()
            {
                { typeof(Customer), new DataList<Customer>(new Customer().TableName) },
                { typeof(Material), new DataList<Material>(new Material().TableName) },
                { typeof(MaterialType), new DataList<MaterialType>(new MaterialType().TableName) },
            };
        }
        
        public void InitializeCallback(INotifyDataChanged dataListener, IDataInvoker dataInvoker)
        {
            this.dataListener = dataListener;
            this.dataInvoker = dataInvoker;
        }

        public void InitializeDatabase(
            string provider,
            string server,
            string schema,
            string user,
            string password)
        {
            Db = DatabaseAccess.CreateInstance("DataDb");

            string connectionString = string.Format(DatabaseAccess.ConnectionString_MySQL,
                server,
                schema,
                user,
                password);

            Db.Initialize(this,
                connectionString,
                provider,
                schema);
        }

        private DataList<T> GetList<T>(DataList<T> dataList) where T : IObject, new()
        {
            if (!dataList.IsFetched)
            {
                long start = Stopwatch.GetTimestamp();
                IEnumerable<T> values = FetchAll<T>();
                long stop = Stopwatch.GetTimestamp();

                dataList.Set(values, stop - start);
            }
            return dataList;
        }

        #region Database methods
        protected IEnumerable<T> FetchAll<T>() where T : IObject, new()
        {
            return Db.SelectAll<T>();
        }

        public void Insert<T>(T instance) where T : IDbInstance
        {
            Db.Insert(instance);
        }

        public void Update<T>(T instance) where T : IDbInstance
        {
            Db.Update(instance);
        }

        public void Delete<T>(T instance) where T : IDbInstance
        {
            Db.Delete(instance);
        }

        #endregion

        #region Cache methods


        protected DataList<T> GetCachedList<T>() where T : IObject
        {
            cache.TryGetValue(typeof(T), out IDataList list);
            return list as DataList<T>;
        }

        public void OnInserted<T>(T obj) where T : IObject
        {
            if (dataInvoker != null)
            {
                dataInvoker.InvokeOnMain(() => DoInsert(obj));
            }
            else
            {
                DoInsert(obj);
            }
        }

        protected void DoInsert<T>(T obj) where T : IObject
        {
            DataList<T> list = GetCachedList<T>();
            if (list != null)
            {
                if (list.Add(obj))
                {
                    dataListener?.NotifyInsert(obj);
                }
            }
            else
            {
                dataListener?.NotifyInsert(obj);
            }
        }

        public void OnUpdated<T>(T obj) where T : IObject
        {
            if (dataInvoker != null)
            {
                dataInvoker.InvokeOnMain(() => DoUpdate(obj));
            }
            else
            {
                DoUpdate(obj);
            }
        }

        protected void DoUpdate<T>(T obj) where T : IObject
        {
            DataList<T> list = GetCachedList<T>();
            if (list != null)
            {
                if (list.Update(obj))
                {
                    dataListener?.NotifyUpdate(obj);
                }
            }
            else
            {
                dataListener?.NotifyUpdate(obj);
            }
        }

        public void OnDeleted<T>(T obj) where T : IObject
        {
            if (dataInvoker != null)
            {
                dataInvoker.InvokeOnMain(() => DoDelete(obj));
            }
            else
            {
                DoDelete(obj);
            }
        }

        protected void DoDelete<T>(T obj) where T : IObject
        {
            DataList<T> list = GetCachedList<T>();
            if (list != null)
            {
                if (list.Remove(obj))
                {
                    dataListener?.NotifyDelete(obj);
                }
            }
            else
            {
                dataListener?.NotifyDelete(obj);
            }
        }

        #endregion

        #region IDatabaseAccess Interface
        public void DbLogBackState(DbState dbState)
        {

        }

        public void DbQueryFailed(DbException dbException)
        {

        }

        public void DbLogInfo(string message)
        {
        }
        #endregion

        public DataList<Customer> Customers { get { return GetList(GetCachedList<Customer>()); } }
        public DataList<Material> Materials { get { return GetList(GetCachedList<Material>()); } }
        public DataList<MaterialType> MaterialTypes { get { return GetList(GetCachedList<MaterialType>()); } }
    }
}
