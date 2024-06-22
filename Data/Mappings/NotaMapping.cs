using CarCenter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCenter.Data.Mappings
{
    public class NotaMapping : IEntityTypeConfiguration<Nota>
    {
        public void Configure(EntityTypeBuilder<Nota> builder)
        {
            builder
                .ToTable("Nota")
                .HasKey(n => n.Id);

            builder
                .Property(n => n.Numero)
                .IsRequired()
                .HasColumnType("INT");

            builder
                .Property(n => n.DataEmissao)
                .HasColumnType("DATETIME")
                .HasColumnName("Data_Emissao")
                .HasDefaultValue(DateTime.Now);

            builder
                .Property(n => n.Garantia)
                .HasColumnType("DATETIME")
                .HasDefaultValue(DateTime.Now.AddYears(2)); // Definido 2 anos de garantia

            builder
                .Property(n => n.ValorVenda)
                .IsRequired()
                .HasColumnType("FLOAT")
                .HasColumnName("Valor_Venda");
        }
    }
}
