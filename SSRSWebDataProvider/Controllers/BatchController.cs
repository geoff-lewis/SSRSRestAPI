using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SSRSWebDataProvider.Controllers
{
    public class BatchController : ApiController
    {
        public ActionResult BatchBar()
        {
            throw new NotImplementedException();
            //code not working taken from a suggested answer

            //var dir = Server.MapPath("/Images");
            //var path = Path.Combine(dir, "SampleBatchBar.png");
            //return base.File(path, "image/jpeg");
        }
    }
}
