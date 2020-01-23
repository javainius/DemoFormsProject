using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DemoFormsProject.Models;
using FormsDB.Repositories;
using FormsDB.Models;

namespace DemoFormsProject.Controllers
{
    public class PersonController : Controller
    {
        [HttpPost]
        public ContentResult CreatePerson([FromBody] PersonModel data)
        {
            PeopleRepository.CreatePerson(new PersonDbModel(data.FirstName,
                                                            data.LastName,
                                                            Int32.Parse(data.Age)));

            return Content("", "application/json");
        }

        [HttpGet]
        public JsonResult GetPeople()
        {
            var persons = new List<PersonModel>();
            var personsFromDb = PeopleRepository.GetPeople();

            foreach (var person in personsFromDb)
            {
                persons.Add(new PersonModel(person.FirstName, person.LastName, person.Age.ToString()));
            }
            return Json(persons);
        }
    }
}