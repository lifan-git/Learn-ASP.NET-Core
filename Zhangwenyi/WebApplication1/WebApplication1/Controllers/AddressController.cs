using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("[controller]/[action]")]
    public class AddressController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            ViewData["Greeting"] = "Hello";
            ViewBag.Address = new Address()
            {
                Name = "Steve",
                Street = "123 Main St",
                City = "Hudson",
                State = "OH",
                PostalCode = "44236"
            };

            return View();
        }

        [HttpGet("{id}")]
        public IActionResult About(string id) {
            ViewData["Name"] = id; ;
            return View();
        }
    }
}
