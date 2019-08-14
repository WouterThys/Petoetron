using Petoetron.Classes.Helpers;
using System.Data.Common;

namespace Petoetron.Classes
{
    public class MaterialType : AbstractBaseObject
    {
        public override string TableName { get { return "MaterialTypes"; } }

        public MaterialType() : this("") { }
        public MaterialType(string code) : base (code) { }

        

        public override IObject CreateCopy()
        {
            MaterialType cpy = new MaterialType();
            cpy.CopyFrom(this);
            return cpy;
        }


        public override void AddSqlParameters(DbCommand command)
        {
            base.AddBaseSqlParameters(command);
        }

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitBaseFromReader(reader);
        }
    }
}
