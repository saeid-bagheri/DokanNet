using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;

namespace App.EndPoints.DokanNetUI.Models.ViewModels
{
    public class BuyerProfileVM
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Mobile { get; set; } = null!;

        public string Address { get; set; } = null!;

        public int CityId { get; set; }
        public string CityName { get; set; } = null!;
        public virtual City? City { get; set; }

        public string? ProfileImgUrl { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<InvoiceDto> Invoices { get; set; }
    }
}
