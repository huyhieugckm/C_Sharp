using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cinema>()
            .HasNoKey();
    }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
    }
}