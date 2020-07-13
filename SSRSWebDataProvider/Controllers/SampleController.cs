using SSRSWebDataProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SSRSWebDataProvider.Controllers
{
    public class SampleController : ApiController
    {
        public IEnumerable<TestModel> Get()
        {
            return new List<TestModel>()
            {
                new TestModel(){ID = 1, Name = "Test1", Description="Test Description 1"},
                new TestModel(){ID = 2, Name = "Test2", Description="Test Description 2"},
                new TestModel(){ID = 3, Name = "Test3", Description="Test Description 3"},
                new TestModel(){ID = 4, Name = "Test4", Description="Test Description 4"},
                new TestModel(){ID = 5, Name = "Test5", Description="Test Description 5"},
                new TestModel(){ID = 6, Name = "Test6", Description="Test Description 6"},
                new TestModel(){ID = 7, Name = "Test7", Description="Test Description 7"},
                new TestModel(){ID = 8, Name = "Test8", Description="Test Description 8"},
                new TestModel(){ID = 9, Name = "Test9", Description="Test Description 9"},
                new TestModel(){ID = 10, Name = "Test10", Description="Test Description 10"},
                new TestModel(){ID = 11, Name = "Test11", Description="Test Description 11"},
                new TestModel(){ID = 12, Name = "Test12", Description="Test Description 12"},
                new TestModel(){ID = 13, Name = "Test13", Description="Test Description 13"}
            };
        }
    }
}
