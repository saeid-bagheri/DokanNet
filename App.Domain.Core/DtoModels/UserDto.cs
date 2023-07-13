using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace App.Domain.Core.DtoModels
{
    public class UserDto
    {
        public int Id { get; set; }
        public string? UserName { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
        public string? ConfirmPassword { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public string? PhoneNumber { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public List<string>? Roles { get; set; } = new List<string>();

        #region Navigation properties

        public BuyerDto? Buyer { get; set; }
        public SellerDto? Seller { get; set; }
        public Admin? Admin { get; set; }

        #endregion Navigation properties
    }
}