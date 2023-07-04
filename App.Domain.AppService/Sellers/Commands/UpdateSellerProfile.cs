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
    public class UpdateSellerProfile : IUpdateSellerProfile
    {
        private readonly ISellerRepository _sellerRepository;
        private readonly IBuyerRepository _buyerRepository;

        public UpdateSellerProfile(ISellerRepository sellerRepository, IBuyerRepository buyerRepository)
        {
            _sellerRepository = sellerRepository;
            _buyerRepository = buyerRepository;
        }
        public async Task Execute(SellerDto entity, CancellationToken cancellationToken)
        {
            //update seller
            var sellerDto = await _sellerRepository.GetById(entity.Id, cancellationToken);
            sellerDto.FirstName = entity.FirstName;
            sellerDto.LastName = entity.LastName;
            sellerDto.Mobile = entity.Mobile;
            sellerDto.ShebaNumber = entity.ShebaNumber;
            sellerDto.CardNumber = entity.CardNumber;
            sellerDto.Address = entity.Address;
            sellerDto.CityId = entity.CityId;
            sellerDto.ProfileImgUrl = entity.ProfileImgUrl;
            sellerDto.Birthday = entity.Birthday;
            await _sellerRepository.Update(sellerDto, cancellationToken);

            //update buyerz
            var buyerDto = new BuyerDto()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Mobile = entity.Mobile,
                Address = entity.Address,
                CityId = entity.CityId,
                ProfileImgUrl = entity.ProfileImgUrl
            };
            await _buyerRepository.Update(buyerDto, cancellationToken);
            
        }
    }
}
