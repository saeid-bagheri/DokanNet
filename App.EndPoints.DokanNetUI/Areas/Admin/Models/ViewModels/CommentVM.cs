using App.Domain.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels
{
    public class CommentVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "متن دیدگاه")]
        public string Description { get; set; } = null!;

        [Display(Name = "امتیاز")]
        public int Score { get; set; }

        [Display(Name = "تایید شده")]
        public bool IsConfirmed { get; set; }

        public string? BuyerName { get; set; }

        public string? ProductName { get; set; }
    }
}