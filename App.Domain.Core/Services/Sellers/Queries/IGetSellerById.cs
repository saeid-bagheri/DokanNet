using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Sellers.Queries
{
    public interface IGetSellerById
    {
        Task<SellerDto> Execute(int id, CancellationToken cancellationToken);
    }
}
