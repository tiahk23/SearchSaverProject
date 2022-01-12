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
    public class ProductController : Controller
    {
        private ServiceDbContext context;

        public ProductController(ServiceDbContext dbContext)
        {
            context = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = context.Products.ToList();
            context.SaveChanges();
            return View(products);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddProductViewModel addProductViewModel = new AddProductViewModel();
            return View(addProductViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddProductViewModel addProductViewModel)
        {
            if (ModelState.IsValid)
            {
                Product newProduct = new Product
                {
                    Store = addProductViewModel.Store,
                    Brand = addProductViewModel.Brand,
                    Category = addProductViewModel.Category,
                    Price = addProductViewModel.Price,
                    Description = addProductViewModel.Description
                };
                context.Products.Add(newProduct);
                context.SaveChanges();
                return Redirect("/Product");
            }
            return View(addProductViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.products = context.Products.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] Id)
        {
            if (Id is null)
            {
                throw new ArgumentNullException(nameof(Id));
            }

            foreach (var productId in Id)
            {
                Product newProduct = context.Products.Find(productId);
                context.Products.Remove(newProduct);
            }
            context.SaveChanges();
            return Redirect("/Product");
        }
        [HttpPost]
        public IActionResult Search()
        {
           
            return Redirect("/Results");

        }
        [HttpGet]
        public IActionResult Results()
        {
            List<Product> products = context.Products.ToList();
            context.SaveChanges();
            return View(products);
        }
    }
}
