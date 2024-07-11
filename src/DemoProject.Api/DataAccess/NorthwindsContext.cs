using DemoProject.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Api.DataAccess;

public class NorthwindsContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Category> Categories => Set<Category>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(x =>
        {
            x.ToTable("Categories");
            x.HasKey(c => c.Id);
            x.Property(c => c.Id).HasColumnName("CategoryID");
        });
    }
}