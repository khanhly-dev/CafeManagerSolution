using Cafe.ViewModel.Catalog.Common;
using Cafe.ViewModel.Catalog.Product;
using Cafe.ViewModel.Catalog.Product.ProductRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.WebApp.Services
{
    public interface IProductApiClient
    {
        Task<PageResult<ProductViewModel>> GetPagings(GetProductPagingRequest request);
    }
}
