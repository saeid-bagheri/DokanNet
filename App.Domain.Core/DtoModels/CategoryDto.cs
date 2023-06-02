﻿using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public string Title { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }

        #region navigations

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

        #endregion navigations
    }
}