using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;

namespace App.Domain.Core.DtoModels
{
    public class InvoiceProductDto
    {
        public int Id { get; set; }

        public int InvoiceId { get; set; }

        public int ProductId { get; set; }

        public int CountOfProducts { get; set; }

        #region navigations

        public virtual InvoiceDto Invoice { get; set; } = null!;

        public virtual ProductDto Product { get; set; } = null!;

        #endregion navigations
    }

}