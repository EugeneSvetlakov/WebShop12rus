using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop12rus.Domain.Entities.Base.Interfaces;

namespace WebShop12rus.ViewModels
{
    public class BrandViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public int? ProductCount { get; set; }
    }
}
