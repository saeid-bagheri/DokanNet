﻿using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class InvoiceProduct
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public int ProductId { get; set; }

    public int CountOfProducts { get; set; }

    #region navigations

    public virtual Invoice Invoice { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    #endregion navigations
}
