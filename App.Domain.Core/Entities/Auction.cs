using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class Auction
{
    public int Id { get; set; }

    public int SellerId { get; set; }

    public int ProductId { get; set; }

    public int CountOfProducts { get; set; }

    public int Price { get; set; }

    public bool HasBuyer { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public DateTime CreatedAt { get; set; }

    #region navigations

    public virtual ICollection<Bid> Bids { get; set; } = new List<Bid>();

    public virtual Seller Seller { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    #endregion navigations
}
