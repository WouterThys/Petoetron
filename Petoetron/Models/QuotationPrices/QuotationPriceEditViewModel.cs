﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
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

        private readonly List<QuotationMaterial> allMaterials = new List<QuotationMaterial>();
        public virtual BindingList<QuotationMaterial> PriceMaterials { get; set; }
        public virtual List<QuotationMaterial> SelectedPriceMaterials { get; set; }

        public Action<Quotation, CancelEventArgs> OnDone;
        public Action OnOpenMaterials;

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
            this.RaiseCanExecuteChanged(x => x.Done());
            this.RaiseCanExecuteChanged(x => x.ToMaterials());
        }

        public override void Loading()
        {
            base.Loading();
            allMaterials.AddRange(Quotation.Materials.Values);
        }

        private QuotationPrice currentPrice;
        public override void OnSelectionChanged()
        {
            SaveSelection();

            // New selection
            if (Selection != null && Selection.Count == 1)
            {
                currentPrice = Selection[0];
                if (currentPrice != null && currentPrice.PriceType != null && currentPrice.PriceType.MaterialDependant)
                {
                    PriceMaterials = new BindingList<QuotationMaterial>(allMaterials);
                    foreach (QuotationMaterial qm in PriceMaterials)
                    {
                        qm.Selected = currentPrice.Materials.Contains(qm.Id);
                    }
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

        public virtual void OnSelectedPriceMaterialsChanged()
        {
            if (currentPrice != null)
            {
                currentPrice.Materials.Set(SelectedPriceMaterials);
                currentPrice.UpdatePrice();
            }
        }

        public void SaveSelection()
        {
            // Save old selection
            if (currentPrice != null && PriceMaterials != null)
            {
                currentPrice.Materials.Set(PriceMaterials.Where(pm => pm.Selected));
            }
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

        public virtual bool CanDone()
        {
            return !IsLoading;
        }
        public virtual void Done()
        {
            SaveSelection();
            OnDone?.Invoke(Quotation, null);
        }
        public override void OnClose(CancelEventArgs e)
        {
            OnDone?.Invoke(Quotation, e);
            base.OnClose(e);
        }

        public virtual bool CanToMaterials()
        {
            return !IsLoading;
        }
        public virtual void ToMaterials()
        {
            Done();
            OnOpenMaterials?.Invoke();
        }

        public override void Zoom()
        {
            throw new NotImplementedException();
        }

    }
}
