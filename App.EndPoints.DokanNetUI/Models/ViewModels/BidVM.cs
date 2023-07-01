using App.Domain.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Models.ViewModels
{
    public class BidVM
    {
        public int Id { get; set; }

        public int BuyerId { get; set; }

        public int AuctionId { get; set; }

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "قیمت پیشنهادی")]
        public int Price { get; set; }
    }
}
