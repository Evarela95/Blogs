using Blogs.Application.Contracts;
using Blogs.Application.Diagnostics;
using Blogs.Application.Services;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blogs.Application
{
    public static class Injection
    {
        public static IServiceCollection AddApplication
            (this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(Injection).Assembly;
            services.AddMediatR(options => options.RegisterServicesFromAssemblies(assembly));
            services.AddValidatorsFromAssembly(assembly);

            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IPostService, PostService>();

            return services;
        }
    }
}
