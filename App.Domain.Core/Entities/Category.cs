using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class Category
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public string Title { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    #region navigations

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    #endregion navigations
}
