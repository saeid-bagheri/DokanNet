using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Buyers.Commands;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Buyers.Commands
{
    public class LosingBidsInAuction : ILosingBidsInAuction
    {
        private readonly IBidRepository _bidRepository;

        public LosingBidsInAuction(IBidRepository bidRepository)
        {
            _bidRepository = bidRepository;
        }

        public async Task Execute(int auctionId, CancellationToken cancellationToken)
        {
            var bids = await _bidRepository.GetAllByAuctionId(auctionId, cancellationToken);
            foreach (var bid in bids)
            {
                bid.IsWinner = false;
                await _bidRepository.Update(bid, cancellationToken);
            }
        }
    }
}
