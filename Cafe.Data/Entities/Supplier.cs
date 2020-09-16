using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Data.Entities
{
    public class Supplier
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Note { get; set; }

        public List<SupplierInStockBill> SupplierInStockBills { get; set; }
    }
}
