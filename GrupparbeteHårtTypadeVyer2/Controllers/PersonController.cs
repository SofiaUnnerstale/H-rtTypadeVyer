using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GrupparbeteHårtTypadeVyer2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GrupparbeteHårtTypadeVyer2.Controllers
{
    public class PersonController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(Person person)
        {
            var models = Person.GetPersons();
            return View(models); //(models)
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(Person person)
        {
            DataManager.AddPerson(person);

            return View();
        }
    }
}
