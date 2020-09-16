using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Data.Entities
{
    public class SupplierInStockBill
    {
        public string StockBillId { get; set; }
        public StockBill StockBill { get; set; }
        public string SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
