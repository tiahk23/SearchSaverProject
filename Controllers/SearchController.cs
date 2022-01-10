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
        private ServiceDbContext context;

        public SearchController(ServiceDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Search> searches = context.Searches.ToList();

            return View(searches);
        }


        [HttpPost]
        [Route("/search")]
        public IActionResult Results(Product newProduct, Search newSearch)
        {
            ///ToDo: add a foreach loop to display specific products
            ViewBag.searchedProduct = newSearch;
            if (newProduct.Category == newSearch.ToString())
            {
                return Redirect("/product");
            }
            else
            {
                return View();
            }
            
        }

    }
}
