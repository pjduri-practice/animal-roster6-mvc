using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimalRoster6.Controllers
{
    public class AnimalsController : Controller
    {
        private static List<Dictionary<string, string>> Animals = new List<Dictionary<string, string>>();

        [HttpGet]
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.animals = Animals;
            return View();
        }

        [HttpGet]
        [Route("Animals/Add")]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        [Route("Animals/Add")]
        public IActionResult Add(string name, string species, string desc, string imgUrl)
        {
            Animals.Add(new Dictionary<string, string>
            {
                {"name", name },
                {"species", species },
                {"description", desc },
                {"imgUrl", imgUrl }
            });

            return Redirect("/Animals");
        }
    }
}

