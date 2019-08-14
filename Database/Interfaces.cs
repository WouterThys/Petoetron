using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    [DataContract(Name = "ActionType")]
    public enum ActionType
    {
        [EnumMember]
        CacheCleared = -2,
        [EnumMember]
        Unknown = -1,
        [EnumMember]
        Insert = 0,
        [EnumMember]
        Update = 1,
        [EnumMember]
        Delete = 2,
        [EnumMember]
        SelectAll = 3,
        [EnumMember]
        SelectById = 4,
        [EnumMember]
        SaveCustomValue = 5,
       
        [EnumMember]
        Custom = 10,
        [EnumMember]
        InsertObjectLog = 20
    }

    public enum LoggingLevel
    {
        None,
        Some,
        Insane
    }

    [DataContract]
    public enum DbState
    {
        [EnumMember]
        InTheVoid = 0,
        [EnumMember]
        Initializing,
        [EnumMember]
        Initialized,
        [EnumMember]
        Updating,
        [EnumMember]
        Updated,
        [EnumMember]
        Running,
        [EnumMember]
        Error
    }

    public interface IDbObject : IDbInstance
    {
        string Code { get; set; }
    }

    public interface IDbLink : IDbInstance
    {
        IDbInstance PrimaryKey { get; }
        IDbInstance ForeignKey { get; }

        string PrimaryKeyName { get; }
        string ForeignKeyName { get; }
    }

    public interface IDbObjectLogger 
    {
        string GetLogScript(ActionType actionType);
        void AddLogParameters(DbCommand command);
    }

    public interface IDbInstance : IScripting, IDbSavable
    {
        long Id { get; set; }
        string TableName { get; }
    }
    
    public interface IAction
    {
        ActionType ActionType { get; }
        long ActionBy { get; }
        long ActionOn { get; }
    }

    public interface IScripting
    {
        string GetScript(ActionType actionType);
        void AddSqlParameters(DbCommand command);
        void InitFromReader(DbDataReader reader);
    }

    public interface IDbSavable
    {
        bool Save();
        bool Delete();

        void OnChanged(ActionType queryType);
        void OnFailed(DbException dbException);
    }

    public interface IDatabaseAccess
    {
        void DbLogBackState(DbState dbState);
        void DbQueryFailed(DbException dbException);
        void DbLogInfo(string message);
    }

    public interface IDatabaseUpdateCallback
    {
        void DbUpdateCallback(string message);
    }

}
