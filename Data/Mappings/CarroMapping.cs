using CarCenter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCenter.Data.Mappings
{
    public class CarroMapping : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder
                .ToTable("Carro")
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Marca)
                .IsRequired()
                .HasColumnType("VARCHAR");

            builder
                .Property(c => c.Modelo)
                .IsRequired()
                .HasColumnType("VARCHAR");

            builder
                .Property(c => c.AnoModelo)
                .IsRequired()
                .HasColumnType("SMALLINT")
                .HasColumnName("Ano_Modelo");

            builder
                .Property(c => c.AnoFabricacao)
                .IsRequired()
                .HasColumnType("SMALLINT")
                .HasColumnName("Ano_Fabricação");

            builder
                .Property(c => c.Chassi)
                .IsRequired()
                .HasColumnType("VARCHAR");

            builder
                .Property(c => c.Preco)
                .IsRequired()
                .HasColumnType("FLOAT");
        }
    }
}
