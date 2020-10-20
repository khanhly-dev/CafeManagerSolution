using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.ViewModel.Catalog.Sell.SellRequest
{
    public class UpdateProductInBillRequest
    {
        public string SellBillId { get; set; }
        public int ProductId { get; set; }
    }
}
