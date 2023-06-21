using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public int StoreId { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "نام محصول")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "دسته بندی")]
        public int? CategoryId { get; set; }
        public List<CategoryDto> Categories { get; set; } = new List<CategoryDto>();

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "تعداد محصول")]
        public int? Stock { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "محصول مزایده ای")]
        public bool IsAuction { get; set; }

        public bool IsConfirmed { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "قیمت محصول")]
        public int? Price { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "عکس محصول")]
        public IFormFile? Image { get; set; }

        public List<Image> Images { get; set; } = new List<Image>();
    }
}
