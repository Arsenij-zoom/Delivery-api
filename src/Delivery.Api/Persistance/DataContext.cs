using Delivery.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Api.Persistance;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }
}
