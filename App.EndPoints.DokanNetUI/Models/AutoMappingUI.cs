using App.Domain.Core.DtoModels;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using AutoMapper;

namespace App.EndPoints.DokanNetUI.Models
{
    public class AutoMappingUI : Profile
    {
        public AutoMappingUI()
        {
            CreateMap<RegisterVM, UserDto>();
            CreateMap<LoginVM, UserDto>();
        }
    }
}
