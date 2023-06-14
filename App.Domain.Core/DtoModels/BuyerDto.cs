﻿using App.Domain.Core.Entities;

namespace App.Infrastructures.Data.Repositories
{
    public class BuyerDto
    {

        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Mobile { get; set; }

        public string? Address { get; set; }

        public int? CityId { get; set; }

        public string? ProfileImgUrl { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime? DeletedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        #region navigations

        public virtual ICollection<Bid> Bids { get; set; } = new List<Bid>();

        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

        #endregion navigations
    }
}