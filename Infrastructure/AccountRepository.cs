using Application;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    internal class AccountRepository : IAccountRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;

        public AccountRepository(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._signinManager = signInManager;
        }

        public async Task<IdentityResult> CreateUserAsync(SignUpModel user)
        {
            var s = new IdentityUser
            {
                UserName = user.Email,
                Email = user.Email
            };
            return await _userManager.CreateAsync(s, user.Password);
        }

        public async Task<string> LoginAsync(SignInModel user)
        {
            var result = await _signinManager.PasswordSignInAsync(user.Email, user.Password, false, false);
            if (!result.Succeeded)
            {
                return "Login Failed";
            }
            return "Login Successful";

        }
    }
}
