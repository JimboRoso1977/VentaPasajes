
using Microsoft.EntityFrameworkCore;
using VentaPasajes.Shared.Entities;
using static Microsoft.Extensions.Configuration.IConfiguration;

namespace VentaPasajes.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cooperativa> Cooperativas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().HasIndex(x => x.Nombre_Cliente).IsUnique();
            modelBuilder.Entity<Cooperativa>();
        }

      
    }
}
