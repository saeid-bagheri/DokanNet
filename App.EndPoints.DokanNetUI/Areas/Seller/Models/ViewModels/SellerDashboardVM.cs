using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels
{
    public class SellerDashboardVM
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Mobile { get; set; } = null!;

        public string? ShebaNumber { get; set; }

        public string? CardNumber { get; set; }

        public string Address { get; set; } = null!;

        public int CityId { get; set; }
        public string CityName { get; set; } = null!;

        public string? ProfileImgUrl { get; set; }

        public string? Biography { get; set; }

        public DateTime? Birthday { get; set; }

        public DateTime CreatedAt { get; set; }

        public string StoreTitle { get; set; } = null!;

        public int? MedalId { get; set; }

        public string? ImageUrl { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public virtual ICollection<Auction> Auctions { get; set; } = new List<Auction>();
        public virtual ICollection<InvoiceDto> Invoices { get; set; } = new List<InvoiceDto>();
    }
}
