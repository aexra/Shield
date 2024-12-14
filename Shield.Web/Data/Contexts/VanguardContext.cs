using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using User = Vanguard.Web.Data.Models.User;

namespace Vanguard.Web.Data.Contexts;

public class VanguardContext : IdentityDbContext<User>
{
    public VanguardContext()
    {
        
    }

    protected override async void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql($"Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234;Include Error Detail=True");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
