using Mercadinho.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Mercadinho.API.Context;

public class SQLServerContext : DbContext
{
    public SQLServerContext() { }

    public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options) { }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}