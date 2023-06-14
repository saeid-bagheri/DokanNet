using App.Domain.Core.Entities;
using App.Domain.Core.Services.Admins.Commands;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Admins.Commands
{
    public class AddRoleToUser : IAddRoleToUser
    {
        private readonly UserManager<AppUser> _userManager;

        public AddRoleToUser(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task Execute(AppUser user, string role, CancellationToken cancellationToken)
        {
            await _userManager.AddToRoleAsync(user, role);
        }
    }
}
