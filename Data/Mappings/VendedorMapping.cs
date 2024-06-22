using CarCenter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCenter.Data.Mappings
{
    public class VendedorMapping : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder
                .ToTable("Vendedor")
                .HasKey(v => v.Id);

            builder
                .Property(v => v.Nome)
                .IsRequired()
                .HasColumnType("VARCHAR");

            builder
                .Property(v => v.DataAdmissao)
                .IsRequired()
                .HasColumnType("DATETIME")
                .HasColumnName("Data_Admissao")
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(v => v.Matricula)
                .IsRequired()
                .HasColumnType("VARCHAR");

            builder
                .Property(v => v.Salario)
                .IsRequired()
                .HasColumnType("FLOAT");
        }
    }
}
