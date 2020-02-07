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
        [Required(AllowEmptyStrings = true, ErrorMessage = "不能为空，1~10个字符")]
        [StringLength(10, MinimumLength = 1)]
        public string Title { get; set; }

        /// <summary>
        /// 有效日期
        /// </summary>
        [DataType(DataType.Date)]
        [Display(Name = "有效日期")]
        [Required(AllowEmptyStrings = true, ErrorMessage = "不能为空")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// 电影类型
        /// </summary>
        [Display(Name = "电影类型")]
        [StringLength(10, MinimumLength = 0)]
        public string Genre { get; set; }

        /// <summary>
        /// 票价
        /// </summary>
        [Display(Name = "票价")]
        [Range(0, 500)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "不能为空，价格0~500￥")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        [Display(Name = "级别")]
        [RegularExpression("R|S")]
        public string Rating { get; set; }
    }
}
