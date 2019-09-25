using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop12rus.Domain.Filters;
using WebShop12rus.Infrastructure.Interfaces;
using WebShop12rus.ViewModels;

namespace WebShop12rus.ViewComponents
{
    //[ViewComponent(Name = "Categories")]
    public class Brands : ViewComponent
    {
        private readonly IProductService _productService;

        public Brands(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Brands = GetBrands();
            return View(Brands);
        }

        private List<BrandViewModel> GetBrands()
        {
            // Получаем список Брэндов
            var brands = _productService.GetBrands();

            // Заполняем BrandViewModels
            var BrandViewModels = new List<BrandViewModel>();
            foreach (var brand in brands)
            {
                BrandViewModels.Add(new BrandViewModel()
                {
                    Id = brand.Id,
                    Name = brand.Name,
                    Order = brand.Order,
                    ProductCount = _productService
                                .GetProducts(new ProductFilter { BrandId = brand.Id })?
                                .Count() ?? null
                });
            }

            BrandViewModels = BrandViewModels.OrderBy(c => c.Order).ToList();

            return BrandViewModels;
        }
    }
}
