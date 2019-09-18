using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Petoetron.Models.QuotationMaterials
{
    [POCOViewModel]
    public class QuotationMaterialEditViewModel : BaseEditViewModel<QuotationMaterial>
    {
        public static QuotationMaterialEditViewModel Create(QuotationMaterial original, 
            Action<QuotationMaterial> _saved, 
            Action<QuotationMaterial> _deleted)
        {
            return ViewModelSource.Create(() => new QuotationMaterialEditViewModel(original, _saved, _deleted));
        }

        public virtual BindingList<Material> Materials { get; set; }

        private readonly Action<QuotationMaterial> _saved;
        private readonly Action<QuotationMaterial> _deleted;

        protected QuotationMaterialEditViewModel(QuotationMaterial original,
            Action<QuotationMaterial> _saved,
            Action<QuotationMaterial> _deleted) 
            : base(ModuleTypes.QuotationMaterialEditModule, original)
        {
            checkCode = false;
            this._saved = _saved;
            this._deleted = _deleted;
            Load();
        }

        private List<Material> tmpList;
        public override void OnLoading()
        {
            base.OnLoading();

            tmpList = new List<Material>(DataAccess.Dal.Materials);
        }

        public override void OnLoaded()
        {
            Materials = new BindingList<Material>(tmpList);

            base.OnLoaded();

        }


        public override bool CanSave()
        {
            if (IsSaving || IsLoading) return false;

            return !propertiesEqual && Editable != null;
        }

        protected override void DoSave(QuotationMaterial entity)
        {
            DispatcherService.BeginInvoke(() =>
            {
                _saved?.Invoke(entity);
                Original.CopyFrom(entity);
                Inserted(entity);
            });
        }

        protected override void DoDelete(QuotationMaterial toDelete)
        {
            DispatcherService.BeginInvoke(() =>
            {
                _deleted?.Invoke(toDelete);
                Deleted(toDelete);
            });
        }
    }
}
