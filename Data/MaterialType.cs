using Classes.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
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
    }
}
