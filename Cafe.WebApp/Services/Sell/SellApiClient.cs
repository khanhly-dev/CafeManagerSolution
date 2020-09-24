using Cafe.ViewModel.Catalog.Product.ProductRequest;
using Cafe.ViewModel.Catalog.Sell.SellRequest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cafe.WebApp.Services.Sell
{
    public class SellApiClient : ISellApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SellApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<GetNameRequest>> GetName()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:5001");

            var response = await client.GetAsync("/api/Sell/GetName");
            var body = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<GetNameRequest>>(body);
            return data;
        }

        public async Task<List<ListProductInSellRequest>> LoadListProduct(ListProductInSellRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:5001");

            var response = await client.GetAsync($"/api/Sell/LoadListProduct?keyword={request.SellBillId}");
            var body = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<ListProductInSellRequest>>(body);
            return data;
        }


        public async Task<bool> Create(SellBillCreateRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:5001");

            var requestContent = new MultipartFormDataContent();

            requestContent.Add(new StringContent(request.SellBillId.ToString()), "SellBillId");
            requestContent.Add(new StringContent(request.CustomerId.ToString()), "CustomerId");
            requestContent.Add(new StringContent(request.DateCreated.ToString()), "DateCreated");
            requestContent.Add(new StringContent(request.UserCreated.ToString()), "UserCreated");
            requestContent.Add(new StringContent(request.OriginalPrice.ToString()), "OriginalPrice");
            requestContent.Add(new StringContent(request.Discout.ToString()), "Discout");
            requestContent.Add(new StringContent(request.TotalPrice.ToString()), "TotalPrice");
            requestContent.Add(new StringContent(request.Note.ToString()), "Note");

            var response = await client.PostAsync("/api/Sell/", requestContent);

            return response.IsSuccessStatusCode;
        }
    }
}
