using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Data.Entities
{
    public class StockBill
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int OriginalPrice { get; set; }
        public int Discout { get; set; }
        public int TotalPrice { get; set; }

        public List<SupplierInStockBill> SupplierInStockBills { get; set; }
    }
}
