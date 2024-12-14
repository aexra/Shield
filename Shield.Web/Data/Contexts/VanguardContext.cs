using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vanguard.Web.Data.Models;

namespace Vanguard.Web.Data.Contexts;

public class IdentityContext : IdentityDbContext<User>
{
    public IdentityContext()
    {
        
    }

    protected override async void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql($"Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234;Include Error Detail=True");
    }
}
