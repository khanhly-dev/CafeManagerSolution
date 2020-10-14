using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Data.Entities
{
    public class SellBill
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserCreated { get; set; }
        public int OriginalPrice { get; set; }
        public int Discout { get; set; }
        public int TotalPrice { get; set; }
        public int Pay { get; set; }
        public int PayBack { get; set; }
        public string Note { get; set; }

        public List<ProductInSellBill> ProductInSellBills { get; set; }
        public Customer Customer { get; set; }

    }
}
