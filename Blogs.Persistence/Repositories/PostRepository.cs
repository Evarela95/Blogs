using Blogs.Application.Contracts.Repositories;
using Blogs.Domain.Entities;
using Blogs.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Persistence.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(ApplicationDbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
