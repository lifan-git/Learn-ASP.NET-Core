using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public static class SendData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>())) 
            {
                if (context.Movie.Any()) 
                {
                    return;
                }

                context.Movie.AddRange(new Movie()
                {
                    Title = "庆余年",
                    Genre="科幻武侠",
                    ReleaseDate =DateTime.Parse("2019/11/01"),
                    Price = 124,
                    Rating = "R"
                },
                new Movie()
                {
                    Title = "猫妖的诱惑",
                    Genre = "动漫",
                    ReleaseDate = DateTime.Parse("2019/02/01"),
                    Price = 66,
                    Rating = "S"
                });
                context.SaveChanges();
            }
        }
    }
}
