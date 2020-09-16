using Cafe.Data.EF;
using Cafe.ViewModel.Catalog.Common;
using Cafe.ViewModel.Catalog.Customer.CustomerRequest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eShopSolution.Utilities.Exceptions;
using Cafe.Data.Entities;
using System.Security.Cryptography.X509Certificates;

namespace Cafe.Application.Catalog.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly CafeManagerDbContext _context;
        public CustomerService(CafeManagerDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateCustomer(CustomerCreateRequest request)
        {
            var customer = new Customer()
            {
                Id = request.Id,
                Name = request.Name,
                PhoneNumber = request.PhoneNumber,
                Adress= request.Adress,
                Sex=request.Sex,
                DOB = request.DOB
            };

            _context.Customers.Add(customer);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteCustomer(int customerId)
        {
            var customer = await _context.Customers.FindAsync(customerId);

            if (customer == null) throw new CafeException($"Cannot find a customer: {customerId}");

            _context.Customers.Remove(customer);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateCustomer(CustomerUpdateRequest request)
        {
            var customer = await _context.Customers.FindAsync(request.Id);

            if (customer == null)
            {
                throw new CafeException($"Cannot find a customer: {request.Id}");
            }

            customer.Id = request.Id;
            customer.Name = request.Name;
            customer.PhoneNumber = request.PhoneNumber;
            customer.Adress = request.Adress;
            customer.Sex = request.Sex;
            customer.DOB = request.DOB;

            return await _context.SaveChangesAsync();
        }

        public async Task<PageResult<CustomerViewModel>> GetCustomerPaging(GetCustomerPagingRequest request)
        {
            var query = from p in _context.Customers
                        select p;

            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.Name.Contains(request.Keyword));

            //int totalRow = await query.CountAsync();

            var data = await query
                .Select(x => new CustomerViewModel()
                {
                    Id=x.Id,
                    Name=x.Name,
                    Adress=x.Adress,
                    PhoneNumber=x.PhoneNumber,
                    DOB=x.DOB,
                    Sex=x.Sex

                }).ToListAsync();

            var pageResult = new PageResult<CustomerViewModel>()
            {
                Items = data
            };
            return pageResult;
        }

       
    }
}
