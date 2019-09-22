using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShop12rus.Infrastructure;

namespace WebShop12rus.Controllers
{
    public class HomeController : Controller
    {
        [SimpleActionFilter]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}