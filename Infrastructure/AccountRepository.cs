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

        public AccountRepository(UserManager<IdentityUser> userManager)
        {
            this._userManager = userManager;
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
    }
}
