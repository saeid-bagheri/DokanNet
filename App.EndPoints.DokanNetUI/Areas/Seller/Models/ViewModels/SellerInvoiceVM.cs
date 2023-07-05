using App.Domain.Core.Entities;

namespace App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels
{
    public class SellerInvoiceVM
    {
        public int Id { get; set; }

        public int TotalAmount { get; set; }

        public int SiteCommission { get; set; }

        public int BuyerId { get; set; }
        public string? BuyerName { get; set; }

        public int SellerId { get; set; }
        public string? SellerName { get; set; }

        public bool IsFinal { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        #region navigations

        public virtual Buyer Buyer { get; set; } = null!;

        public virtual Domain.Core.Entities.Seller Seller { get; set; } = null!;

        public virtual ICollection<InvoiceProduct> InvoiceProducts { get; set; } = new List<InvoiceProduct>();

        #endregion navigations
    }
}