using System;
using System.Collections.Generic;
using System.Text;
using WebShop12rus.Domain.Entities.Base;

namespace WebShop12rus.Domain.Entities
{
    public class Order: NamedEntity
    {
        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime Date { get; set; }

        public virtual User User { get; set; } // связь в БД через внешний ключ

        public virtual ICollection<OrderItem> OrderItems { get; set; } // связь в БД через внешний ключ
    }
}
