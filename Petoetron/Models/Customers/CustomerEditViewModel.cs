using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Models.Base;

namespace Petoetron.Models.Customers
{
    [POCOViewModel]
    public class CustomerEditViewModel : BaseObjectEditViewModel<Customer>
    {
        public static CustomerEditViewModel Create(Customer original)
        {
            return ViewModelSource.Create(() => new CustomerEditViewModel(original));
        }

        protected CustomerEditViewModel(Customer original) : base(ModuleTypes.CustomerEditModule, original)
        {
            Load();
        }
    }
}
