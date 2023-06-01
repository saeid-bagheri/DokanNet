using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Admins.Commands
{
    public class UpdateUser : IUpdateUser
    {
        private readonly IUserRepository _userRepository;

        public UpdateUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Execute(UserDto entity, CancellationToken cancellationToken)
        {
            await _userRepository.Update(entity, cancellationToken);
        }
    }
}
