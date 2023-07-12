using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;

namespace App.EndPoints.DokanNetUI.Models.ViewModels
{
    public class BuyerCategoryVM
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }
        public string? ParentTitle { get; set; }

        public string Title { get; set; } = null!;
        public string? ImageUrl { get; set; }

        public virtual ICollection<CategoryDto> SubCategories { get; set; } = new List<CategoryDto>();

        #region navigations

        public virtual List<ProductDto> Products { get; set; } = new List<ProductDto>();

        #endregion navigations
    }
}