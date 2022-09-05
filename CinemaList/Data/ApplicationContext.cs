using CinemaList.Models.Series;
using CinemaList.Models.Movie;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CinemaList.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CinemaListDB;Trusted_Connection=True;");
        }
    }
}
