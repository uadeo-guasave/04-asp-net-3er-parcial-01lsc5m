using Microsoft.EntityFrameworkCore;
using mywebapi.Models;

namespace mywebapi.DbContexts
{
    public class SqliteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Db/myblog.db");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(user =>
            {
                user.HasIndex(u => u.Name).IsUnique();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}