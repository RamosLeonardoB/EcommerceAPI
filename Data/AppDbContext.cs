using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Models;

namespace EcommerceAPI.Data
{
    public class AppDbContext : DbContext
    {
        // constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        // propriedades de cada tabela
        public DbSet<Client>  Clients  { get; set; }
        public DbSet<Seller>  Sellers  { get; set; }
        public DbSet<Product> Products { get; set; }
        // nomenclatura correta da tabela
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("clients");
            modelBuilder.Entity<Seller>().ToTable("sellers");
            modelBuilder.Entity<Product>().ToTable("products");
        }
    }
}