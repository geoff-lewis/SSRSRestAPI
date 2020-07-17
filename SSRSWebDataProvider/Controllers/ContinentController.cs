using SSRSWebDataProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SSRSWebDataProvider.Controllers
{
    public class ContinentController : ApiController
    {
        public IEnumerable<Continent> Get()
        {
            return new List<Continent>()
            {
                new Continent(1,"Europe"),
                new Continent(2,"South America"),
                new Continent(3,"North America"),
                new Continent(4, "Asia"),
                new Continent(5, "Africa"),
                new Continent(6, "Oceania")
            };
        }
    }
}
