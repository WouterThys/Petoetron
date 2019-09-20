using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using System.Collections.Generic;

namespace Petoetron.Models.Pauses
{
    [POCOViewModel]
    public class PauseListViewModel : BaseListViewModel<Pause>
    {
        public static PauseListViewModel Create()
        {
            return ViewModelSource.Create(() => new PauseListViewModel());
        }

        public PauseListViewModel() : base(ModuleTypes.PauseListModule, ModuleTypes.PauseEditModule)
        {
        }

        public override IBaseViewModel GetEditViewModel(Pause baseObject)
        {
            return PauseEditViewModel.Create(baseObject);
        }

        public override IEnumerable<Pause> DataSource()
        {
            return DataAccess.Dal.Pauses;
        }
    }
}
