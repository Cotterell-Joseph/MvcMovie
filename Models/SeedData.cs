using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;  // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Carthage",
                        ReleaseDate = DateTime.Parse("2017-9-29"),
                        Genre = "Drama",
                        Price = 11.99M,
                        Rating = "NR",
                        Poster = "carthage.jpg"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-6-3"),
                        Genre = "Adventure",
                        Price = 14.99M,
                        Rating = "PG",
                        Poster = "miracle.jpg"
                    },

                    new Movie
                    {
                        Title = "Mountain of the Lord",
                        ReleaseDate = DateTime.Parse("1993-4-1"),
                        Genre = "Drama",
                        Price = 8.99M,
                        Rating = "NR",
                        Poster = "mountain.jpg"
                    },

                    new Movie
                    {
                        Title = "The Fighting Preacher",
                        ReleaseDate = DateTime.Parse("2019-7-24"),
                        Genre = "Comedy",
                        Price = 19.99M,
                        Rating = "PG",
                        Poster = "preacher.png"
                    },

                    new Movie
                    {
                        Title = "Saints and Soldiers: Airborne Creed",
                        ReleaseDate = DateTime.Parse("2012-8-17"),
                        Genre = "Action",
                        Price = 4.99M,
                        Rating = "PG-13",
                        Poster = "saints.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
