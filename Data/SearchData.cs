using SearchSaver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.Data
{
    public class SearchData
    {

        //store searches
        private static Dictionary<int, Search> Searches = new Dictionary<int, Search>();

        // add searches
        public static void Add(Search newSearch)
        {
            Searches.Add(newSearch.SearchID, newSearch);
        }

        //retrieve the searches
        public static IEnumerable<Search> GetAll()
        {
            return Searches.Values;
        }

        //retreive a single search
        public static Search GetById(int id)
        {
            return Searches[id];
        }

        //remove an search
        public static void Remove(int id)
        {
            Searches.Remove(id);
        }



    }
}
