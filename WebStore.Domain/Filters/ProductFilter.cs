﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop12rus.Domain.Filters
{
    public class ProductFilter
    {
        public int? CategoryId { get; set; }

        public int? BrandId { get; set; }

        public List<int> Ids { get; set; }
    }
}
