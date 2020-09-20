using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Cafe.ViewModel.Catalog.Product.ProductRequest;
using Cafe.ViewModel.Catalog.Sell.SellRequest;
using Cafe.WebApp.Services.Sell;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.WebApp.Controllers
{
    public class SellController : Controller
    {
        private readonly ISellApiClient _sellApiClient;

        public SellController( ISellApiClient sellApiClient)
        {
            _sellApiClient = sellApiClient;
        }

        public async Task<IActionResult> Index(ListProductInSellRequest request, SellRequest sellRequest)
        {           
            var billData = await _sellApiClient.LoadListProduct(request);
            ViewData["data"] = billData;
            return View();
        }


        public async Task<List<GetNameRequest>> GetName()
        {
            var data = await _sellApiClient.GetName();

            return data;
        }
    }
}
