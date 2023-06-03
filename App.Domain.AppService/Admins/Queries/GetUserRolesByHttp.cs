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
    public class GetUserRolesByHttp : IGetUserRolesByHttp
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContext;


        public GetUserRolesByHttp(UserManager<AppUser> userManager, IHttpContextAccessor httpContext)
        {
            _userManager = userManager;
            _httpContext = httpContext;
        }

        public async Task<List<string>> Execute(CancellationToken cancellationToken)
        {
            var result = await _userManager.GetRolesAsync(await _userManager.FindByEmailAsync(_httpContext.HttpContext.User.Identity!.Name));
            return result.ToList();
        }
    }
}
