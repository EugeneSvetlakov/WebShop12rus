﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop12rus.ViewModels
{
    public class CatalogViewModel
    {
        public int? BrandId { get; set; }

        public int? CategoryId { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
