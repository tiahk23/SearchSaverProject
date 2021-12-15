using Microsoft.AspNetCore.Mvc;
using SearchSaver.Data;
using SearchSaver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.Controllers
{
    public class TVController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.tvs = TVData.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/TV/Add")]
        public IActionResult NewTV(string store, string description, string price, string brand)
        {
            TVData.Add(new TV(store, description, price, brand));
            return Redirect("/TV");
        }

        public IActionResult Delete()
        {
            ViewBag.tvs = TVData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] tvIds)
        {
            foreach(int tvId in tvIds)
            {
                TVData.Remove(tvId);
            }
            return Redirect("/TV");
        }
    }
}
