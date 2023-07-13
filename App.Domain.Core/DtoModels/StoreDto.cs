using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class StoreDto
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string? SellerName { get; set; } = null!;

        public string? ImageUrl { get; set; }
        public IFormFile? Image { get; set; }

        public bool IsClosed { get; set; }

        public DateTime? ClosedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        #region navigations
        public virtual ICollection<AuctionDto> Auctions { get; set; } = new List<AuctionDto>();

        public virtual SellerDto IdNavigation { get; set; } = null!;

        public virtual ICollection<ProductDto> Products { get; set; } = new List<ProductDto>();

        #endregion navigations
    }
}
