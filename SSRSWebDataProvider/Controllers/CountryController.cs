using SSRSWebDataProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SSRSWebDataProvider.Controllers
{
    public class CountryController : ApiController
    {
        public IEnumerable<Country> Get()
        {
            return new List<Country>()
            {
                new Country(){ID = 1, Name = "United Kingdom", ContinentID=1},
                new Country(){ID = 2, Name = "France", ContinentID=1},
                new Country(){ID = 3, Name = "Spain", ContinentID=1},
                new Country(){ID = 4, Name = "Italy", ContinentID=1},
                new Country(){ID = 5, Name = "Brazil", ContinentID=2},
                new Country(){ID = 6, Name = "Argentina", ContinentID=2},
                new Country(){ID = 7, Name = "USA", ContinentID=3},
                new Country(){ID = 8, Name = "Canada", ContinentID=3},
                new Country(){ID = 9, Name = "China", ContinentID=4},
                new Country(){ID = 10, Name = "India", ContinentID=4},
                new Country(){ID = 11, Name = "Egypt", ContinentID=5},
                new Country(){ID = 12, Name = "Tunisia", ContinentID=5},
                new Country(){ID = 13, Name = "Australia", ContinentID=6}
            };
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<IEnumerable<Country>> PostAsync()
        {
            string result = await Request.Content.ReadAsStringAsync();
            var requestDetails = result.Split('=');
            

            return Get().Where(country => country.ContinentID == int.Parse(requestDetails[1]));
        }

        //public IEnumerable<Country> Post()
        //{
        //    return Get().Where(country => country.ContinentID == 1);
        //}
    }
}
