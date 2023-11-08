using Blogs.Application.Contracts.Contexts;
using Blogs.Application.Contracts.Repositories;
using Blogs.Domain.Entities;
using Blogs.Persistence.Contexts;
using Blogs.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blogs.Persistence
{
    public static class Injection
    {
        public static IServiceCollection AddPersistence
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IApplicationDbContext>
                (options => options.GetService<ApplicationDbContext>());

            services.AddRepository<Author, IAuthorRepository, AuthorRepository>();
            services.AddRepository<Post, IPostRepository, PostRepository>();

            return services;
        }
    }
}
