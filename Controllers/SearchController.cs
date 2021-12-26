using Microsoft.AspNetCore.Mvc;
using SearchSaver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.Controllers
{
    public class SearchController : Controller
    {
        public static List<Search> Searches = new List<Search>();
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.searches = Searches;

            return View();
        }


        [HttpPost]
        [Route("/search")]
        public IActionResult Results(string product)
        {
            ViewBag.searchedProduct = product;
            if(product.ToLower() == "tv")
            {

                return Redirect("/tv");
            }
            else
            {
                return View();
            }
            
        }

    }
}
