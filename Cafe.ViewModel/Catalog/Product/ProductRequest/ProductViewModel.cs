using Cafe.ViewModel.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.ViewModel.Catalog.Product
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateEdited { get; set; }
        public string UserEdited { get; set; }
        public string UserCreated { get; set; }
    }
}
