using Microsoft.AspNetCore.Mvc;
using SearchSaver.Data;
using SearchSaver.Models;
using SearchSaver.ViewModels;
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
            /*List<Search> searches = context.Searches.ToList();
            context.SaveChanges();
            return View(searches);*/
            AddSearchViewModel addSearchViewModel = new AddSearchViewModel();
            return View(addSearchViewModel);
        }

       

        [HttpPost]
        [Route("/search")]
        public IActionResult Results(AddSearchViewModel addSearchViewModel)
        {

            if (ModelState.IsValid)
            {
                Search newSearch = new Search
                {
                    SearchQuery = addSearchViewModel.SearchQuery
                };
                context.Searches.Add(newSearch);
                context.SaveChanges();
                
                return Redirect("/Product");
            }
            return View(addSearchViewModel);
        }

    }
}
