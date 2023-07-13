using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class BidDto
    {
        public int Id { get; set; }

        public int BuyerId { get; set; }

        public int AuctionId { get; set; }

        public int Price { get; set; }

        public bool IsWinner { get; set; }

        public DateTime CreatedAt { get; set; }

        #region navigations

        public virtual AuctionDto Auction { get; set; } = null!;

        public virtual BuyerDto Buyer { get; set; } = null!;

        #endregion navigations
    }
}
