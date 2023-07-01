using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Models.ViewModels
{
    public class BuyerAuctionVM
    {

        public int Id { get; set; }

        public int StoreId { get; set; }
        public string? StoreTitle { get; set; }
        public string? SellerName { get; set; }

        public int? ProductId { get; set; }

        public string? ProductTitle { get; set; }
        public virtual List<Image> ProductImages { get; set; } = new List<Image>();
        public virtual List<ProductDto> Products { get; set; } = new List<ProductDto>();


        public int? CountOfProducts { get; set; }

        public int Price { get; set; }

        public bool HasBuyer { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
