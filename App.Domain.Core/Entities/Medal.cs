using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class Medal
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    #region navigations

    public virtual ICollection<Seller> Sellers { get; set; } = new List<Seller>();

    #endregion navigations
}
