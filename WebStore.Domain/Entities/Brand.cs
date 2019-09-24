using System;
using System.Collections.Generic;
using System.Text;
using WebShop12rus.Domain.Entities.Base;
using WebShop12rus.Domain.Entities.Base.Interfaces;

namespace WebShop12rus.Domain.Entities
{
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
