using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MvcMovie.Views.Movies
{
    public class IndexModel : PageModel
    {
        public string SessionName { get; set; }

        public IndexModel()
        {
            OnGet();
        }

        public void OnGet()
        {
            SessionName = "³Â¾²";
            HttpContext.Session.SetString("name", SessionName);
            string value = HttpContext.Session.GetString("name");
            Console.WriteLine(value);
        }
    }
}
