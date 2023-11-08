using Blogs.Application.Contracts.Contexts;
using Blogs.Application.Contracts.Repositories;
using Blogs.Domain.Entities;
using Blogs.Persistence.Contexts;
using Blogs.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Blogs.Web
{
    public static class Injection
    {
        public static IServiceCollection AddPresentation
            (this IServiceCollection services, IConfiguration configuration)
        {
           
            services.AddRepository<Author, IAuthorRepository, AuthorRepository>();
            services.AddRepository<Post, IPostRepository, PostRepository>();

            return services;
        }
    }
}