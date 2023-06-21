using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Admins.Commands
{
    public class LoginUser : ILoginUser
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginUser(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<SignInResult> Execute(UserDto entity, CancellationToken cancellationToken)
        {
            return await _signInManager.PasswordSignInAsync(entity.UserName, entity.Password, true, false);
        }
    }
}
