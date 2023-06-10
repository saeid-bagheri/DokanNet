using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DataAccess
{
    public interface IUserRepository
    {
        Task<UserDto> GetById(int id, CancellationToken cancellationToken);
        Task<List<UserDto>> GetAll(CancellationToken cancellationToken);
        Task<List<string>> GetRolesByUserName(string userName, CancellationToken cancellationToken);
        Task Update(UserDto entity, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
    }
}
