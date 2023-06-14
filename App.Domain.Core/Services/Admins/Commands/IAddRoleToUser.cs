using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Admins.Commands
{
    public interface IAddRoleToUser
    {
        Task Execute(AppUser user, string role, CancellationToken cancellationToken);
    }
}
