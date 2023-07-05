using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Common.Queries
{
    public interface IGetProducts
    {
        Task<List<ProductDto>> Execute(CancellationToken cancellationToken);
    }
}
