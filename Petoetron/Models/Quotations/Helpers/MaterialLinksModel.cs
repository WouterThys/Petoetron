using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using Petoetron.Models.QuotationMaterials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Petoetron.Models.Quotations.Helpers
{
    [POCOViewModel]
    public class MaterialLinksModel : BaseDocumentViewModel, IDataChanged<Material>
    {
        public static MaterialLinksModel Create(Action _updateBaseCommands)
        {
            return ViewModelSource.Create(() => new MaterialLinksModel(_updateBaseCommands));
        }

        // Helpers
        private long insertId = -10;
        private Action _updateBaseCommands;

        private Quotation Quotation { get; set; }
        public virtual QuotationMaterial Selected { get; set; }
        public virtual BindingList<QuotationMaterial> QuotationMaterials { get; set; }

        public MaterialLinksModel(Action _updateBaseCommands) : base(ModuleTypes.QuotationEditModule)
        {
            this._updateBaseCommands = _updateBaseCommands;
        }

        public override Task Load()
        {
            throw new NotImplementedException();
        }
        
        List<QuotationMaterial> tmpList;
        public void Loading(Quotation quotation)
        {
            Quotation = quotation;
            tmpList = new List<QuotationMaterial>(Quotation.Materials.Values);
        }

        public void Loaded()
        {
            QuotationMaterials = new BindingList<QuotationMaterial>(tmpList);
        }
        

        public void OnSelectedChanged()
        {
            UpdateCommands();
        }

        public void UpdateCommands()
        {
            this.RaiseCanExecuteChanged(x => x.Add());
            this.RaiseCanExecuteChanged(x => x.Edit());
            this.RaiseCanExecuteChanged(x => x.Delete());
        }

        private void QuotationMaterialSaved(QuotationMaterial qm)
        {
            Quotation.Materials.Add(qm);
            int ndx = QuotationMaterials.IndexOf(qm);
            if (ndx >= 0)
            {
                QuotationMaterials[ndx].CopyFrom(qm);
            }
            else
            {
                QuotationMaterials.Add(qm);
            }
            UpdateCommands();
            _updateBaseCommands();
        }

        public void QuotationMaterialDeleted(QuotationMaterial qm)
        {
            Quotation.Materials.Remove(qm);
            int ndx = QuotationMaterials.IndexOf(qm);
            if (ndx >= 0)
            {
                QuotationMaterials.RemoveAt(ndx);
                UpdateCommands();
                _updateBaseCommands();
            }
        }



        public virtual bool CanAdd()
        {
            return Quotation != null;
        }
        public virtual void Add()
        {
            QuotationMaterial quotationMaterial = new QuotationMaterial(Quotation)
            {
                Id = insertId--
            };
            QuotationMaterialEditViewModel model = QuotationMaterialEditViewModel.Create(quotationMaterial,
                (qm) => { QuotationMaterialSaved(qm); },
                (qm) => { QuotationMaterialDeleted(qm); });
            ShowDocument(model);
        }

        public virtual bool CanEdit()
        {
            return Quotation != null && Selected != null;
        }
        public virtual void Edit()
        {
            QuotationMaterialEditViewModel model = QuotationMaterialEditViewModel.Create(Selected,
                (qm) => { QuotationMaterialSaved(qm); },
                (qm) => { QuotationMaterialDeleted(qm); });
            ShowDocument(model);
        }

        public virtual bool CanDelete()
        {
            return Quotation != null && Selected != null;
        }
        public virtual void Delete()
        {
            QuotationMaterialDeleted(Selected);
        }



        #region IDataChanged Interface
        void IDataChanged<Material>.OnInserted(Material inserted)
        {

        }
        void IDataChanged<Material>.OnUpdated(Material updated)
        {

        }
        void IDataChanged<Material>.OnDeleted(Material deleted)
        {

        }
        #endregion
    }
}
