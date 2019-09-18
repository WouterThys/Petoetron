using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using System.Collections.Generic;
using System.ComponentModel;

namespace Petoetron.Models.PriceTypes
{
    [POCOViewModel]
    public class PriceTypeEditViewModel : BaseObjectEditViewModel<PriceType>
    {
        public static PriceTypeEditViewModel Create(PriceType original)
        {
            return ViewModelSource.Create(() => new PriceTypeEditViewModel(original));
        }

       
        protected PriceTypeEditViewModel(PriceType original) : base(ModuleTypes.PriceTypeEditModule, original)
        {
            Load();
        }
        
    }
}
