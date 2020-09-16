using Cafe.Data.EF;
using Cafe.ViewModel.Catalog.Product.ProductRequest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cafe.ViewModel.Catalog.Sell.SellRequest;
using Cafe.Data.Entities;
using System.Runtime.InteropServices;
using Cafe.ViewModel.Catalog.Common;

namespace Cafe.Application.Catalog.Sell
{
    public class SellService : ISellService
    {
        private readonly CafeManagerDbContext _context;
        public SellService(CafeManagerDbContext context)
        {
            _context = context;
        }

        public async Task<int> CompleteSellBill(SellRequest request)
        {
            var SellBillCompleted = new ProductInSellBill()
            {
                ProductId = request.ProductId,
                SellBillId = request.SellBillId
            };

            _context.ProductInSellBills.Add(SellBillCompleted);

            return await _context.SaveChangesAsync();
        }


        public async Task<int> UndoSellBill(SellRequest request)
        {
            var sellBill = await _context.ProductInSellBills.FindAsync(request.SellBillId, request.ProductId);

            _context.ProductInSellBills.Remove(sellBill);

            return await _context.SaveChangesAsync();

        }


        public async Task<int> CreateSellBill(SellRequest request)
        {
            var sellBill = new SellBill()
            {
                Id = request.SellBillId,
                CustomerId=request.CustomerId,
                DateCreated=request.DateCreated,
                UserCreated=request.UserCreated,
                OriginalPrice=request.OriginalPrice,
                Discout=request.Discout,
                TotalPrice=request.TotalPrice,
                Note=request.Note
            };

            _context.Bills.Add(sellBill);

            return await _context.SaveChangesAsync();
        }


        public async Task<List<GetNameRequest>> GetName()
        {
            var query = from p in _context.Products
                        select p;

            var data = await query.Select(x => new GetNameRequest()
            {
                Name = x.Name,
                Price = x.Price
            }).ToListAsync();


            return data;
        }

        public async Task<List<ListProductInSellRequest>> LoadListProduct(ListProductInSellRequest request)
        {
            
            var query = from p in _context.Products
                        join pis in  _context.ProductInSellBills on p.Id equals pis.ProductId
                        select new {p, pis };

            if (!string.IsNullOrEmpty(request.SellBillId))
                query = query.Where(x => x.pis.SellBillId.Contains(request.SellBillId));

            var data = await query.Select(x => new ListProductInSellRequest()
            {
                Name = x.p.Name,
                Price = x.p.Price,
                SellBillId = x.pis.SellBillId,
                TotalPrice = 0,
                OriginalPrice = 0,
                Discout = 0,
            }).ToListAsync();

           
            return data;
        }
    }
}
