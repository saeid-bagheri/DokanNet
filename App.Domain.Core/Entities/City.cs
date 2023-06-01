using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class City
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    #region navigations

    public virtual ICollection<Seller> Sellers { get; set; } = new List<Seller>();
    public virtual ICollection<Buyer> Buyers { get; set; } = new List<Buyer>();

    #endregion navigations
}
