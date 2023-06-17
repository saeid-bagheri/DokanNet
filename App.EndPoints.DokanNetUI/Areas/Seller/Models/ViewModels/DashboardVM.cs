using App.Domain.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels
{
    public class DashboardVM
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

        public string? ImageUrl { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
