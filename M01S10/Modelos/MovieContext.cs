using Microsoft.EntityFrameworkCore;

namespace M01S10.Modelos
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) 
        { 
        }

        DbSet<Movie> Movies { get; set; } = null;
    }
}
