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

namespace Petoetron.Models.QuotationMaterials
{
    [POCOViewModel]
    public class QuotationMaterialEditViewModel : BaseQuoationListEditViewModel<Material, QuotationMaterial>
    {
        public static QuotationMaterialEditViewModel Create(Quotation quotation)
        {
            return ViewModelSource.Create(() => new QuotationMaterialEditViewModel(quotation));
        }

        public Action<Quotation, CancelEventArgs> OnDone;
        public Action OnOpenPrices;

        protected QuotationMaterialEditViewModel(Quotation quotation) : base (
            ModuleTypes.QuotationMaterialEditModule,
            ( ) => DataAccess.Dal.Materials,
            (q) => q.Materials)
        {
            Quotation = quotation;
            Load();
        }

        public override void UpdateCommands()
        {
            base.UpdateCommands();

            this.RaiseCanExecuteChanged(x => x.Done());
            this.RaiseCanExecuteChanged(x => x.ToPrices());
            this.RaiseCanExecuteChanged(x => x.CopyGroup());
            this.RaiseCanExecuteChanged(x => x.Group());
            this.RaiseCanExecuteChanged(x => x.UnGroup());
        }
        
        protected override QuotationMaterial CreateQuotationItem(Material t)
        {
            QuotationMaterial qm = base.CreateQuotationItem(t);
            if (t != null)
            {
                qm.SetMaterial(t);
            }
            return qm;
        }


        public virtual bool CanDone()
        {
            return !IsLoading;
        }
        public virtual void Done()
        {
            OnDone?.Invoke(Quotation, null);
        }
        public override void OnClose(CancelEventArgs e)
        {
            OnDone?.Invoke(Quotation, e);
            base.OnClose(e);
        }

        public virtual bool CanToPrices()
        {
            return !IsLoading;
        }
        public virtual void ToPrices()
        {
            Done();
            OnOpenPrices?.Invoke();
        }

        public virtual bool CanCopyGroup()
        {
            return !IsLoading && Selection != null && Selection.Count > 0;
        }
        public virtual void CopyGroup()
        {
            InputDialogViewModel model = InputDialogViewModel.Create("Nuum");
            var res = DialogService.ShowDialog(MessageButton.OKCancel, "Grup", "SimpleInputView", model);
            if (res == MessageResult.OK)
            {
                List<QuotationMaterial> newQms = new List<QuotationMaterial>();
                foreach (QuotationMaterial qm in Selection)
                {
                    QuotationMaterial newQm = (QuotationMaterial)qm.CreateCopy();
                    newQm.Id = Classes.Helpers.AbstractQuoationItem.NextId;
                    newQm.GroupCode = model.Value;
                    newQms.Add(newQm);
                }
                AddQItems(newQms);
            }
            
        }


        public virtual bool CanGroup()
        {
            return !IsLoading && Selection != null && Selection.Count > 0;
        }
        public virtual void Group()
        {
            InputDialogViewModel model = InputDialogViewModel.Create("Nuum");
            var res = DialogService.ShowDialog(MessageButton.OKCancel, "Grup", "SimpleInputView", model);
            if (res == MessageResult.OK)
            {
                foreach (QuotationMaterial qm in Selection)
                {
                    qm.GroupCode = model.Value;
                }
            }
        }

        public virtual bool CanUnGroup()
        {
            return !IsLoading && Selection != null && Selection.Count > 0;
        }
        public virtual void UnGroup()
        {
            foreach (QuotationMaterial qm in Selection)
            {
                qm.GroupCode = "";
            }
        }



        public override void Zoom()
        {
            throw new NotImplementedException();
        }
        
    }
}
