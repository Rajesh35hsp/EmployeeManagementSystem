using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Application
{
    public interface IAccountService
    {
        public Task<IdentityResult> CreateUserAsync(SignUpModel signUpModel);
    }
}