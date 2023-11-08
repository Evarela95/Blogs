using Blogs.Application.Components;
using Blogs.Application.Contracts.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) 
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        public async Task<Result> Register(string alias)
        {
            var user = new IdentityUser (alias);
            var result = await _userManager.CreateAsync (user);

            if (!result.Succeeded)
            {
                StringBuilder builder= new StringBuilder ();
                foreach(var error in result.Errors)
                {
                    builder.AppendLine(error.Description);
                }

                return Result.Fail(builder.ToString());
            }
            return Result.Ok();
        }


        public async Task<Result> Login(string alias)
        {
            var result=await _signInManager.PasswordSignInAsync
                (alias, null, isPersistent: false, lockoutOnFailure:false);

            if (!result.Succeeded)
            {
                return Result.Fail("Invalid login");
            }

            return Result.Ok();

        }

        public async Task<Result> Logout(string alias)
        {
            await _signInManager.SignOutAsync();
            return Result.Ok();
        }

        
    }
}
