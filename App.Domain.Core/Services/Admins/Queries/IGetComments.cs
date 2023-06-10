using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Admins.Queries
{
    public interface IGetComments
    {
        Task<List<CommentDto>> Execute(CancellationToken cancellationToken);
    }
}
