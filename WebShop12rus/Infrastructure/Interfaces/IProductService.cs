using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop12rus.Domain.Entities;

namespace WebShop12rus.Infrastructure.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Brand> GetProducts();

        IEnumerable<Category> GetCategory();
    }
}
