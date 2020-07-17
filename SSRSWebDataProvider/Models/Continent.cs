using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSRSWebDataProvider.Models
{
    public class Continent
    {
        public Continent() { }

        public Continent(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public int ID { get; set; }
        public string Name { get; set; }
    }
}