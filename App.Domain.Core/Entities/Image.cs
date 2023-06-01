using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class Image
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Url { get; set; } = null!;

    public int ProductId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    #region navigations

    public virtual Product Product { get; set; } = null!;

    #endregion navigations
}
