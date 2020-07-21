using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace SSRSMVCDataService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchesController : ControllerBase
    {
        private IWebHostEnvironment m_WebHostEnvironment;

        private Color[] BatchColours => new Color[] 
        {
            Color.Aquamarine,
            Color.IndianRed,
            Color.OrangeRed,
            Color.MediumPurple,
            Color.DeepPink,
            Color.LightSeaGreen
        };

        public BatchesController(IWebHostEnvironment webHostEnvironment)
        {
            m_WebHostEnvironment = webHostEnvironment;
        }

        public ActionResult Image(string numberOfBatches = "4")
        
        {
            //using (var reader = new StreamReader(Request.Body))
            //{
            //    var body = reader.ReadToEnd();

            //    // Do something
            //}

            //var dir = $"{m_WebHostEnvironment.ContentRootPath }\\Images";
            //var path = Path.Combine(dir, "SampleBatchBar.png"); //validate the path for security or use other means to generate the path.

            //return PhysicalFile(path, "image/png");

            var batchesImage = GetBatchesBitmap(Convert.ToInt32(numberOfBatches));
            return File(ImageToByteArray(batchesImage), "image/png");
        }

        private Bitmap GetBatchesBitmap(int numberOfBatches)
        {
            var totalLength = 100;
            var ran = new Random();
            var allBatches = Enumerable.Range(1, numberOfBatches - 1).Select(index =>
             {
                 return new Batch(ran.Next(10, 20),
                      BatchColours[ran.Next(0, BatchColours.Length - 1)]);
             }).ToList();
            allBatches.Add(new Batch(totalLength - allBatches.Sum(b => b.Length), BatchColours[ran.Next(0, BatchColours.Length - 1)]));

            var image = new Bitmap(500, 100);
            using(var g = Graphics.FromImage(image))
            {
                foreach(var batch in allBatches)
                {
                    g.FillRectangle(new SolidBrush(batch.Colour),allBatches.TakeWhile(b => !(b == batch)).Sum(previousBatch => previousBatch.Length * 5),0,batch.Length * 5,100);
                }
            }

            return image;
        }
        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        private class Batch
        {
            public int Length { get; }
            public Color Colour { get; }

            public Batch(int length, Color colour)
            {
                Length = length;
                Colour = colour;
            }
        }

    }
}
