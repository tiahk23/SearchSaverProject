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
        private ApplicationDbContext context;

        public SearchController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Search> searches = new List<Search>(SearchData.GetAll());

            return View(searches);
        }


        [HttpPost]
        [Route("/search")]
        public IActionResult Results(Product newProduct, Search newSearch)
        {
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

        public IActionResult Delete()
        {
            ViewBag.searches = SearchData.GetAll();

            return View();
        }

    }
}
