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

            CreateMap<UserVM, UserDto>().ReverseMap();

            CreateMap<Areas.Admin.Models.ViewModels.ProductVM, ProductDto>().ReverseMap();

            CreateMap<Areas.Admin.Models.ViewModels.StoreVM, StoreDto>().ReverseMap();

            CreateMap<CommentVM, CommentDto>().ReverseMap();

            CreateMap<InvoiceVM, InvoiceDto>().ReverseMap();

            CreateMap<CreateSellerAndStoreVM, SellerDto>().ReverseMap();
            CreateMap<CreateSellerAndStoreVM, StoreDto>().ReverseMap();
            CreateMap<UpdateSellerProfileVM, SellerDto>().ReverseMap();
            CreateMap<Areas.Seller.Models.ViewModels.ProductVM, ProductDto>().ReverseMap();

        }
    }
}
