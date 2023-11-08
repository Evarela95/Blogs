using Blogs.Application.Contracts.Contexts;
using Blogs.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Post> Posts { get; set; }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}
