using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    /// <summary>
    /// 文章
    /// </summary>
    public class Article
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// 出书日期
        /// </summary>
        public DateTime PublicationDate { get; set; }

        /// <summary>
        /// 章节
        /// </summary>
        public List<ArticleSection> Sections { get; set; }
    }
}
