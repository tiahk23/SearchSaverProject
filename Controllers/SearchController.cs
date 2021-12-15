using Microsoft.AspNetCore.Mvc;
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
