using FilmDB2.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmDB2.Data
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options)
            : base(options)
        {
        }

        public DbSet<FilmModel> FilmModels { get; set; }
    }
}
