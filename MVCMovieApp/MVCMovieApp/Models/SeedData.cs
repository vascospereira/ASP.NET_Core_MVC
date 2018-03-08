using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MVCMovieApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCMovieAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<MVCMovieAppContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }
                
                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "When Harry Met Sally",
                         ReleaseTime = DateTime.Parse("1989-1-11"),
                         Genre = "Romantic Comedy",
                         Price = 7.99M,
                         Rating = "AAA"
                     },

                     new Movie
                     {
                         Title = "Ghostbusters ",
                         ReleaseTime = DateTime.Parse("1984-3-13"),
                         Genre = "Comedy",
                         Price = 8.99M,
                         Rating = "BB"
                     },

                     new Movie
                     {
                         Title = "Ghostbusters 2",
                         ReleaseTime = DateTime.Parse("1986-2-23"),
                         Genre = "Comedy",
                         Price = 9.99M,
                         Rating = "CCC"
                     },

                   new Movie
                   {
                       Title = "Rio Bravo",
                       ReleaseTime = DateTime.Parse("1959-4-15"),
                       Genre = "Western",
                       Price = 3.99M,
                       Rating = "C"
                   }
                );
                context.SaveChanges();
            }
        }
    }
}