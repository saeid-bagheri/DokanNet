using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Admins.Commands
{
    public class DeleteUser : IDeleteUser
    {
        private readonly IUserRepository _userRepository;

        public DeleteUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Execute(int userId, CancellationToken cancellationToken)
        {
            await _userRepository.Delete(userId, cancellationToken);
        }
    }
}
