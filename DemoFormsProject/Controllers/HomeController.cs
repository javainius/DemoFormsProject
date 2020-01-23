using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoFormsProject.Models;
using FormsDB.Logic;
using FormsDB.Models;

namespace DemoFormsProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ContentResult SendingData([FromBody] PersonModel data)
        {
            ObjectProcessor.AddPersonsInfoToDatabase(new PersonDbModel(data.FirstName,
                                                                       data.LastName,
                                                                       Int32.Parse(data.Age)));

            return Content("", "application/json");
        }

        [HttpGet]
        public JsonResult GettingData()
        {
            var persons = new List<PersonModel>();
            var personsFromDb = ObjectProcessor.GetAllPersons();

            foreach(var person in personsFromDb)
            {
                persons.Add(new PersonModel(person.FirstName, person.LastName, person.Age.ToString()));//???????????????????????
            }
            return Json(persons);
        }
    }
}
