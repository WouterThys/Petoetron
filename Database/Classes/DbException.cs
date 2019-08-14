using System;
using System.Data.Common;
using System.Runtime.Serialization;

namespace Database
{
    public enum DbExceptionType
    {
        Unknown,
        InitialisationFailure,
        UpdateFailure,
        QueryFailed,
        InvalidInstance,
        QueueError
    }

    public class DbException : Exception
    {
        private DbExceptionType exceptionType;
        private IDbInstance dbInstance;
        private DbCommand command;
        private ActionType queryType;

        public DbException(DbExceptionType exceptionType, Exception exception) : this(exceptionType, exception, "Database exception") { }

        public DbException(DbExceptionType exceptionType, Exception exception, string message) : this(exceptionType, exception, message, null) { }

        public DbException(DbExceptionType exceptionType, Exception exception, string message, IDbInstance dbInstance) : this(exceptionType, exception, message, dbInstance, null) { }

        public DbException(DbExceptionType exceptionType, Exception exception, string message, IDbInstance dbInstance, DbCommand command) : this(exceptionType, exception, message, dbInstance, command, ActionType.Unknown) { }

        public DbException(DbExceptionType exceptionType, Exception exception, string message, IDbInstance dbInstance, DbCommand command, ActionType queryType) : base(message,exception)
        {
            this.exceptionType = exceptionType;
            this.dbInstance = dbInstance;
            this.command = command;
            this.queryType = queryType;
        }

        public override string ToString()
        {
            string error = "{QueryType=" + queryType.ToString() + "}";
            if (dbInstance != null) error += "{ObjectCode=" + dbInstance.Id + "}";
            if (command != null) error += "{Query=" + command.CommandText + "}";
            return error + base.ToString();
        }

        public DbExceptionType ExceptionType
        {
            get { return exceptionType; }
            protected set { exceptionType = value; }
        }

        public IDbInstance DbInstance
        {
            get { return dbInstance; }
        }

        public DbCommand Command
        {
            get { return command; }
            protected set { command = value; }
        }

        public ActionType ActionType
        {
            get { return queryType; }
            protected set { queryType = value; }
        }
    }
}
