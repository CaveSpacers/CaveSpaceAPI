using Microsoft.EntityFrameworkCore;

namespace CaveSpaceAPI;

public class ApplicationContext : DbContext
{
    public ApplicationContext() => Database.EnsureCreated();
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=postgres;Port=5432;Database=postgres;Username=postgres;Password=postgres");
    }
}