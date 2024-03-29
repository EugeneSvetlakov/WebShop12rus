﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebShop12rus.Domain.Entities.Base;
using WebShop12rus.Domain.Entities.Base.Interfaces;

namespace WebShop12rus.Domain.Entities
{
    [Table("Brands")]
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
