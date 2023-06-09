﻿using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class ImageDto
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Url { get; set; } = null!;

        public int ProductId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        #region navigations

        public virtual ProductDto Product { get; set; } = null!;

        #endregion navigations
    }
}
