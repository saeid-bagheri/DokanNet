using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Common.Queries
{
    public interface IGetLastPriceOfAuction
    {
        Task<int> Execute(int auctionId, CancellationToken cancellationToken); 
    }
}
