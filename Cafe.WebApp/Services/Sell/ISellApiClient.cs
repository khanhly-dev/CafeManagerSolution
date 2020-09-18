using Cafe.ViewModel.Catalog.Product.ProductRequest;
using Cafe.ViewModel.Catalog.Sell.SellRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.WebApp.Services.Sell
{
    public interface ISellApiClient
    {
        Task<List<GetNameRequest>> GetName();

        Task<List<ListProductInSellRequest>> LoadListProduct(ListProductInSellRequest request);

        Task<bool> Create(SellRequest request);
    }
}
