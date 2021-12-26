using Microsoft.AspNetCore.Mvc;
using SearchSaver.Data;
using SearchSaver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.Controllers
{
    public class SearchController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.searches = SearchData.GetAll();

            return View();
        }


        [HttpPost]
        [Route("/search")]
        public IActionResult Results(string product)
        {
            ViewBag.searchedProduct = product;
            if (product == "")
            {
                return View();
            }
            else
            {
                return Redirect("/product");
            }
            
        }

    }
}
