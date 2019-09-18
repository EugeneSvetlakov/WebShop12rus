using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebShop12rus.Controllers
{
    public class CartController : Controller
    {
        public IActionResult CartDetails()
        {
            return View();
        }
    }
}