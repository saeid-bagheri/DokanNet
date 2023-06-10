using App.Domain.Core.DtoModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins.Commands
{
    public interface ILoginUser
    {
        Task<SignInResult> Execute(UserDto model, CancellationToken cancellationToken);
    }
}
