using App.Domain.Core.DtoModels;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels
{
    public class AdminCategoryVM
    {
        public int Id { get; set; }

        [Display(Name = "دسته بندی پدر")]
        public int? ParentId { get; set; }
        public string? ParentTitle { get; set; }
        
        public List<CategoryDto> Categories { get; set; } = new List<CategoryDto>();

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "نام دسته بندی")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "وارد  کردن {0} اجباری است ")]
        [Display(Name = "عکس دسته بندی")]
        public IFormFile? Image { get; set; }
    }
}
