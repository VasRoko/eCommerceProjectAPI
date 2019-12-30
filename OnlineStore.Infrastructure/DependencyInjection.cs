using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Application.Interfaces;

namespace OnlineStore.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistanceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OS_ProductsDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IOS_ProducsDbContext>(provider => provider.GetService<OS_ProductsDbContext>());

            return services; 
        }
    }
}
