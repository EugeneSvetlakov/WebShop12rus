using System;
using System.Collections.Generic;
using System.Text;
using WebShop12rus.Domain.Entities.Base.Interfaces;

namespace WebShop12rus.Domain.Entities.Base
{
    class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}
