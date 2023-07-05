using App.Domain.Core.DtoModels;

namespace App.EndPoints.DokanNetUI.Models.ViewModels
{
    public class BuyerStoreVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? SellerName { get; set; }
        public string? ImageUrl { get; set; }
        public SellerDto Seller { get; set; }

        public virtual ICollection<ProductDto> Products { get; set; } = new List<ProductDto>();
    }
}
