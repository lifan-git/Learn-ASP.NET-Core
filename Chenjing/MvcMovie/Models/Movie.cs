using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        /// <summary>
        /// Id
        /// </summary>
        [Display(Name = "Id")]
        public int Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [Display(Name = "电影名称")]
        public string Title { get; set; }

        /// <summary>
        /// 有效日期
        /// </summary>
        [DataType(DataType.Date)]
        [Display(Name = "有效日期")]
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// 电影类型
        /// </summary>
        [Display(Name = "电影类型")]
        public string Genre { get; set; }

        /// <summary>
        /// 票价
        /// </summary>
        [Display(Name = "票价")]
        public decimal Price { get; set; } 
    }
}
