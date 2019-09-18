using Database;
using Petoetron.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;

namespace Petoetron.Classes.Helpers
{
    public abstract class AbstractObject : IObject, INotifyPropertyChanged, IEquatable<AbstractObject>
    {
        public static readonly long UNKNOWN_ID = 1;

        // Base properties
        public event PropertyChangedEventHandler PropertyChanged;
        public abstract string TableName { get; }

        // Variables
        protected long id = -1;
        protected string code = "";

        public AbstractObject() : this("")
        {
        }

        public AbstractObject(string code)
        {
            this.code = code;
        }

        protected void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as AbstractObject);
        }

        public bool Equals(AbstractObject other)
        {
            return other != null &&
                   TableName == other.TableName &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            var hashCode = -1653615172;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TableName);
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(AbstractObject object1, AbstractObject object2)
        {
            return EqualityComparer<AbstractObject>.Default.Equals(object1, object2);
        }

        public static bool operator !=(AbstractObject object1, AbstractObject object2)
        {
            return !(object1 == object2);
        }

        #region IObject Interface

        public abstract IObject CreateCopy();

        public virtual void CopyFrom(IObject toCopy)
        {
            if (toCopy != null)
            {
                Id = toCopy.Id;
                Code = toCopy.Code;
            }
        }

        public virtual bool PropertiesEqual(IObject iObject)
        {
            if (iObject is AbstractObject abo)
            {
                return // Don't compare Id and Key!!
                    Code == abo.Code;
            }
            return false;
        }

        #endregion

        #region IDbObject Interface

        public abstract void AddSqlParameters(DbCommand command);
        public abstract void InitFromReader(DbDataReader reader);
        public abstract void OnChanged(ActionType type);
        public abstract void DoInsert();
        public abstract void DoUpdate();
        public abstract void DoDelete();

        public string GetScript(ActionType actionType)
        {
            return TableName + actionType.ToString(); ;
        }

        protected virtual void AddBaseSqlParameters(DbCommand command)
        {
            DatabaseAccess.AddDbValue(command, "id", Id);
            DatabaseAccess.AddDbValue(command, "code", Code);
        }

        protected virtual void InitBaseFromReader(DbDataReader reader)
        {
            Id = DatabaseAccess.RGetLong(reader, "id");
            Code = DatabaseAccess.RGetString(reader, "code");
        }

        public virtual bool Save()
        {
            if (Id <= 0)
            {
                DoInsert();
            }
            else
            {
                DoUpdate();
            }
            return true;
        }

        public virtual bool Delete()
        {
            if (Id > UNKNOWN_ID)
            {
                DoDelete();
                return true;
            }
            return false;
        }
        
        public void OnFailed(Database.DbException dbException)
        {
            DataAccess.Dal.DbQueryFailed(dbException);
        }
        #endregion

        #region Properties

        public virtual long Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual string Code
        {
            get
            {
                return code ?? "";
            }
            set
            {
                code = value;
                OnPropertyChanged("Code");
            }
        }
        
        #endregion
    }
}
