using System.Reflection;
using Boilerplate.Domain.Interfaces;
using Boilerplate.Infrastructure.Persistence;
using Boilerplate.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Boilerplate.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEfCoreIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<EfCoreApplicationDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddEfCoreRegisterRepositories();

            return services;
        }

        public static IServiceCollection AddEfCoreRegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(EfRepositoryBase<>));
            
            return services;
        }
    }
}