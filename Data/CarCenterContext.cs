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

    }
}
