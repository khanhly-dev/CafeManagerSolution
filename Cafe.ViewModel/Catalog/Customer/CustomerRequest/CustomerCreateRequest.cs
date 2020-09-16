using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.ViewModel.Catalog.Customer.CustomerRequest
{
    public class CustomerCreateRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public bool Sex { get; set; }
        public DateTime DOB { get; set; }

    }
}
