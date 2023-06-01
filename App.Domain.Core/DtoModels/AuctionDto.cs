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

        public int SellerId { get; set; }

        public int ProductId { get; set; }

        public int CountOfProducts { get; set; }

        public int Price { get; set; }

        public bool HasBuyer { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime CreatedAt { get; set; }

        #region navigations

        public virtual ICollection<Bid> Bids { get; set; } = new List<Bid>();

        public virtual Seller Seller { get; set; } = null!;

        #endregion navigations
    }
}
