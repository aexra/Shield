using Shield.Web.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Shield.Web.Data.Contexts;

public class IdentityContext : IdentityDbContext<User>
{
    public static List<IdentityRole> AppRoles = [];
    public string DbPath { get; }

    public IdentityContext()
    {
        DbPath = "Data/Databases/Identity.db";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={DbPath}");
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().HasData(AppRoles);
    }
}
