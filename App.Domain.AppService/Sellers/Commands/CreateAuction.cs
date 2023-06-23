using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Sellers.Commands;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Sellers.Commands
{
    public class CreateAuction : ICreateAuction
    {
        private readonly IAuctionRepository _auctionRepository;
        private readonly IGetProductById _getProductById;

        public CreateAuction(IAuctionRepository auctionRepository, IGetProductById getProductById)
        {
            _auctionRepository = auctionRepository;
            _getProductById = getProductById;
        }
        public async Task Execute(AuctionDto entity, CancellationToken cancellationToken)
        {
            var auctionDto = new AuctionDto()
            {
                StoreId = entity.StoreId,
                ProductId = entity.ProductId,
                CountOfProducts = entity.CountOfProducts,
                Price = entity.CountOfProducts * (await _getProductById.Execute(entity.ProductId, cancellationToken)).Price,
                HasBuyer = false,
                ProductTitle = entity.ProductTitle,
                StartTime = entity.StartTime,
                EndTime = entity.EndTime,
                CreatedAt = DateTime.Now
            };
            await _auctionRepository.Create(auctionDto, cancellationToken);
        }
    }
}
