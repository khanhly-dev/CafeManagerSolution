using Cafe.ViewModel.Catalog.Common;
using Cafe.ViewModel.Catalog.Customer.CustomerRequest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Application.Catalog.Customers
{
    public interface ICustomerService
    {
        Task<PageResult<CustomerViewModel>> GetCustomerPaging(GetCustomerPagingRequest request);

        Task<int> CreateCustomer(CustomerCreateRequest request);
        Task<int> UpdateCustomer(CustomerUpdateRequest request);
        Task<int> DeleteCustomer(int customerId);
    }
}
