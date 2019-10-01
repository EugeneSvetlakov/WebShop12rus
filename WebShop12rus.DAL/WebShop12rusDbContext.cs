using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebShop12rus.Domain.Entities;

namespace WebShop12rus.DAL
{
    // Добавить миграцию: 
    // 1) -Project WebShop12rus.DAL - проект содержащий DbContext
    // 2) -Name Initial - имя миграции
    // Add-Migration -Project WebShop12rus.DAL -Name Initial
    // Обновить БД:
    // Update-Database
    public class WebShop12rusDbContext : IdentityDbContext<User>
    {
        public WebShop12rusDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
