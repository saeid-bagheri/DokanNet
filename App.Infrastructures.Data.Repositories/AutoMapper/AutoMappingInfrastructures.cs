using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Data.Repositories.AutoMapper
{
    public class AutoMappingInfrastructures : Profile
    {
        public AutoMappingInfrastructures()
        {

            CreateMap<AppUser, UserDto>().ReverseMap();
            CreateMap<Seller, SellerDto>().ReverseMap();
            CreateMap<Buyer, BuyerDto>().ReverseMap();

            CreateMap<Auction, AuctionDto>().ReverseMap();

        }
    }
}
