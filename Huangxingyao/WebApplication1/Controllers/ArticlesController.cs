using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ArticlesController : Controller
    {
        public IActionResult Read()
        {
            List<ArticleSection> list = new List<ArticleSection>();
            list.Add(new ArticleSection { Title = "第一节索引", Content = "八十七年前..." });
            list.Add(new ArticleSection { Title = "第二节索引", Content = "我们正在进行一场伟大的内战，考验着......" });
            list.Add(new ArticleSection { Title = "第三节索引", Content = "然而，从更广泛的意义上说，我们无法奉献..." });

            Article article = new Article()
            {
                Title = "Abraham ",
                AuthorName = "Lincoln",
                PublicationDate = DateTime.Parse("1863-11-19 12:00:00"),
                Sections = list
            };
            return View("/Views/Articles/Read.cshtml", article);
        }
    }
}