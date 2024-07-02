using Microsoft.EntityFrameworkCore;
using Shield.Web.Data.Models;

namespace Shield.Web.Data.Contexts;

public class DataContext : DbContext
{
    public DbSet<Contract> Contracts { get; set; }

    public string DbPath { get; }

    public DataContext()
    {
        DbPath = "Data/Databases/Data.db";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={DbPath}");
}
