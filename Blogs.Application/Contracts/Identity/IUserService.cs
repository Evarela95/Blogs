using Blogs.Application.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.Contracts.Identity
{
    public interface IUserService
    {
        Task<Result> Register(string alias);

        Task<Result> Login(string alias);


        Task<Result> Logout(string alias);
    }
}
