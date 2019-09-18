using Petoetron.Classes.Helpers;
using Petoetron.Dal;
using System.Collections.Generic;

namespace Petoetron.Classes
{
    public class QuotationMaterialList : LinkList<QuotationMaterial>
    {
        public QuotationMaterialList(long objectId) : base(objectId)
        {
        }

        public override LinkList<QuotationMaterial> CreateCopy()
        {
            QuotationMaterialList ll = new QuotationMaterialList(ObjectId);
            ll.CopyFrom(this);
            return ll;
        }

        protected override IEnumerable<long> GetIds(long id)
        {
            return DataAccess.Dal.FindMaterialsIdsForQuotation(id);
        }

        protected override QuotationMaterial GetById(long id)
        {
            return DataAccess.Dal.QuotationMaterials.ById(id);
        }
    }

    public class QuotationPriceList : LinkList<QuotationPrice>
    {
        public QuotationPriceList(long objectId) : base(objectId)
        {
        }

        public override LinkList<QuotationPrice> CreateCopy()
        {
            QuotationPriceList ll = new QuotationPriceList(ObjectId);
            ll.CopyFrom(this);
            return ll;
        }

        protected override IEnumerable<long> GetIds(long id)
        {
            return DataAccess.Dal.FindPricesIdsForQuotation(id);
        }

        protected override QuotationPrice GetById(long id)
        {
            return DataAccess.Dal.QuotationPrices.ById(id);
        }
    }
}
