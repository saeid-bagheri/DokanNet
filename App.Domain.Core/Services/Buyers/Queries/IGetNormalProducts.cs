using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Buyers.Queries
{
    public interface IGetNormalProducts
    {
        Task<List<ProductDto>> Execute(CancellationToken cancellationToken);
    }
}
