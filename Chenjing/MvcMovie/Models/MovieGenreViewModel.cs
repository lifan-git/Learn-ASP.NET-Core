using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie.Views.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        /// <summary>
        /// 电影
        /// </summary>
        public List<Movie> Movies { get; set; }

        /// <summary>
        /// 种类
        /// </summary>
        public SelectList Genres { get; set; }

        /// <summary>
        /// 电影种类
        /// </summary>
        public string MovieGenre { get; set; }

        /// <summary>
        /// 搜索内容
        /// </summary>
        public string SearchString { get; set; }
    }
}
