using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop12rus.Infrastructure.Interfaces;
using WebShop12rus.ViewModels;

namespace WebShop12rus.Controllers
{
    [Route("Users")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: Home
        [Route("all")]
        public ActionResult Index()
        {
            //return Content("Привет. Я твой первый контроллер!");
            return View(_employeeService.GetAll());
        }

        // GET: Detailed model item by id
        [Route("{id}")]
        public ActionResult Details(int id)
        {
            //return Content("Привет. Я твой первый контроллер!");
            return View(_employeeService.GetById(id));
        }

        [HttpGet]
        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
                return View(new EmployeeView());

            EmployeeView model = _employeeService.GetById(id.Value);
            if (model == null)
                return NotFound(); // Возвращаем результат 404 Not Found

            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(EmployeeView model)
        {
            if(model.Id > 0) // если есть Id - редактируем модель
            {
                var dbItem = _employeeService.GetById(model.Id);

                if (ReferenceEquals(dbItem, null))
                    return NotFound(); // Возвращаем результат 404 Not Found

                dbItem.FirstName = model.FirstName;
                dbItem.LastName = model.LastName;
                dbItem.Patronymic = model.Patronymic;
                dbItem.Age = model.Age;
            }
            else // иначе добавляем модель в список
            {
                _employeeService.AddNew(model);
            }

            _employeeService.Commit(); // Станет актуальна с БД

            return RedirectToAction(nameof(Index));
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _employeeService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}