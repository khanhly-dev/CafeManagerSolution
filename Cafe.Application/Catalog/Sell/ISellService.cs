using Cafe.ViewModel.Catalog.Common;
using Cafe.ViewModel.Catalog.Product.ProductRequest;
using Cafe.ViewModel.Catalog.Sell.SellRequest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Application.Catalog.Sell
{
    public interface ISellService
    {
        Task<List<GetNameRequest>> GetName();

        Task<int> CreateSellBill(SellRequest request);

        Task<int> CompleteSellBill(SellRequest request);

        Task<int> UndoSellBill(SellRequest request);

        Task<List<ListProductInSellRequest>> LoadListProduct(ListProductInSellRequest request);
    }
}
