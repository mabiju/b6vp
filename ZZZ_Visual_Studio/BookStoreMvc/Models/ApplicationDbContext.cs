using Microsoft.EntityFrameworkCore;

namespace BookStoreMvc.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } // Represents the Books table
    }
}
