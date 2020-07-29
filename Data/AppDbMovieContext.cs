using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class AppDbMovieContext : DbContext
    {
        public AppDbMovieContext (DbContextOptions<AppDbMovieContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Movie> Movie { get; set; }
    }
}
