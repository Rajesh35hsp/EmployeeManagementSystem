using Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpModel user);
    }
}
