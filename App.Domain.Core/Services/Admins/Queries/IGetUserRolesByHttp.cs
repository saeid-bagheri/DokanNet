﻿using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins.Queries
{
    public interface IGetUserRolesByHttp
    {
        Task<List<string>> Execute(CancellationToken cancellationToken);
    }
}
