using App.Domain.Core.Entities;

namespace App.Domain.Core.DtoModels
{
    public class BuyerDto
    {

        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Mobile { get; set; }

        public string? Address { get; set; }

        public int CityId { get; set; }

        public string? ProfileImgUrl { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime? DeletedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        #region navigations

        public virtual ICollection<BidDto> Bids { get; set; } = new List<BidDto>();

        public virtual CityDto? City { get; set; }

        public virtual ICollection<CommentDto> Comments { get; set; } = new List<CommentDto>();

        public virtual ICollection<InvoiceDto> Invoices { get; set; } = new List<InvoiceDto>();

        #endregion navigations
    }
}