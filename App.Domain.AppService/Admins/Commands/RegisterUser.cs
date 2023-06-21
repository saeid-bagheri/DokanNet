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
    public class RegisterUser : IRegisterUser
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterUser(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IdentityResult> Execute(UserDto entity, CancellationToken cancellationToken)
        {
            var user = new AppUser()
            {
                UserName = entity.UserName,
                CreatedAt = DateTime.Now,
                Buyer = new Buyer()
                {
                    CreatedAt = DateTime.Now,
                    IsDeleted = false
                }
            };
            var result = await _userManager.CreateAsync(user, entity.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "BuyerRole");
            }
            return result;
        }
    }
}
