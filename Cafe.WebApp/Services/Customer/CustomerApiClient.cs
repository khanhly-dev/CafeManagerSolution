using Cafe.ViewModel.Catalog.Common;
using Cafe.ViewModel.Catalog.Customer.CustomerRequest;
using Cafe.ViewModel.Catalog.Product;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cafe.WebApp.Services.Customer
{
    public class CustomerApiClient : ICustomerApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public CustomerApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<PageResult<CustomerViewModel>> GetAll(GetCustomerPagingRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:5001");

            var response = await client.GetAsync($"/api/Customer/GetAll?keyword={request.Keyword}");
            var body = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<PageResult<CustomerViewModel>>(body);
            return data;
        }
    }
}
