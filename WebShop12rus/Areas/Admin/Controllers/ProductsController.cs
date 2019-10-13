using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShop12rus.Domain.Entities;
using WebShop12rus.Domain.Filters;
using WebShop12rus.Infrastructure.Interfaces;

namespace WebShop12rus.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrators")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(_productService.GetProducts(new ProductFilter()));
        }

        [HttpGet]
        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
                return View(new Product());

            Product model = _productService.GetProductById(id.Value);
            if (model == null)
                return NotFound(); // Возвращаем результат 404 Not Found

            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        [Authorize(Roles = "Administrators")]
        public IActionResult Edit(Product model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _productService.EditProduct(model);

            //_productService.UpdateProduct(model);

            return RedirectToAction(nameof(Index));
        }
    }
}