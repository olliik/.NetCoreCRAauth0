using Microsoft.EntityFrameworkCore;

namespace myapp.Models
{
    public class MyApiContext : DbContext
    {
        public MyApiContext(DbContextOptions<MyApiContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Organization> Organizations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);
        }        
    }
}