using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop12rus.Infrastructure.Services;

namespace WebShop12rus.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult CartDetails()
        {
            return View("CartDetails", _cartService.TransformCart());
        }

        public IActionResult DecrementFromCart(int id)
        {
            _cartService.DecrementFromCart(id);

            return RedirectToAction("CartDetails");
        }

        public IActionResult RemoveFromCart(int id)
        {
            _cartService.RemoveFromCart(id);

            return RedirectToAction("CartDetails");
        }

        public IActionResult RemoveAll()
        {
            _cartService.RemoveAll();

            return RedirectToAction("CartDetails");
        }

        public IActionResult AddToCart(int id, string returnUrl)
        {
            _cartService.AddToCart(id);

            return Redirect(returnUrl);
        }
    }
}