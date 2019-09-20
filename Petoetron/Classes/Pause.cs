using System.Data.Common;
using Database;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;

namespace Petoetron.Classes
{
    public class Pause : AbstractBaseObject
    {
        public override string TableName { get { return "pauses"; } }

        private string url;

        public Pause() : this("") { }
        public Pause(string code) : base(code) { }

        #region Base overrides

        public override IObject CreateCopy()
        {
            Pause cpy = new Pause();
            cpy.CopyFrom(this);
            return cpy;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is Pause c)
            {
                base.CopyFrom(toCopy);
                Url = c.Url;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (iObject is Pause c)
            {
                return base.PropertiesEqual(iObject) &&
                    Url == c.Url;
            }
            return false;
        }

        public override void DoInsert() => DataAccess.Dal.Insert(this);
        public override void DoUpdate() => DataAccess.Dal.Update(this);
        public override void DoDelete() => DataAccess.Dal.Delete(this);

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddBaseSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "url", Url);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
            Url = DatabaseAccess.RGetString(reader, "url");
        }

        public override void OnChanged(ActionType queryType)
        {
            base.OnChanged(queryType);
            switch (queryType)
            {
                case ActionType.Insert:
                    DataAccess.Dal.OnInserted(this);
                    break;
                case ActionType.Update:
                    DataAccess.Dal.OnUpdated(this);
                    break;
                case ActionType.Delete:
                    DataAccess.Dal.OnDeleted(this);
                    break;
            }
        }

        #endregion

        #region Properties

        public string Url
        {
            get => url ?? "";
            set { url = value; OnPropertyChanged("Url"); }
        }
        #endregion
    }
}
