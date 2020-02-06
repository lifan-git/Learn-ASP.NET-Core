using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    /// <summary>
    /// 电影流派
    /// </summary>
    public class MovieGenreViewModel
    {
        /// <summary>
        /// 电影列表
        /// </summary>
        public List<Movie> Movies { get; set; }

        /// <summary>
        /// 流派列表
        /// </summary>
        public SelectList Genres { get; set; }

        /// <summary>
        /// 所选流派
        /// </summary>
        public string MovieGenre { get; set; }

        /// <summary>
        /// 搜索文本
        /// </summary>
        public string SearchString { get; set; }
    }
}
