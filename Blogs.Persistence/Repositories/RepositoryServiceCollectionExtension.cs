using Blogs.Application.Contracts.Repositories;
using Blogs.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Blogs.Persistence.Repositories
{
    public static class RepositoryServiceCollectionExtension
    {
        public static IServiceCollection AddRepository<TEntity, TContract, TRepository>
            (this IServiceCollection services)
            where TEntity : Entity
            where TContract : class, IRepository<TEntity>
            where TRepository : class, TContract
        {
            services.AddScoped<TContract, TRepository>();
            return services;
        }
    }
}
