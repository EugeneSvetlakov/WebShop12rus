using System;
using System.Collections.Generic;
using System.Text;
using WebShop12rus.Domain.Entities.Base.Interfaces;

namespace WebShop12rus.Domain.Entities.Base
{
    public class NamedEntity : INamedEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
