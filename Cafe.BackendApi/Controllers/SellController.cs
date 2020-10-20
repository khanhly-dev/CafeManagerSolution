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
        private readonly ISellService _sellService;

        public SellController(ISellService sellService)
        {
            _sellService = sellService;
        }



        [HttpGet("getName")]
        public async Task<IActionResult> GetAllPaging()
        {
            var products = await _sellService.GetName();
            return Ok(products);
        }

        [HttpGet("LoadListProduct")]
        public async Task<IActionResult> LoadListProduct([FromQuery] ListProductInSellRequest request)
        {
            var listProducts = await _sellService.LoadListProduct(request);
            return Ok(listProducts);
        }

        [HttpPost("create")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] SellBillCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var sellBill = await _sellService.CreateSellBill(request);
            return Ok(sellBill);
        }

        [HttpPost("AddProduct")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> AddProductIntoSellBill([FromForm] UpdateProductInBillRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productInSellBill = await _sellService.AddProductIntoSellBill(request);
            return Ok(productInSellBill);
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteProductFromSellBill([FromForm] UpdateProductInBillRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productInSellBill = await _sellService.DeleteProductFromSellBill(request);
            return Ok(productInSellBill);
        }
    }
}
