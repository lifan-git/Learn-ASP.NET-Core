using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string Title { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            Title = "About Us";
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            var viewModel = new Address()
            {
                Name = "Microsoft",
                Street = "One Microsoft Way",
                City = "Redmond",
                State = "WA",
                PostalCode = "98052-6399"
            };

            return View(viewModel);
        }

        public IActionResult SomeAction()
        {
            ViewBag.Greeting = "Hello";
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
