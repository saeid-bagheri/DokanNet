﻿using App.Domain.Core.DtoModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins.Commands
{
    public interface IRegisterUser
    {
        Task<IdentityResult> Execute(UserDto entity, CancellationToken cancellationToken);
    }
}
