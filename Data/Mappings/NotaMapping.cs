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
                .IsRequired(false)
                .HasColumnType("DATETIME")
                .HasColumnName("Data_Emissao")
                .HasDefaultValueSql("GETDATE()");

            builder
                .Property(n => n.Garantia)
                .IsRequired(false)
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("DATEADD(YEAR, 2, GETDATE())"); // Definido 2 anos de garantia

            builder
                .Property(n => n.ValorVenda)
                .IsRequired()
                .HasColumnType("FLOAT")
                .HasColumnName("Valor_Venda");

            builder
                .HasIndex(n => n.Numero, "IX_Nota_Numero")
                .IsUnique();
        }
    }
}
