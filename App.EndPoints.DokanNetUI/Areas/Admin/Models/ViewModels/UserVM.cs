using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels
{
    public class UserVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "نام کاربری")]
        public string? UserName { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "* ایمیل نامعتبر است")]
        [Display(Name = "آدرس ایمیل")]
        public string? Email { get; set; } = string.Empty;

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^09\d{9}$", ErrorMessage = "لطفاً یک شماره موبایل معتبر وارد کنید")]
        [Display(Name = "شماره موبایل")]
        public string? PhoneNumber { get; set; }
    }
}
