using Database;
using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using System.Data.Common;

namespace Petoetron.Classes
{
    public class MaterialType : AbstractBaseObject
    {
        public override string TableName { get { return "materialtypes"; } }

        public MaterialType() : this("") { }
        public MaterialType(string code) : base (code) { }

        

        public override IObject CreateCopy()
        {
            MaterialType cpy = new MaterialType();
            cpy.CopyFrom(this);
            return cpy;
        }

        public override void DoInsert() => DataAccess.Dal.Insert(this);
        public override void DoUpdate() => DataAccess.Dal.Update(this);
        public override void DoDelete() => DataAccess.Dal.Delete(this);

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddBaseSqlParameters(command);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
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
    }
}
