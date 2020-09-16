using Cafe.ViewModel.Catalog.Common;
using Cafe.ViewModel.Catalog.Customer.CustomerRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.WebApp.Services.Customer
{
    public interface ICustomerApiClient
    {
        Task<PageResult<CustomerViewModel>> GetAll(GetCustomerPagingRequest request);
    }
}
