using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels
{
    public class SellerAuctionVM
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "محصول")]
        public int? ProductId { get; set; }

        public string? ProductTitle { get; set; }
        public virtual List<Image> ProductImages { get; set; } = new List<Image>();
        public virtual List<ProductDto> Products { get; set; } = new List<ProductDto>();

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "تعداد محصول")]
        public int? CountOfProducts { get; set; }

        public int Price { get; set; }

        public bool HasBuyer { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "زمان شروع")]
        public DateTime? StartTime { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "زمان پایان")]
        public DateTime? EndTime { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
