using Cafe.Data.EF;
using Cafe.ViewModel.Catalog.Product;
using Cafe.ViewModel.Catalog.Product.ProductRequest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Cafe.ViewModel.Catalog.Common;
using eShopSolution.Utilities.Exceptions;
using Cafe.Data.Entities;
using Cafe.Application.Catalog.Products;

namespace Cafe.Application.Catalog.Products
{
    public class ProductService : IProductService
    {
        private readonly CafeManagerDbContext _context;
        public ProductService(CafeManagerDbContext context)
        {
            _context = context;
        }
        //thêm
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Id = request.Id,
                Name = request.Name,
                Price = request.Price,
                Description = request.Description,
                DateCreated = request.DateCreated,
                UserCreated = request.UserCreated
            };

            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }


        //xóa
        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);

            if (product == null) throw new CafeException($"Cannot find a product: {productId}");

            _context.Products.Remove(product);

            return await _context.SaveChangesAsync();
        }


        //sửa
        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);

            if(product==null)
            {
                throw new CafeException($"Cannot find a product: {request.Id}");
            }

            product.Id = request.Id;
            product.Name = request.Name;
            product.Price = request.Price;
            product.Description = request.Description;
            product.DateEdited = DateTime.Now;

            return await _context.SaveChangesAsync();

        }

        public async Task<PageResult<ProductViewModel>> GetProductPaging(GetProductPagingRequest request)
        {
            var query = from p in _context.Products
                        select p;



            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.Name.Contains(request.Keyword));
            }

            int totalRow = await query.CountAsync();

            var data = await query
                .Skip((request.PageIndex-1)*request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    DateCreated = x.DateCreated,
                    Description = x.Description,
                    UserCreated = x.UserCreated,

                }).ToListAsync();

            var pageResult = new PageResult<ProductViewModel>()
            {
                PageSize=request.PageSize,
                PageIndex=request.PageIndex,
                TotalRecords=totalRow,
                Items = data
            };
            return pageResult;
        }

        public async Task<ProductViewModel> GetById(int ProductId)
        {
            var product = await _context.Products.FindAsync(ProductId);
            var productViewModel = new ProductViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Quantity = product.Quantity,
                Price = product.Price,
                Description = product.Description,
                DateCreated = product.DateCreated,
                DateEdited = product.DateEdited,
                UserCreated = product.UserCreated,
                UserEdited = product.UserEdited
            };

            return productViewModel;
        }


    
    }
}
