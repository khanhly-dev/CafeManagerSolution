using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Data.Entities
{
    public class ProductInSellBill
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string SellBillId { get; set; }
        public SellBill SellBill { get; set; }
    }
}
