using Cafe.ViewModel.Catalog.Sell.SellRequest;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.WebApp.Controllers.Components
{
    public class ListProductInBillViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(ListProductInSellRequest result)
        {
            return Task.FromResult((IViewComponentResult)View("Default" , result));
        }
    }
}
