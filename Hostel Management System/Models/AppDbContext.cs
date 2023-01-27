using Microsoft.EntityFrameworkCore;

namespace Hostel_Management_System.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<User>Users { get; set; }
        public DbSet<LookUpCollection>lookUpCollections { get; set; }
        public DbSet<LookUpCollectionValues>lookUpCollectionValues { get; set; }

    }
}
