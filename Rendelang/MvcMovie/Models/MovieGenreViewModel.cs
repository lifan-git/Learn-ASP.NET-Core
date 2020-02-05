using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        /// <summary>
        /// 电影列表
        /// </summary>
        public List<Movie> Movies { get; set; }
        /// <summary>
        /// 包含流派列表的 SelectList。 这使用户能够从列表中选择一种流派。
        /// </summary>
        public SelectList Genres { get; set; }
        /// <summary>
        /// 包含所选流派的 MovieGenre。
        /// </summary>
        public string MovieGenre { get; set; }
        /// <summary>
        /// SearchString包含用户在搜索文本框中输入的文本。
        /// </summary>
        public string SearchString { get; set; }

    }
}
