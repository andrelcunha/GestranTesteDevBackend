using Gestran.Forncecedor.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestran.Forncecedor.API.Data;

#pragma warning disable CS1591
public class FornecedorContext: DbContext
{
    public FornecedorContext(DbContextOptions<FornecedorContext> options)
    : base(options)
    {
    }

    public DbSet<Fornecedor> Fornecedor { get; set; } = null!;

}