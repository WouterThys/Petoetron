using Database;
using Petoetron.Classes.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Classes
{
    public class ObjectLog : IObject
    {
        public string TableName { get; }

        // Variables
        public DateTime ActionDate { get; set; }
        public ActionType ActionType { get; set; }
        public long ActionBy { get; set; }
        public long ActionOn { get; set; }
        public long ObjectId { get; set; }
        protected string objectCode;

        public ObjectLog()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is ObjectLog log &&
                   ActionDate == log.ActionDate &&
                   Id == log.Id;
        }

        public override int GetHashCode()
        {
            var hashCode = 1454027411;
            hashCode = hashCode * -1521134295 + ActionDate.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            return hashCode;
        }

        #region INTERFACE METHODS

        public IObject CreateCopy()
        {
            ObjectLog log = new ObjectLog();
            log.CopyFrom(this);
            return log;
        }

        public void CopyFrom(IObject toCopy)
        {
            if (toCopy is ObjectLog log)
            {
                ObjectId = log.Id;
                Code = log.Code;
                ActionDate = log.ActionDate;
                ActionType = log.ActionType;
                ActionBy = log.ActionBy;
                ActionOn = log.ActionOn;
            }
        }

        public bool PropertiesEqual(IObject iObject)
        {
            if (iObject is ObjectLog log)
            {
                return
                    Id == log.Id &&
                    Code == log.Code &&
                    ActionDate == log.ActionDate &&
                    ActionType == log.ActionType &&
                    ActionBy == log.ActionBy &&
                    ActionOn == log.ActionOn;
            }
            return false;
        }

        public string Code
        {
            get { return objectCode; }
            set { objectCode = value; }
        }

        public long Id { get { return ObjectId; } set { } }
        


        public int ActionTypeAsInt
        {
            get { return (int)ActionType; }
        }
        #endregion

        #region Database
        public string GetScript(ActionType actionType)
        {
            throw new NotImplementedException();
        }

        public void AddSqlParameters(DbCommand command)
        {
            throw new NotImplementedException();
        }

        public void InitFromReader(DbDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public void OnChanged(ActionType queryType)
        {
            throw new NotImplementedException();
        }

        public void OnFailed(Database.DbException dbException)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
