using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Cafe.ViewModel.Catalog.Product.ProductRequest;
using Cafe.ViewModel.Catalog.Sell.SellRequest;
using Cafe.WebApp.Services.Sell;
using Cafe.WebApp.TempData;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.WebApp.Controllers
{
    public class SellController : Controller
    {
        private readonly ISellApiClient _sellApiClient;
      
        public SellController(ISellApiClient sellApiClient)
        {
            _sellApiClient = sellApiClient;
          
        }

        [HttpGet]
        public async Task<IActionResult>Index(AddProductIntoBillRequest request)
        {
            

            var product = new AddProductIntoBillRequest()
            {
                Name = request.Name,
                Price = request.Price,
                Quantity = request.Quantity,
                OriginalPrice = request.Price * request.Quantity,
                Discout = request.Discout,
                TotalPrice = request.OriginalPrice - request.Discout
            };

            ListProductInBillData.instance.listProduct.Add(product);

            ViewData["data"] = ListProductInBillData.instance.listProduct;

            //get data for seach box
            var comboboxData = await _sellApiClient.GetName();

            ViewData["combobox"] = comboboxData;

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
    }
}
