using App.Domain.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "نام محصول")]
        public string Title { get; set; } = null!;

        public string? CategoryTitle { get; set; }

        public string? SellerName { get; set; }

        public string? StoreTitle { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "تعداد محصول")]
        public int Stock { get; set; }

        [Display(Name = "تایید محصول")]
        public bool IsConfirmed { get; set; }

        [Display(Name = "محصول مزایده ای")]
        public bool IsAuction { get; set; }

        [Display(Name = "محصول فعال")]
        public bool IsEnabled { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Range(1, int.MaxValue, ErrorMessage = "قیمت محصول نمیتواند 0 تومان باشد")]
        [Display(Name = "قیمت محصول (تومان)")]
        public int Price { get; set; }
    }
}
