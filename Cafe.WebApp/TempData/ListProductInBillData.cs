using Cafe.ViewModel.Catalog.Sell.SellRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.WebApp.TempData
{
    public class ListProductInBillData
    {
        public List<AddProductIntoBillRequest> listProduct = new List<AddProductIntoBillRequest>();

        public static ListProductInBillData instance = new ListProductInBillData();
        private ListProductInBillData()
        {

        }
    }
}
