// ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using Src.Models;

namespace ProductManagerAPI.Infra.Database;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
}
