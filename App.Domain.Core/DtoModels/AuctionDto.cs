using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class AuctionDto
    {

        public int Id { get; set; }
        public int StoreId { get; set; }
        public string? StoreTitle { get; set; }
        public string? SellerName { get; set; }

        public int ProductId { get; set; }
        public string ProductTitle { get; set; } = null!;
        public virtual List<ImageDto> ProductImages { get; set; } = new List<ImageDto>();

        public int CountOfProducts { get; set; }

        public int Price { get; set; }

        public bool HasBuyer { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime CreatedAt { get; set; }

        #region navigations

        public virtual ICollection<BidDto> Bids { get; set; } = new List<BidDto>();

        public virtual StoreDto Store { get; set; } = null!;

        #endregion navigations
    }
}
