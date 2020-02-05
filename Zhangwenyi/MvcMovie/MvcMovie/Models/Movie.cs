using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { set; get; }
        public string Title { set; get; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { set; get; }
        public string Genre { set; get; }
        public decimal Price { set; get; }
    }
}
