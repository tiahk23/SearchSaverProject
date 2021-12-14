using Microsoft.AspNetCore.Mvc;
using SearchSaver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.Controllers
{
    public class TVController : Controller
    {

        static private List<TV> TVS = new List<TV>();
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.tvs = TVS;
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/TV/Add")]
        public IActionResult NewTV(string name, string description, string price)
        {
            TVS.Add(new TV(name, description, price));
            return Redirect("/TV");
        }
    }
}
