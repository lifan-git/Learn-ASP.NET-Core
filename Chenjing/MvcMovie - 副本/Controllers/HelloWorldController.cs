using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 欢迎
        /// </summary>
        /// <returns></returns>
        public IActionResult WelCome(string name, int id = 1)
        {
            ViewData["Message"] = $"Hello {name},your id is:{id}";
            ViewData["ID"] = id;
            return View();
            //return HtmlEncoder.Default.Encode($"Hello {name},id is: {id}");
        }
    }
}
