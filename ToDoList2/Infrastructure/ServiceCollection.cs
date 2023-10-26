using Microsoft.EntityFrameworkCore;
using ToDoList2.Infrastructure.Contexts;

namespace ToDoList2.Infrastructure
{
    public static class ServiceCollection
    {
        public static void AddApplicationPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
        }
    }
}
