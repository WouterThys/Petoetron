using Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Classes.Helpers
{
    public abstract class AbstractBaseObject : AbstractObject, IBaseObject
    {
        // Variables
        protected string description = "";
        protected string info = "";
        protected string iconPath = "";
        protected bool enabled = true;
        protected DateTime lastModified = DateTime.MinValue;

        public AbstractBaseObject(string code) : base(code)
        {

        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is AbstractBaseObject abo)
            {
                base.CopyFrom(toCopy);

                Description = abo.Description;
                Info = abo.Info;
                IconPath = abo.IconPath;
                Enabled = abo.Enabled;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (iObject is AbstractBaseObject abo)
            {
                return base.PropertiesEqual(iObject) &&
                    Description == abo.Description &&
                    Info == abo.Info &&
                    IconPath == abo.IconPath &&
                    Enabled == abo.Enabled;
            }
            return false;
        }

        public override void OnChanged(ActionType queryType)
        {
            LastModified = DateTime.Now;
            base.OnChanged(queryType);
        }

        protected override void AddBaseSqlParameters(DbCommand command)
        {
            base.AddBaseSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "description", Description);
            DatabaseAccess.AddDbValue(command, "info", Info);
            DatabaseAccess.AddDbValue(command, "iconPath", IconPath);
            DatabaseAccess.AddDbValue(command, "enabled", Enabled);
        }

        protected override void InitBaseFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
            Description = DatabaseAccess.RGetString(reader, "description");
            Info = DatabaseAccess.RGetString(reader, "info");
            IconPath = DatabaseAccess.RGetString(reader, "iconPath");
            Enabled = DatabaseAccess.RGetBool(reader, "enabled");
            LastModified = DatabaseAccess.RGetDateTime(reader, "lastModified");
        }

        #region IbaseObject Interface
        public bool IsUnknown()
        {
            return Id == UNKNOWN_ID;
        }

        public bool IsValid()
        {
            return !IsUnknown() && !string.IsNullOrEmpty(Code);
        }
        
        #endregion

        #region Properties
        public virtual string Description
        {
            get
            {
                return description ?? "";
            }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public virtual string Info
        {
            get
            {
                return info ?? "";
            }
            set
            {
                info = value;
                OnPropertyChanged("Info");
            }
        }

        public virtual string IconPath
        {
            get
            {
                return iconPath ?? "";
            }
            set
            {
                iconPath = value;
                OnPropertyChanged("IconPath");
            }
        }

        public virtual bool Enabled
        {
            get
            {
                return enabled;
            }
            set
            {
                enabled = value;
                OnPropertyChanged("Enabled");
            }
        }

        public virtual DateTime LastModified
        {
            get
            {
                return lastModified;
            }
            set
            {
                lastModified = value;
                OnPropertyChanged("LastModified");
            }
        }

        #endregion
    }
}
