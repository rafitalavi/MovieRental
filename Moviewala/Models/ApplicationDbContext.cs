using Microsoft.EntityFrameworkCore;

namespace Moviewala.Models
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor accepting DbContextOptions and passing to base class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Define DbSets for your entities
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }

        // Add other DbSets as needed (e.g., for other entities)
    }
}
