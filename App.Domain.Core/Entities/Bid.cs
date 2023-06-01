using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class Bid
{
    public int Id { get; set; }

    public int BuyerId { get; set; }

    public int AuctionId { get; set; }

    public int Price { get; set; }

    public bool IsWinner { get; set; }

    public DateTime CreatedAt { get; set; }

    #region navigations

    public virtual Auction Auction { get; set; } = null!;

    public virtual Buyer Buyer { get; set; } = null!;

    #endregion navigations
}
