using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Annie Hall",
                        ReleaseDate = DateTime.Parse("1982-2-28"),
                        Genre = "Romantic",
                        Price = 20.000M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Espartaco",
                        ReleaseDate = DateTime.Parse("1960-6-17"),
                        Genre = "Action",
                        Price = 60.000M,
                        Rating = "E"
                    },
                    new Movie
                    {
                        Title = "Irreversible",
                        ReleaseDate = DateTime.Parse("2002-9-18"),
                        Genre = "No Fiction",
                        Price = 20.000M,
                        Rating = "E"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
