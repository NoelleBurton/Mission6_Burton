using Microsoft.EntityFrameworkCore;
using Mission6.Models;

namespace Mission6_Burton.Models
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base (options) 
        { 
        }

        public DbSet<AddFilm> AddFilms { get; set; }
    }
}
