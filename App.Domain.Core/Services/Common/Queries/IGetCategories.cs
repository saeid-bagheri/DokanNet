using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Application.Queries
{
    public interface IGetCategories
    {
        Task<List<CategoryDto>> Execute(CancellationToken cancellationToken);
    }
}
