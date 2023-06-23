using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Sellers.Queries
{
    public interface IGetAuctionsByStoreId
    {
        Task<List<AuctionDto>> Execute(int storeId, CancellationToken cancellationToken);
    }
}
