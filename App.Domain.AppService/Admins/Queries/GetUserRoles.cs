using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Admins.Queries
{
    public class GetUserRoles : IGetUserRoles
    {
        private readonly UserManager<AppUser> _userManager;

        public GetUserRoles(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<List<string>> Execute(string userName, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user is not null)
            {
                var roles = await _userManager.GetRolesAsync(user);
                return roles.ToList();
            }
            return new List<string>();
        }
    }
}