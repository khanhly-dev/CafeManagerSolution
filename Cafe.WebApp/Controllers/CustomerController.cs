using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafe.ViewModel.Catalog.Customer.CustomerRequest;
using Cafe.WebApp.Services.Customer;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.WebApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerApiClient _customerApiClient;

        public CustomerController(ICustomerApiClient customerApiClient)
        {
            _customerApiClient = customerApiClient;
        }

        public async Task<IActionResult> Index(GetCustomerPagingRequest request)
        {
            var data = await _customerApiClient.GetAll(request);
            return View(data);
        }
    }
}
