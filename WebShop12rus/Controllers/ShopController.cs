using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebShop12rus.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }

        public IActionResult ProductDetails()
        {
            return View();
        }
    }
}