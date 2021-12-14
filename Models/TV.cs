using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.Models
{
    public class TV
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public TV(string name, string description, string price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
