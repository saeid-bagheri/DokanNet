using App.Domain.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels
{
    public class InvoiceVM
    {
        public int Id { get; set; }

        [Display(Name = "مبلغ کل فاکتور")]
        public int TotalAmount { get; set; }

        [Display(Name = "کمیسیون سایت")]
        public int SiteCommission { get; set; }

        public int BuyerId { get; set; }
        public string? BuyerName { get; set; }

        public int SellerId { get; set; }
        public string? SellerName { get; set; }
    }
}
