using Cafe.ViewModel.Catalog.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.ViewModel.Catalog.Customer.CustomerRequest
{
    public class GetCustomerPagingRequest : PagingRequestBase
    { 
        public string Keyword { get; set; }
    }
}
