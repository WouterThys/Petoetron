using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes;
using Petoetron.Dal;
using Petoetron.Models.Base;
using System.Collections.Generic;

namespace Petoetron.Models.Customers
{
    [POCOViewModel]
    public class CustomerListViewModel : BaseListViewModel<Customer>
    {
        public static CustomerListViewModel Create()
        {
            return ViewModelSource.Create(() => new CustomerListViewModel());
        }

        public CustomerListViewModel() : base(ModuleTypes.CustomerListModule, ModuleTypes.CustomerEditModule)
        {
        }

        public override IBaseViewModel GetEditViewModel(Customer baseObject)
        {
            return CustomerEditViewModel.Create(baseObject);
        }

        public override IEnumerable<Customer> DataSource()
        {
            return DataAccess.Dal.Customers;
        }
    }
}
