using Gestran.Forncecedor.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestran.Forncecedor.API.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Cep)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(e => e.Rua)
               .IsRequired()
               .HasColumnType("varchar(150)");

            builder.Property(e => e.Numero)
                    .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(e => e.Complemento)
                .HasColumnType("varchar(20)");

            builder.Property(e => e.Cidade)
                .HasColumnType("varchar(50)");

            builder.Property(e => e.Estado)
                .HasColumnType("varchar(50)");

            builder.Property(e => e.Pais)
               .HasColumnType("varchar(50)");
        }
    }
}