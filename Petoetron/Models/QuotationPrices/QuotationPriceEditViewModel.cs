using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Other;
using Petoetron.Models.Quotations.Helpers;

namespace Petoetron.Models.QuotationPrices
{
    [POCOViewModel]
    public class QuotationPriceEditViewModel : BaseQuoationListEditViewModel<PriceType, QuotationPrice>
    {
        public static QuotationPriceEditViewModel Create(Quotation quotation)
        {
            return ViewModelSource.Create(() => new QuotationPriceEditViewModel(quotation));
        }

        public virtual BindingList<QuotationMaterial> PriceMaterials { get; set; }

        protected QuotationPriceEditViewModel(Quotation quotation) : base(
            ModuleTypes.QuotationPriceEditModule,
            () => DataAccess.Dal.PriceTypes.Where(p => p.MaterialDependant),
            (q) => q.Prices)
        {
            Quotation = quotation;
            Load();
        }

        public override void UpdateCommands()
        {
            base.UpdateCommands();
            
        }

        public override void OnSelectionChanged()
        {
            if (Selection != null && Selection.Count == 1)
            {
                QuotationPrice price = Selection[0];
                if (price != null && price.PriceType != null && price.PriceType.MaterialDependant)
                {
                    PriceMaterials = new BindingList<QuotationMaterial>(new List<QuotationMaterial>(price.Materials.Values));
                }
                else
                {
                    PriceMaterials = new BindingList<QuotationMaterial>();
                }
            }
            else
            {
                PriceMaterials = new BindingList<QuotationMaterial>();
            }
            base.OnSelectionChanged();
        }

        protected override QuotationPrice CreateQuotationItem(PriceType t)
        {
            QuotationPrice qm = base.CreateQuotationItem(t);
            if (t != null)
            {
                qm.SetPrice(t);
            }
            return qm;
        }

       


        public override void Zoom()
        {
            throw new NotImplementedException();
        }

    }
}
