using System;

namespace Database
{
    class DbQueueObject
    {

        private readonly ActionType queryType;
        private readonly IDbInstance dbInstance;
        private readonly string sql;

        private DateTime insertTime;
        private DateTime removeTime;
        
        
        public DbQueueObject(IDbInstance dbInstance, ActionType queryType) : this (dbInstance, queryType, "")
        {

        }

        public DbQueueObject(IDbInstance dbInstance, ActionType queryType, string sql)
        {
            this.dbInstance = dbInstance;
            this.queryType = queryType;
            this.sql = sql;
        }

        public override string ToString()
        {
            return queryType + " " + dbInstance;
        }

        public ActionType QueryType
        {
            get { return queryType; }
        }

        public IDbInstance DbInstance
        {
            get { return dbInstance; } 
        }

        public string Sql
        {
            get { return Sql; } 
        }

        public DateTime InsertTime
        {
            get { return insertTime; }
            set { insertTime = value; }
        }

        public DateTime RemoveTime
        {
            get { return removeTime; }
            set { removeTime = value; } 
        }

        public TimeSpan TimeInQueue
        {
            get
            {
                if (InsertTime != null && RemoveTime != null)
                {
                    return InsertTime.Subtract(RemoveTime);
                }
                else
                {
                    return new TimeSpan(0);
                }
            }
        }

    }
}
