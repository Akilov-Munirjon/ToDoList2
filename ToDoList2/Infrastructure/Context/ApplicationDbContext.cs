using Microsoft.EntityFrameworkCore;
using System.Reflection;
using ToDoList2.Domain.Entities;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Phone> Phones { get; set; }
        public DbSet<Battery> Batteries { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<CameraType> CameraTypes { get; set; }
        public DbSet<Connector> Connectors { get; set; }
        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<Display> Displays { get; set; }
        public DbSet<DisplayQuality> DisplayQualityes { get; set; }
        public DbSet<Os> Os { get; set; }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<SimType> SimTypes { get; set; }
        public DbSet<OperatingSystem> OperatingSystems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}