using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class Seller
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string? ShebaNumber { get; set; }

    public string? CardNumber { get; set; }

    public string Address { get; set; } = null!;

    public int CityId { get; set; }

    public string? ProfileImgUrl { get; set; }

    public string? Biography { get; set; }

    public int? MedalId { get; set; }

    public decimal FeePercentage { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? Birthday { get; set; }

    public DateTime CreatedAt { get; set; }

    #region navigations
    public virtual AppUser IdNavigation { get; set; } = null!;

    public virtual ICollection<Auction> Auctions { get; set; } = new List<Auction>();

    public virtual City City { get; set; } = null!;

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual Medal? Medal { get; set; }

    public virtual Store? Store { get; set; }
    #endregion navigations
}
