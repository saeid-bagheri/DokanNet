using App.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Db.SqlServer.Ef.SeedData
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            //appUser
            var user = new AppUser()
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                UserName = "SaeidBagheri034",
                NormalizedUserName = "SAEIDBAGHERI034",
                Email = "saeidbagheri034@gmail.com",
                NormalizedEmail = "SAEIDBAGHERI034@GMAIL.COM",
                EmailConfirmed = false,
                PhoneNumber = "09389059421",
                PhoneNumberConfirmed = false,
                IsDeleted = false
            };
            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            user.PasswordHash = passwordHasher.HashPassword(user, "13691205");
            modelBuilder.Entity<AppUser>().HasData(user);


            //role
            modelBuilder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int>() { Id = 1, Name = "AdminRole", NormalizedName = "ADMINROLE"},
                new IdentityRole<int>() { Id = 2, Name = "SellerRole", NormalizedName = "SELLERROLE"},
                new IdentityRole<int>() { Id = 3, Name = "BuyerRole", NormalizedName = "BUYERROLE"}
                );


            //userRole
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int>() { UserId = 1, RoleId = 1 },
                new IdentityUserRole<int>() { UserId = 1, RoleId = 2 },
                new IdentityUserRole<int>() { UserId = 1, RoleId = 3 }
                );


            //category
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Title = "پوشاک",
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                });


            //city
            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    Id = 1,
                    Title = "تهران"
                });


            //Medal
            modelBuilder.Entity<Medal>().HasData(
                new Medal() { Id = 1, Title = "طلا" },
                new Medal() { Id = 2, Title = "نقره" },
                new Medal() { Id = 3, Title = "برنز" }
                );


            //product
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Title = "شلوار لی",
                    CategoryId = 1,
                    StoreId = 1,
                    Stock = 10,
                    IsConfirmed = true,
                    IsAuction = false,
                    IsEnabled = true,
                    Price = 500000,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                },
                new Product()
                {
                    Id = 2,
                    Title = "پیراهن مردانه",
                    CategoryId = 1,
                    StoreId = 1,
                    Stock = 15,
                    IsConfirmed = true,
                    IsAuction = false,
                    IsEnabled = true,
                    Price = 300000,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                });


            //seller
            modelBuilder.Entity<Seller>().HasData(
                new Seller()
                {
                    Id = 1,
                    AppUserId = 1,
                    FirstName = "سعید",
                    LastName = "باقری",
                    Mobile = "09389059421",
                    Address = "تهران",
                    CityId = 1,
                    FeePercentage = 5,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                });


            //buyer
            modelBuilder.Entity<Buyer>().HasData(
                new Buyer()
                {
                    Id = 1,
                    AppUserId = 1,
                    FirstName = "سعید",
                    LastName = "باقری",
                    Mobile = "09389059421",
                    Address = "تهران",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                });


            //store
            modelBuilder.Entity<Store>().HasData(
                new Store()
                {
                    Id = 1,
                    Title = "لباسفروشی",
                    IsClosed = false,
                    CreatedAt = DateTime.Now
                });






        }
    }
}
