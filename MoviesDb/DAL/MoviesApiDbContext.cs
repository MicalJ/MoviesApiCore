using System.Data.Entity;

namespace MoviesDb.DAL
{
    public class MoviesApiDbContext : DbContext
    {
        public MoviesApiDbContext() : base(@"Data Source=PREDATOR\SQLEXPRESS;Initial Catalog=MoviesDb;Integrated Security=True")
        { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
