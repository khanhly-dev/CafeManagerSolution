using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Data.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsShowSell { get; set; }
        public bool IsShowProduct { get; set; }
        public bool IsShowCustomer { get; set; }
        public bool IsShowSupplier { get; set; }
        public bool IsShowTranfers { get; set; }
        public bool IsShowSellBill { get; set; }
        public bool IsShowStockBill { get; set; }
        public bool IsShowEmployee { get; set; }
        public bool IsShowRevenue { get; set; }



        public List<User> Users { get; set; }
    }
}
