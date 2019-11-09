using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop12rus.Domain.Entities;
using WebShop12rus.Domain.Filters;
using WebShop12rus.ViewModels;

namespace WebShop12rus.Infrastructure.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Brand> GetBrands();

        IEnumerable<Category> GetCategories();

        IEnumerable<Product> GetProducts(ProductFilter filter);

        // CRUD Product
        // Create/Update
        void EditProduct(Product product);

        // Read
        Product GetProductById(int id);

        // Delete
        void DeleteProduct(int id);
    }
}
