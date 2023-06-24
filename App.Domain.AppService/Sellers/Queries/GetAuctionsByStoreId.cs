using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Sellers.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Sellers.Queries
{
    public class GetAuctionsByStoreId : IGetAuctionsByStoreId
    {
        private readonly IAuctionRepository _auctionRepository;
        private readonly IGetProductById _getProductById;

        public GetAuctionsByStoreId(IAuctionRepository auctionRepository, IGetProductById getProductById)
        {
            _auctionRepository = auctionRepository;
            _getProductById = getProductById;
        }
        public async Task<List<AuctionDto>> Execute(int storeId, CancellationToken cancellationToken)
        {
            var auctions = await _auctionRepository.GetAllByStoreId(storeId, cancellationToken);
            return auctions;
        }
    }
}
