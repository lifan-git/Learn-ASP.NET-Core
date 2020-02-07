using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UrlGenerationController : Controller
    {
        [HttpGet("")]
        public IActionResult Source()
        {
            var url = Url.Action("Destination");
            return Content($"Go check out {url},it's really great.");
        }

        [HttpGet("custom/url/to/destinaton")]
        public string Destination()
        {
            return "Hello";
        }
    }
}