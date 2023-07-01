using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;

namespace App.EndPoints.DokanNetUI.Models.ViewModels
{
    public class BuyerProductVM
    {

        public int Id { get; set; }

        public int StoreId { get; set; }
        public string? StoreTitle { get; set; }
        public string? SellerName { get; set; }


        public string Title { get; set; } = null!;

        public int? CategoryId { get; set; }
        public List<CategoryDto> Categories { get; set; } = new List<CategoryDto>();

        public int? Stock { get; set; }


        public int? Price { get; set; }

        public IFormFile? Image { get; set; }

        public List<Image> Images { get; set; } = new List<Image>();

        public DateTime CreatedAt { get; set; }
    }
}
