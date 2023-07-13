using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class InvoiceDto
    {
        public int Id { get; set; }

        public int TotalAmount { get; set; }

        public int SiteCommission { get; set; }

        public int BuyerId { get; set; }
        public string? BuyerName { get; set; }

        public int SellerId { get; set; }
        public string? SellerName { get; set; }

        public bool IsFinal { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        #region navigations

        public virtual BuyerDto Buyer { get; set; } = null!;

        public virtual SellerDto Seller { get; set; } = null!;

        public virtual ICollection<InvoiceProductDto> InvoiceProducts { get; set; } = new List<InvoiceProductDto>();

        #endregion navigations
    }
}
