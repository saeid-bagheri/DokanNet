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
    public class AutoMapperProfileDto : Profile
    {
        public AutoMapperProfileDto()
        {

            CreateMap<AppUser, UserDto>();
            CreateMap<AppUser, UserDto>().ReverseMap();

            CreateMap<Auction, AuctionDto>();
            CreateMap<Auction, AuctionDto>().ReverseMap();

            CreateMap<Bid, BidDto>().ReverseMap(); //reverse so the both direction
            CreateMap<Seller, SellerDto>();
        }
    }
}
