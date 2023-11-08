using Blogs.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.Contracts.Contexts
{
    public interface IApplicationDbContext
    {
        DbSet<Author> Authors { get; set; }

        DbSet<Post> Posts { get; set; }

        void Save();
    }
}
