using App.Domain.Core.DtoModels;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Models.ViewModels
{
    public class UpdateBuyerProfileVM
    {
        public int Id { get; set; }

        [Display(Name = "نام")]
        public string? FirstName { get; set; } = null!;

        [Display(Name = "نام خانوادگی")]
        public string? LastName { get; set; } = null!;

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^09\d{9}$", ErrorMessage = "لطفاً یک شماره موبایل معتبر وارد کنید")]
        [Display(Name = "شماره موبایل")]
        public string? Mobile { get; set; } = null!;


        [Display(Name = "آدرس")]
        public string? Address { get; set; } = null!;

        [Display(Name = "نام شهر")]
        public int CityId { get; set; }

        public List<CityDto> Cities { get; set; } = new List<CityDto>();

        [Display(Name = "عکس پروفایل")]
        public string? ProfileImgUrl { get; set; }
    }
}
