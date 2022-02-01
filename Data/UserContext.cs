using Microsoft.EntityFrameworkCore;
using DAW_Blog_BE.Models;

namespace DAW_Blog_BE.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public DbSet<User> Users { set; get; }
        public DbSet<Article> Articles { set; get; }
        public DbSet<Category> Categories { set; get; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });
        }
    }
}