﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {

        public int Id { set; get; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { set; get; }

        [Display(Name = "Release Date"),DataType(DataType.Date)]
        public DateTime ReleaseDate { set; get; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"),Required,StringLength(30)]
        public string Genre { set; get; }

        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { set; get; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        public string Rating { set; get; }
    }
}
