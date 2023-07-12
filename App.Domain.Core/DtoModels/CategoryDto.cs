using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App.Domain.Core.DtoModels
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }
        public string? ParentTitle { get; set; }

        public string Title { get; set; } = null!;

        public string? ImageUrl { get; set; }
        public IFormFile? Image { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<CategoryDto> SubCategories { get; set; } = new List<CategoryDto>();

        #region navigations

        public virtual ICollection<ProductDto> Products { get; set; } = new List<ProductDto>();

        #endregion navigations
    }
}
