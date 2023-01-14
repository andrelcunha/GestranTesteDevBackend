using Gestran.Forncecedor.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestran.Forncecedor.API.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(e => e.Cnpj)
                    .IsRequired()
                .HasColumnType("varchar(18)");

            builder.Property(e => e.Telefone)
                .HasColumnType("varchar(18)");

            builder.Property(e => e.Email)
                .HasColumnType("varchar(100)");

            builder.HasMany(e => e.Enderecos).WithOne(e => e.Fornecedor);

        }
    }
}