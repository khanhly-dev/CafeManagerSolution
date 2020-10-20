using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.ViewModel.Catalog.Sell.SellRequest
{
    public class AddProductIntoBillRequest
    {     
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int OriginalPrice { get; set; }
        public int Discout { get; set; }
        public int TotalPrice { get; set; }
    }
}
