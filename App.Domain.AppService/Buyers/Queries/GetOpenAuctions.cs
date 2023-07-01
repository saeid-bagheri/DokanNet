using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Buyers.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Buyers.Queries
{
    public class GetOpenAuctions : IGetOpenAuctions
    {
        private readonly IAuctionRepository _auctionRepository;
        private readonly ISellerRepository _sellerRepository;
        private readonly IStoreRepository _storeRepository;

        public GetOpenAuctions(IAuctionRepository auctionRepository, ISellerRepository sellerRepository,
                               IStoreRepository storeRepository)
        {
            _auctionRepository = auctionRepository;
            _sellerRepository = sellerRepository;
            _storeRepository = storeRepository;
        }
        public async Task<List<AuctionDto>> Execute(CancellationToken cancellationToken)
        {
            var auctions = (await _auctionRepository.GetAll(cancellationToken))
                           .Where(a => a.EndTime > DateTime.Now && a.StartTime < DateTime.Now)
                           .OrderBy(a => a.EndTime)
                           .ToList();
            foreach (var auction in auctions)
            {
                auction.StoreTitle = (await _storeRepository.GetById(auction.StoreId, cancellationToken)).Title;
                auction.SellerName = (await _sellerRepository.GetById(auction.StoreId, cancellationToken)).FirstName + " " +
                                     (await _sellerRepository.GetById(auction.StoreId, cancellationToken)).LastName;
            }
            return auctions;
        }
    }
}
