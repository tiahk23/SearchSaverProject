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

        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = new List<Product>(ProductData.GetAll());
            return View(products);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddProductViewModel addProdutViewModel = new AddProductViewModel();
            return View(addProdutViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddProductViewModel addProdutViewModel)
        {
            Product newProduct = new Product
            {
                Store = addProdutViewModel.Store,
                Brand = addProdutViewModel.Brand,
                Category = addProdutViewModel.Category,
                Price = addProdutViewModel.Price,
                Description = addProdutViewModel.Description
            };
            ProductData.Add(newProduct);
            return Redirect("/Product");
        }

        public IActionResult Delete()
        {
            ViewBag.products = ProductData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] productIds)
        {
            foreach(int productId in productIds)
            {
                ProductData.Remove(productId);
            }
            return Redirect("/Product");
        }
    }
}
