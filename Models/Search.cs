using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.Models
{
    public class Search
    {
        public string SearchQuery { get; set; }
        //private DateTime DateandTime { get; set; }

        public int Id { get; set; }
        public Search()
        {
        }
        public Search(string searchQuery)
        {
            SearchQuery = searchQuery;
        }

        public override string ToString()
        {
            return SearchQuery;
        }

        public override bool Equals(object obj)
        {
            return obj is Search @search &&
                   Id == @search.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
