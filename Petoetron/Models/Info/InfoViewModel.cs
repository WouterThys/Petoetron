using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Models.Base;
using Petoetron.Services;
using System;
using System.Threading.Tasks;

namespace Petoetron.Models.Info
{
    [POCOViewModel]
    public class InfoViewModel : BaseViewModel
    {
        public static InfoViewModel Create()
        {
            return ViewModelSource.Create(() => new InfoViewModel());
        }

        protected InfoViewModel() : base(ModuleTypes.InfoModule)
        {
            
        }

        public override Task Load()
        {
            return null;
        }
    }
}
