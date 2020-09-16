﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.ViewModel.Catalog.Common
{
    public class PagingRequestBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }

        public int TotalRecords { get; set; }
    }
}