using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // 如果 DB 中有任何电影，则会返回种子初始值设定项，并且不会添加任何电影。
                if (context.Movie.Any())
                {
                    return;
                }

                // 设定数据
                context.Movie.Add(new Movie() { Title = "When Harry Met Sally", ReleaseDate = DateTime.Parse("1989-2-12"), Genre = "Romantic Comedy", Price = 7.99M, Rating = "R" });
                context.Movie.Add(new Movie() { Title = "Ghostbusters", ReleaseDate = DateTime.Parse("1984-3-13"), Genre = "Comedy", Price = 8.99M, Rating = "R" });
                context.Movie.Add(new Movie() { Title = "Ghostbusters 2", ReleaseDate = DateTime.Parse("1986-2-23"), Genre = "Comedy", Price = 9.99M, Rating = "R" });
                context.Movie.Add(new Movie() { Title = "Rio Bravo", ReleaseDate = DateTime.Parse("1959-4-15"), Genre = "Western", Price = 3.99M, Rating = "R" });
                context.SaveChanges();
            }
        }
    }
}
