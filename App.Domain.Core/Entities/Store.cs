using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class Store
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public bool IsClosed { get; set; }

    public DateTime? ClosedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    #region navigations

    public virtual Seller IdNavigation { get; set; } = null!;

    public virtual ICollection<Auction> Auctions { get; set; } = new List<Auction>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    #endregion navigations
}
