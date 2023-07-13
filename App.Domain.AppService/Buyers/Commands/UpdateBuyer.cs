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
    public class UpdateBuyer : IUpdateBuyer
    {
        private readonly IBuyerRepository _buyerRepository;
        private readonly ISellerRepository _sellerRepository;

        public UpdateBuyer(IBuyerRepository buyerRepository, ISellerRepository sellerRepository)
        {
            _buyerRepository = buyerRepository;
            _sellerRepository = sellerRepository;
        }
        public async Task Execute(BuyerDto entity, CancellationToken cancellationToken)
        {
            await _buyerRepository.Update(entity, cancellationToken);

            //update seller
            var sellerDto = await _sellerRepository.GetById(entity.Id, cancellationToken);
            if (sellerDto is not null)
            {
                if (entity.FirstName is not null)
                {
                    sellerDto.FirstName = entity.FirstName;
                }
                if (entity.LastName is not null)
                {
                    sellerDto.LastName = entity.LastName;
                }
                if (entity.Mobile is not null)
                {
                    sellerDto.Mobile = entity.Mobile;
                }
                if (entity.Address is not null)
                {
                    sellerDto.Address = entity.Address;
                }
                sellerDto.CityId = entity.CityId;
                if (entity.ProfileImgUrl is not null)
                {
                    sellerDto.ProfileImgUrl = entity.ProfileImgUrl;
                }
                await _sellerRepository.Update(sellerDto, cancellationToken);
            }
        }
    }
}
