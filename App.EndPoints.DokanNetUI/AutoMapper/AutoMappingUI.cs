﻿using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels;
using App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using App.Infrastructures.Data.Repositories;
using AutoMapper;

namespace App.EndPoints.DokanNetUI.AutoMapper
{
    public class AutoMappingUI : Profile
    {
        public AutoMappingUI()
        {
            CreateMap<RegisterVM, UserDto>().ReverseMap();
            CreateMap<LoginVM, UserDto>().ReverseMap();
            CreateMap<AdminUserVM, UserDto>().ReverseMap();

            CreateMap<AdminProductVM, ProductDto>().ReverseMap();
            CreateMap<AdminStoreVM, StoreDto>().ReverseMap();
            CreateMap<AdminCategoryVM, CategoryDto>().ReverseMap();
            CreateMap<AdminCommentVM, CommentDto>().ReverseMap();
            CreateMap<AdminInvoiceVM, InvoiceDto>().ReverseMap();

            CreateMap<CreateSellerAndStoreVM, SellerDto>().ReverseMap();
            CreateMap<CreateSellerAndStoreVM, StoreDto>().ReverseMap();
            CreateMap<UpdateSellerProfileVM, SellerDto>().ReverseMap();
            CreateMap<SellerProductVM, ProductDto>().ReverseMap();
            CreateMap<SellerAuctionVM, AuctionDto>().ReverseMap();
            CreateMap<SellerCreateAuctionVM, AuctionDto>().ReverseMap();
            CreateMap<SellerInvoiceVM, InvoiceDto>().ReverseMap();

            CreateMap<BuyerAuctionVM, AuctionDto>().ReverseMap();
            CreateMap<BuyerProductVM, ProductDto>().ReverseMap();
            CreateMap<BidVM, BidDto>().ReverseMap();
            CreateMap<BasketVM, InvoiceDto>().ReverseMap();
            CreateMap<BuyerProfileVM, BuyerDto>().ReverseMap();
            CreateMap<UpdateBuyerProfileVM, BuyerDto>().ReverseMap();
            CreateMap<BuyerCategoryVM, CategoryDto>().ReverseMap();
            CreateMap<BuyerStoreVM, StoreDto>().ReverseMap();

            CreateMap<Product, ProductDto>().ReverseMap();

        }
    }
}