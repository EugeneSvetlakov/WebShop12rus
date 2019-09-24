using System;
using System.Collections.Generic;
using System.Text;
using WebShop12rus.Domain.Entities.Base;
using WebShop12rus.Domain.Entities.Base.Interfaces;

namespace WebShop12rus.Domain.Entities
{
    public class Category : NamedEntity, IOrderedEntity
    {
        /// <summary>
        /// Id родительской категории (при наличии)
        /// </summary>
        public int? ParentId { get; set; }

        public int Order { get; set; }
    }
}
