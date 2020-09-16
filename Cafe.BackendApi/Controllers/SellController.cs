using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafe.Application.Catalog.Sell;
using Cafe.ViewModel.Catalog.Sell.SellRequest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellController : ControllerBase
    {
        private readonly ISellService _productService;

        public SellController(ISellService productService)
        {
            _productService = productService;
        }

        [HttpGet("getName")]
        public async Task<IActionResult> GetAllPaging()
        {
            var products = await _productService.GetName();
            return Ok(products);
        }

        [HttpGet("LoadListProduct")]
        public async Task<IActionResult> LoadListProduct([FromQuery] ListProductInSellRequest request)
        {
            var listProducts = await _productService.LoadListProduct(request);
            return Ok(listProducts);
        }
    }
}
