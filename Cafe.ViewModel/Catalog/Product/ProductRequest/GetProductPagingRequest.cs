using Cafe.ViewModel.Catalog.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.ViewModel.Catalog.Product.ProductRequest
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
