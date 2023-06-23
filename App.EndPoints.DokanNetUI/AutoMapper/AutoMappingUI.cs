using App.Domain.Core.DtoModels;
using App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels;
using App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels;
using App.EndPoints.DokanNetUI.Models.ViewModels;
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

            CreateMap<Areas.Admin.Models.ViewModels.AdminProductVM, ProductDto>().ReverseMap();

            CreateMap<AdminStoreVM, StoreDto>().ReverseMap();

            CreateMap<AdminCategoryVM, CategoryDto>().ReverseMap();

            CreateMap<AdminCommentVM, CommentDto>().ReverseMap();

            CreateMap<AdminInvoiceVM, InvoiceDto>().ReverseMap();

            CreateMap<CreateSellerAndStoreVM, SellerDto>().ReverseMap();
            CreateMap<CreateSellerAndStoreVM, StoreDto>().ReverseMap();
            CreateMap<UpdateSellerProfileVM, SellerDto>().ReverseMap();
            CreateMap<SellerProductVM, ProductDto>().ReverseMap();
            CreateMap<SellerAuctionVM, AuctionDto>().ReverseMap();

        }
    }
}
