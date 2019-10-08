using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop12rus.DAL;
using WebShop12rus.Domain.Entities;
using WebShop12rus.Domain.Filters;
using WebShop12rus.Infrastructure.Interfaces;

namespace WebShop12rus.Infrastructure.Services
{
    public class SqlProductService : IProductService
    {
        private readonly WebShop12rusDbContext _context;

        public SqlProductService(WebShop12rusDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products
                .Include(p => p.Category) // "жадная загрузка" - механизм EF
                .Include(p=> p.Brand) // "жадная загрузка" - механизм EF
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var query = _context.Products
                .Include(p=> p.Category)
                .Include(p=> p.Brand)
                .AsQueryable();
            if (filter.BrandId.HasValue)
            {
                query = query.Where(c => c.BrandId.HasValue && c.BrandId.Value.Equals(filter.BrandId.Value));
            }
            if (filter.CategoryId.HasValue)
            {
                query = query.Where(c => c.CategoryId.Equals(filter.CategoryId.Value));
            }

            return query.ToList();
        }
    }
}
