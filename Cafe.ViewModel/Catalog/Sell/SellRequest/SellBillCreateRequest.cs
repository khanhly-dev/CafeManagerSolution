using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cafe.ViewModel.Catalog.Sell.SellRequest
{
    public class SellBillCreateRequest
    {
        public string SellBillId { get; set; }
        public string CustomerId { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserCreated { get; set; }
        public int OriginalPrice { get; set; }
        public int Discout { get; set; }
        public int TotalPrice { get; set; }
        public int Pay { get; set; }
        public int PayBack { get; set; }
        public string Note { get; set; }
    }
}
