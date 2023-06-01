using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace App.Domain.Core.Entities;

public partial class AppUser : IdentityUser<int>
{
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }

    #region Navigation properties

    public Buyer? Buyer { get; set; }
    public Seller? Seller { get; set; }
    public Admin? Admin { get; set; }

    #endregion Navigation properties

}
