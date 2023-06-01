using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class CommentDto
    {
        public int Id { get; set; }

        public string Description { get; set; } = null!;

        public int Score { get; set; }

        public bool IsConfirmed { get; set; }

        public int BuyerId { get; set; }

        public int ProductId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        #region navigations

        public virtual Buyer Buyer { get; set; } = null!;

        public virtual Product Product { get; set; } = null!;

        #endregion navigations
    }
}
