using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop12rus.ViewModels;

namespace WebShop12rus.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                LastName = "Иванов",
                FirstName = "Иван",
                Patronymic = "Иванович",
                Age = 35
            },
            new EmployeeView
            {
                Id = 2,
                LastName = "Петров",
                FirstName = "Ким",
                Patronymic = "Торжиевич",
                Age = 22
            }
        };

        // GET: Home
        public ActionResult Index()
        {
            //return Content("Привет. Я твой первый контроллер!");
            return View(_employees);
        }
        
        // GET: Detailed model item by id
        public ActionResult Details(int id)
        {
            //return Content("Привет. Я твой первый контроллер!");
            return View(_employees.FirstOrDefault(x => x.Id == id));
        }

    }
}