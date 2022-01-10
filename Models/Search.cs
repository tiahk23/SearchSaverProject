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

        public int SearchID { get; set; }
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
                   SearchID == @search.SearchID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SearchID);
        }
    }
}
