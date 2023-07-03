using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class Invoice
{
    public int Id { get; set; }

    public int TotalAmount { get; set; }

    public int SiteCommission { get; set; }

    public int BuyerId { get; set; }

    public int SellerId { get; set; }

    public bool IsFinal { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    #region navigations

    public virtual Buyer Buyer { get; set; } = null!;

    public virtual Seller Seller { get; set; } = null!;

    public virtual ICollection<InvoiceProduct> InvoiceProducts { get; set; } = new List<InvoiceProduct>();

    #endregion navigations
}
