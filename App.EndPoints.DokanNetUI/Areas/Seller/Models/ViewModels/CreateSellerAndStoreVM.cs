using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels
{
    public class CreateSellerAndStoreVM
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "نام")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; } = null!;

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^09\d{9}$", ErrorMessage = "لطفاً یک شماره موبایل معتبر وارد کنید")]
        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "شماره موبایل")]
        public string Mobile { get; set; } = null!;

        [Display(Name = "شماره شبا")]
        public string? ShebaNumber { get; set; }

        [Display(Name = "شماره کارت")]
        public string? CardNumber { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "آدرس")]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "نام شهر")]
        public int CityId { get; set; }

        public List<CityDto> Cities { get; set; } = new List<CityDto>();

        [Display(Name = "عکس پروفایل")]
        public string? ProfileImgUrl { get; set; }

        [Display(Name = "بیوگرافی")]
        public string? Biography { get; set; }

        [Display(Name = "تاریخ تولد")]
        public DateTime? Birthday { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "عنوان غرفه")]
        public string Title { get; set; } = null!;

        [Display(Name = "عکس غرفه")]
        public string? ImageUrl { get; set; }
    }
}
