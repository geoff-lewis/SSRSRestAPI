using SSRSWebDataProvider.Models;
using SSRSWebDataProvider.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SSRSWebDataProvider.Controllers
{
    public class CountryVisitsController : ApiController
    {
        private readonly DataSource m_DataSource = new DataSource();

        public IEnumerable<CountryVisit> Get()
        {
            return m_DataSource.CountryVisits;
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<IEnumerable<CountryVisit>> PostAsync()
        {
            string requestString = await Request.Content.ReadAsStringAsync();
            var query = new RequestStringQuery(requestString);

            if (query.IsValidForValue(typeof(CountryVisit)))
            {
                return Get().Where(countryVisit => query.IsMatch(countryVisit));
            }

            return Enumerable.Empty<CountryVisit>();
        }

    }
}
