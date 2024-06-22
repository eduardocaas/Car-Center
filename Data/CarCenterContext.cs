using CarCenter.Data.Mappings;
using CarCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace CarCenter.Data
{
    public class CarCenterContext : DbContext
    {
        public CarCenterContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Carro> Carros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost, 1433;
                                    Trusted_Connection=True;
                                    TrustServerCertificate=True;
                                    Database=CarCenter;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarroMapping());
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new NotaMapping());
            modelBuilder.ApplyConfiguration(new VendedorMapping());
        }
    }
}
