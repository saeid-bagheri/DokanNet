using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Models.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [EmailAddress(ErrorMessage = "* ایمیل نامعتبر است")]
        [Display(Name = "آدرس ایمیل")]
        public string Email { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "تکرار پسورد اشتباه است")]
        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز عبور")]
        public string ConfirmPassword { get; set; }
    }
}
