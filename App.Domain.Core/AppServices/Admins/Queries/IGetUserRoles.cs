﻿using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins.Queries
{
    public interface IGetUserRoles
    {
        Task<List<string>> Execute(string userName ,CancellationToken cancellationToken);
    }
}
