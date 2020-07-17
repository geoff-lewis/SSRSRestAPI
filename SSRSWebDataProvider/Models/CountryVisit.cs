using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSRSWebDataProvider.Models
{
    public class CountryVisit : IDatedItem
    {
        public CountryVisit() { }

        public CountryVisit(DateTime date, Country country, string comment)
        {
            Date = date;
            Country = country;
            Comment = comment;
        }

        public DateTime Date { get; set; }
        public Country Country { get; set; }
        public string Comment { get; set; }
    }
}