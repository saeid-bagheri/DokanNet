using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DataAccess;
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
    public class GetUserRolesByUserName : IGetUserRolesByUserName
    {
        private readonly IUserRepository _userRepository;

        public GetUserRolesByUserName(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<string>> Execute(string userName, CancellationToken cancellationToken)
        {
            return await _userRepository.GetRolesByUserName(userName, cancellationToken);
        }
    }
}