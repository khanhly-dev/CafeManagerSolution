using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.ViewModel.Catalog.Product.ProductRequest
{
    public class ProductCreateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserCreated { get; set; }
    }
}
