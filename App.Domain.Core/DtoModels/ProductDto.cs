using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;

namespace App.Domain.Core.DtoModels
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public int CategoryId { get; set; }
        public string? CategoryTitle { get; set; }

        public int StoreId { get; set; }
        public string? StoreTitle { get; set; }

        public string? SellerName { get; set; }

        public int Stock { get; set; }
        public int CountInInvoice { get; set; }

        public bool IsConfirmed { get; set; }

        public bool IsAuction { get; set; }

        public bool IsEnabled { get; set; }

        public int Price { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public IFormFile? Image { get; set; }

        #region navigations

        public virtual Category Category { get; set; } = null!;

        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public virtual ICollection<Image> Images { get; set; } = new List<Image>();

        public virtual ICollection<InvoiceProduct> InvoiceProducts { get; set; } = new List<InvoiceProduct>();

        public virtual Store Store { get; set; } = null!;

        #endregion navigations
    }
}