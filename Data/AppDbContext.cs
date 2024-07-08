using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Models;

namespace EcommerceAPI.Data
{
    public class AppDbContext : DbContext
    {
        //costructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        // propriedade de cada tabela
        public DbSet<Client> Clients {get; set;}

        // nomeclatura correta da tabela
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("clients");
        }
    }
}