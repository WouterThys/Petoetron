using DevExpress.Mvvm.DataAnnotations;
using Petoetron.Models.Base;
using DevExpress.Mvvm.POCO;
using System.Threading.Tasks;

namespace Petoetron.Models.Other
{
    [POCOViewModel]
    public class InputDialogViewModel : BaseViewModel
    {
        public static InputDialogViewModel Create(string name)
        {
            return ViewModelSource.Create(() => new InputDialogViewModel(name, ""));
        }

        public static InputDialogViewModel Create(string name, string value)
        {
            return ViewModelSource.Create(() => new InputDialogViewModel(name, value));
        }

        public virtual string Name { get; set; }
        public virtual string Value { get; set; }

        protected InputDialogViewModel(string name, string value) : base(ModuleTypes.SimpleInputModule)
        {
            Name = name;
            Value = value;
        }

        public override Task Load()
        {
            return null;
        }
    }
}
