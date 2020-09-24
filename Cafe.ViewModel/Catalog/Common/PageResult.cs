using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.ViewModel.Catalog.Common
{
    public class PageResult<T> : PageResultBase
    {
        public List<T> Items { get; set; }
        
    }
}
