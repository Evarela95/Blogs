using Blogs.Application.Contracts.Repositories;
using Blogs.Domain.Entities;
using Blogs.Persistence.Contexts;
using Blogs.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Persistence.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
