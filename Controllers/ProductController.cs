using Microsoft.AspNetCore.Mvc;
using SearchSaver.Data;
using SearchSaver.Models;
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
            ViewBag.products = ProductData.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Product/Add")]
        public IActionResult NewProduct(Product newProduct)
        {
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
