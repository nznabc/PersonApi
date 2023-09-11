using Microsoft.EntityFrameworkCore;

namespace PersonApi.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(p =>
            {
                p.Property(c => c.Name).HasMaxLength(30).IsRequired();
                p.Property(c => c.Family).HasMaxLength(50).IsRequired();
            });
        }
    }
}
