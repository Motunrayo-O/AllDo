using AllDo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AllDo.Infrastructure.Data;

public class AllDoDbContext : DbContext
{
    public DbSet<TodoTask> TodoTasks { get; set; }
    public DbSet<Bug> Bugs { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=AllDo.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        SeedData.Seed(modelBuilder);
    }

    public static void EnsureCreated()
    {
        using (var context = new AllDoDbContext())
        {
            context.Database.EnsureCreated();
        }
    }
}