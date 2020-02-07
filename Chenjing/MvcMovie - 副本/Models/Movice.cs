using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movice
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 有效日期
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// 电影类型
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// 票价
        /// </summary>
        public decimal Price { get; set; } 
    }
}
