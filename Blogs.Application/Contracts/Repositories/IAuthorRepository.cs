using Blogs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.Contracts.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
    }
}
