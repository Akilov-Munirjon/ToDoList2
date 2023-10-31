using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.Infrastructure.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Battery> Batteries { get; set; }
}

