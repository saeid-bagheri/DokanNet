using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins.Queries
{
    public interface IGetUserById
    {
        Task<UserDto> Execute(int id, CancellationToken cancellationToken);
    }
}
