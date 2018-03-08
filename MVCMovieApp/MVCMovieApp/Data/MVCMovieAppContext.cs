using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCMovieApp.Models
{
    public class MVCMovieAppContext : DbContext
    {
        public MVCMovieAppContext (DbContextOptions<MVCMovieAppContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMovieApp.Models.Movie> Movie { get; set; }
    }
}
