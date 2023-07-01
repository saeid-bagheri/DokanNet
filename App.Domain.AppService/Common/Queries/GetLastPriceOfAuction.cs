using App.Domain.Core.Services.Common.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Common.Queries
{
    public class GetLastPriceOfAuction : IGetLastPriceOfAuction
    {
        private readonly IAuctionRepository _auctionRepository;

        public GetLastPriceOfAuction(IAuctionRepository auctionRepository)
        {
            _auctionRepository = auctionRepository;
        }

        public async Task<int> Execute(int auctionId, CancellationToken cancellationToken)
        {
            return (await _auctionRepository.GetById(auctionId, cancellationToken)).Price;
        }
    }
}
