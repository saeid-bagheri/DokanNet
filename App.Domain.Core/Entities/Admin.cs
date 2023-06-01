using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class Admin
{
    public int Id { get; set; }

    public int AppUserId { get; set; }

    public string? ShebaNumber { get; set; }

    public string? CardNumber { get; set; }

    public int TotalRevenue { get; set; }

    #region navigations
    public AppUser? AppUser { get; set; }
    #endregion navigations
}
