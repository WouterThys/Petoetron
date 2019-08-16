using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Classes
{
    public class QuotationMaterialList : LinkList<Material>
    {
        public QuotationMaterialList(long objectId) : base(objectId)
        {
        }

        public override LinkList<Material> CreateCopy()
        {
            QuotationMaterialList ll = new QuotationMaterialList(ObjectId);
            ll.CopyFrom(this);
            return ll;
        }

        protected override IEnumerable<long> GetIds(long id)
        {
            return DataAccess.Dal.FindMaterialsIdsForQuotation(id);
        }

        protected override Material GetById(long id)
        {
            return DataAccess.Dal.Materials.ById(id);
        }
    }
}
