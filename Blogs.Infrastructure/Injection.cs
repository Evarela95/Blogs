using Blogs.Application.Contracts;
using Blogs.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Blogs.Application.Contracts.Contexts;
using Blogs.Application.Contracts.Repositories;
using Blogs.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Blogs.Infrastructure.Contexts;
using Microsoft.AspNetCore.Identity;
using Blogs.Application.Contracts.Identity;
using Blogs.Infrastructure.Services;

namespace Blogs.Infrastructure
{
    public static class Injection
    {
        public static IServiceCollection AddInfrastructure
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationIdentityDbContext>
                (options =>
                {
                    options.UseSqlServer(configuration.GetConnectionString("Default"));

                });
            
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationIdentityDbContext> ();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
                options.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
                options.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ApplicationScheme;
            });


            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IPostService, PostService>();

            return services;
        }
    }
}