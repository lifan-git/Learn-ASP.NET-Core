using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// 路由学习
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class MyDemoController : Controller
    {
        [HttpGet]
        public string MyIndex()
        {
            return "Index";
        }

        [HttpGet]
        public string MyAbout()
        {
            return "About";
        }

        [HttpGet]
        public string MyContact()
        {
            return "Contact";
        }

        [HttpGet("{id?}", Name = "Products_List")]
        public string ListProducts(int? id)
        {
            return "ListProducts:" + id;
        }
    }
}