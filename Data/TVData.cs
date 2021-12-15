using SearchSaver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.Data
{
    public class TVData
    {
        //store tvs
        private static Dictionary<int, TV> TVs = new Dictionary<int, TV>(); 
        //add tvs
        public static void Add(TV newTV)
        {
                TVs.Add(newTV.Id, newTV);
        }


        //retrieve events
        public static IEnumerable<TV> GetAll()
        {
            return TVs.Values;
        }
        //retreive single event
        public static TV GetById(int id)
        {
            return TVs[id];
        }
        //remove an event
        public static void Remove(int id)
        {
            TVs.Remove(id);
        }
    }
}
