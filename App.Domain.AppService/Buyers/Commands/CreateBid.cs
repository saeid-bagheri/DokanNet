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
    public class CreateBid : ICreateBid
    {
        private readonly IBidRepository _bidRepository;
        private readonly IAuctionRepository _auctionRepository;

        public CreateBid(IBidRepository bidRepository, IAuctionRepository auctionRepository)
        {
            _bidRepository = bidRepository;
            _auctionRepository = auctionRepository;
        }

        public async Task Execute(BidDto entity, CancellationToken cancellationToken)
        {
            var bidDto = new BidDto()
            {
                AuctionId = entity.AuctionId,
                BuyerId = entity.BuyerId,
                IsWinner = true,
                Price = entity.Price,
                CreatedAt = DateTime.Now
            };
            await _bidRepository.Create(bidDto, cancellationToken);

            //update auction price
            var auctionDto = await _auctionRepository.GetById(entity.AuctionId, cancellationToken);
            if (!auctionDto.HasBuyer)
            {
                auctionDto.HasBuyer = true;
            }
            auctionDto.Price = entity.Price;
            await _auctionRepository.Update(auctionDto, cancellationToken);

        }
    }
}
