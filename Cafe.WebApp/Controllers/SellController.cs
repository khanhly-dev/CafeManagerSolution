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

        [HttpGet]
        public async Task<IActionResult>Index(ListProductInSellRequest request)
        {
            var data = await _sellApiClient.LoadListProduct(request);

            ViewData["data"] = data;
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Index([FromForm] SellBillCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _sellApiClient.Create(request);
            if (result)
            {
                TempData["result"] = "Thêm mới sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Thêm sản phẩm thất bại");

            
            return View(request);

        }

        //public async Task<IActionResult> LoadListProduct(ListProductInSellRequest request)
        //{
        //    var listProduct = await _sellApiClient.LoadListProduct(request);
        //    return View(listProduct);
            
        //}     

        public async Task<List<GetNameRequest>> GetName()
        {
            var data = await _sellApiClient.GetName();

            return data;
        }
    }
}
