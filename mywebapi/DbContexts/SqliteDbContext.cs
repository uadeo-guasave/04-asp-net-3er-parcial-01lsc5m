using Microsoft.EntityFrameworkCore;
using mywebapi.Models;

namespace mywebapi.DbContexts
{
    public class SqliteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Domicilio> Domcilios { get; set; }
        public DbSet<Recibo> Recibos { get; set; }

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

            modelBuilder.Entity<Cliente>(cliente => 
            {
                cliente.HasKey(c => c.Cuenta);
                cliente.HasOne(c => c.Domicilio).WithOne(d => d.Cliente);
                cliente.HasMany(c => c.Recibos).WithOne(r => r.Cliente);
            });

            modelBuilder.Entity<Domicilio>(dom => 
            {
                dom.HasOne(d => d.Cliente).WithOne(c => c.Domicilio);
            });

            modelBuilder.Entity<Recibo>(recibo => 
            {
                recibo.HasOne(r => r.Cliente).WithMany(c => c.Recibos);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}