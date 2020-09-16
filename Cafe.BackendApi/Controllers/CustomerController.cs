using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafe.Application.Catalog.Customers;
using Cafe.ViewModel.Catalog.Customer.CustomerRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetCustomerPagingRequest request)
        {
            var customer = await _customerService.GetCustomerPaging(request);
            return Ok(customer);
        }
    }
}
