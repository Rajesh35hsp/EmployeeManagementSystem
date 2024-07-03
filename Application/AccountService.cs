using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            this._accountRepository = accountRepository;
                
        }
        public async Task<IdentityResult> CreateUserAsync(SignUpModel signUpModel)
        {
            return await _accountRepository.CreateUserAsync(signUpModel);

        }
    }
}
