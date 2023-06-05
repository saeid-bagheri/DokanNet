using App.Domain.Core.DtoModels;
using App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels;
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

            CreateMap<UpdateUserVM, UserDto>().ReverseMap();
            CreateMap<UserVM, UserDto>().ReverseMap();

            CreateMap<ProductVM, ProductDto>().ReverseMap();
        }
    }
}
