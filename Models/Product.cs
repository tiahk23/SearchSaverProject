using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.Models
{
    public class Product
    {
        public string Store { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Brand { get; set; }

        public int Id { get; }
        static private int nextId = 1;
        public Product(string store, string description, string price, string brand)
        {
            Store = store;
            Description = description;
            Price = price;
            Brand = brand;
            Id = nextId;
            nextId++;
        }

        public override string ToString()
        {
            return Brand;
        }
    }
}
