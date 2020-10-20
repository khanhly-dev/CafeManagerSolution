using Cafe.ViewModel.Catalog.Common;
using Cafe.ViewModel.Catalog.Product;
using Cafe.ViewModel.Catalog.Product.ProductRequest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cafe.WebApp.Services
{
    public class ProductApiClient : IProductApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<PageResult<ProductViewModel>> GetPagings(GetProductPagingRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:5001");

            var response = await client.GetAsync(
                $"/api/Product/GetAll?keyword={request.Keyword}" + 
                $"&pageIndex={request.PageIndex}" + 
                $"&pageSize={request.PageSize}"
                );
            var body = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<PageResult<ProductViewModel>>(body);
            return data;
        }
    }
}
