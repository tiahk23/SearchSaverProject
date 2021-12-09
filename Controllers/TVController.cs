using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.Controllers
{
    public class TVController : Controller
    {

        static private List<string> TVS = new List<string>();

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
        public IActionResult NewTV(string name)
        {
            TVS.Add(name);
            return Redirect("/TV");
        }
    }
}
