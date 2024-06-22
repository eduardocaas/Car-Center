using CarCenter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCenter.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
                .ToTable("Cliente")
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);

            builder
                .Property(c => c.DataNascimento)
                .IsRequired()
                .HasColumnType("DATETIME")
                .HasColumnName("Data_Nascimento");

            builder
                .Property(c => c.Email)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);

            builder
                .Property(c => c.Telefone)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(11);

            builder
                .Property(c => c.Endereco)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(200);

            builder
                .Property(c => c.CPF)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(11);

            builder
                .HasIndex(c => c.Email, "IX_Cliente_Email")
                .IsUnique();
        }
    }
}
