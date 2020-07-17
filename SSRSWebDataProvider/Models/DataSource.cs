using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSRSWebDataProvider.Models
{
    public class DataSource
    {

        public Country UnitedKingdom => new Country() { ID = 1, Name = "United Kingdom", ContinentID = 1 };
        public Country France => new Country() { ID = 2, Name = "France", ContinentID = 1 };
        public Country Spain => new Country() { ID = 3, Name = "Spain", ContinentID = 1 };
        public Country Italy => new Country() { ID = 4, Name = "Italy", ContinentID = 1 };
        public Country Brazil => new Country() { ID = 5, Name = "Brazil", ContinentID = 2 };
        public Country Argentina => new Country() { ID = 6, Name = "Argentina", ContinentID = 2 };
        public Country USA => new Country() { ID = 7, Name = "USA", ContinentID = 3 };
        public Country Canada => new Country() { ID = 8, Name = "Canada", ContinentID = 3 };
        public Country China => new Country() { ID = 9, Name = "China", ContinentID = 4 };
        public Country India => new Country() { ID = 10, Name = "India", ContinentID = 4 };
        public Country Egypt => new Country() { ID = 11, Name = "Egypt", ContinentID = 5 };
        public Country Tunisia => new Country() { ID = 12, Name = "Tunisia", ContinentID = 5 };
        public Country Australia => new Country() { ID = 13, Name = "Australia", ContinentID = 6 };

        public IEnumerable<Country> Countries
        {
            get
            {
                return new List<Country>()
                {
                    UnitedKingdom,France,Spain,Italy,Brazil,Argentina,USA,Canada,China,India,Egypt,Tunisia,Australia
                };
            }
        }

        public  IEnumerable<CountryVisit> CountryVisits
        {
            get
            {
                return new List<CountryVisit>()
                {
                    new CountryVisit(new DateTime(2004,12,10),Canada,"Very cold"),
                    new CountryVisit(new DateTime(2005,12,10),USA,"Long trip"),
                    new CountryVisit(new DateTime(2006,12,10),Egypt,"Perfect temperature this time of year"),
                    new CountryVisit(new DateTime(2007,12,10),Australia,"First trip"),
                    new CountryVisit(new DateTime(2008,12,10),Australia,"Second trip"),
                    new CountryVisit(new DateTime(2009,12,10),France,"Holiday"),
                    new CountryVisit(new DateTime(2010,12,10),China,"Holiday"),
                    new CountryVisit(new DateTime(2011,12,10),Argentina,"Holiday"),
                    new CountryVisit(new DateTime(2012,12,10),Spain,"Holiday"),
                    new CountryVisit(new DateTime(2013,12,10),Spain,"Holiday"),
                    new CountryVisit(new DateTime(2014,12,10),Spain,"Holiday"),
                    new CountryVisit(new DateTime(2015,12,10),Italy,"Try the gnocchi"),
                    new CountryVisit(new DateTime(2016,12,10),Tunisia,"Very nice"),
                    new CountryVisit(new DateTime(2017,12,10),Brazil,"Holiday"),
                    new CountryVisit(new DateTime(2018,12,10),UnitedKingdom,"Very very cold"),
                    new CountryVisit(new DateTime(2019,12,10),UnitedKingdom,"Very very cold again"),
                };
            }
        }



    }
}