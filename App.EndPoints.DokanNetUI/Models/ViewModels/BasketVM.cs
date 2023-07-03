using App.Domain.Core.Entities;

namespace App.EndPoints.DokanNetUI.Models.ViewModels
{
    public class BasketVM
    {
        public int TotalAmount { get; set; }

        public int BuyerId { get; set; }
        public string? BuyerName { get; set; }

        public int SellerId { get; set; }
        public string? SellerName { get; set; }

        #region navigations

        public virtual Buyer Buyer { get; set; } = null!;

        public virtual Seller Seller { get; set; } = null!;

        public virtual ICollection<InvoiceProduct> InvoiceProducts { get; set; } = new List<InvoiceProduct>();

        #endregion navigations
    }
}
