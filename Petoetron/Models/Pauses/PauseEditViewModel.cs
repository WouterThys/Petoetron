using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Models.Base;

namespace Petoetron.Models.Pauses
{
    [POCOViewModel]
    public class PauseEditViewModel : BaseObjectEditViewModel<Pause>
    {
        public static PauseEditViewModel Create(Pause original)
        {
            return ViewModelSource.Create(() => new PauseEditViewModel(original));
        }

        protected PauseEditViewModel(Pause original) : base(ModuleTypes.PauseEditModule, original)
        {
            Load();
        }
    }
}
