using Gestran.Forncecedor.API.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Gestran.Forncecedor.API.Data
{
    public class ContextoPrincipal : DbContext
    {
        public ContextoPrincipal(DbContextOptions<ContextoPrincipal> options)
        : base(options) { }

        public DbSet<Fornecedor> Fornecedor { get; set; } = null!;
        public DbSet<Endereco> Endereco { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType(value: "varchar(100)");

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContextoPrincipal).Assembly);
        }
    }
}