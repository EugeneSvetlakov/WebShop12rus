using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebShop12rus.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult ProductDetails()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult BlogSingl()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}