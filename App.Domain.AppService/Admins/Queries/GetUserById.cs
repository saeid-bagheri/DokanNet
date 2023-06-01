using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Admins.Queries
{
    public class GetUserById : IGetUserById
    {
        private readonly IUserRepository _userRepository;

        public GetUserById(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto> Execute(int id, CancellationToken cancellationToken)
        {
            return await _userRepository.GetById(id, cancellationToken);
        }
    }
}
