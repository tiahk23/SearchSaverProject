using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.Models
{
    public class TV
    {
        public string Description { get; set; }
        public string Price { get; set; }
        public string Brand { get; set; }

        public int Id { get; }
        static private int nextId = 1;
        public TV(string description, string price, string brand)
        {
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
