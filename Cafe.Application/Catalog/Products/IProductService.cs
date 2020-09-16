using Cafe.ViewModel.Catalog.Common;
using Cafe.ViewModel.Catalog.Product;
using Cafe.ViewModel.Catalog.Product.ProductRequest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Application.Catalog.Products
{
    public interface IProductService
    {
        //phuong thuc them san pham
        Task<int> Create(ProductCreateRequest request);

        //phuong thuc xoa san pham
        Task<int> Delete(int productId);

        //phuong thuc sua san pham
        Task<int> Update(ProductUpdateRequest request);

        Task<ProductViewModel> GetById(int productId);

        Task<PageResult<ProductViewModel>> GetProductPaging(GetProductPagingRequest request);
    }
}
