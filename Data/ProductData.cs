using SearchSaver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.Data
{
    public class ProductData
    {
        //store tvs
        private static Dictionary<int, Product> Products = new Dictionary<int, Product>(); 
        //add tvs
        public static void Add(Product newProduct)
        {
                Products.Add(newProduct.Id, newProduct);
        }


        //retrieve events
        public static IEnumerable<Product> GetAll()
        {
            return Products.Values;
        }
        //retreive single event
        public static Product GetById(int id)
        {
            return Products[id];
        }
        //remove an event
        public static void Remove(int id)
        {
            Products.Remove(id);
        }
    }
}
