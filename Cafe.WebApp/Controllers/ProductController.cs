﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Cafe.ViewModel.Catalog.Common;
using Cafe.ViewModel.Catalog.Product;
using Cafe.ViewModel.Catalog.Product.ProductRequest;
using Cafe.WebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Cafe.WebApp.Controllers
{
    public class ProductController : Controller
    {
       
        private readonly IProductApiClient _productApiClient;

        public ProductController( IProductApiClient productApiClient)
        {           
            _productApiClient = productApiClient;
        }



        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10 )
        {
            var request = new GetProductPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
            };
            var data = await _productApiClient.GetPagings(request);
            ViewBag.pageIndex = pageIndex;          
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        } 
    }
        
}
