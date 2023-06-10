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
            var user1 = new AppUser()
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
                LockoutEnabled = false,
                SecurityStamp = "54e8dfb5-8700-4936-a2cd-4b0369afa909",
                IsDeleted = false
            };
            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();
            user1.PasswordHash = passwordHasher.HashPassword(user1, "13691205");
            modelBuilder.Entity<AppUser>().HasData(user1);

            var user2 = new AppUser()
            {
                Id = 2,
                CreatedAt = DateTime.Now,
                UserName = "KeyvanHafezi",
                NormalizedUserName = "KEYVANHAFEZI",
                Email = "keyvanhafezi@gmail.com",
                NormalizedEmail = "KEYVANHAFEZI@GMAIL.COM",
                EmailConfirmed = false,
                PhoneNumber = "09199999999",
                PhoneNumberConfirmed = false,
                LockoutEnabled = false,
                IsDeleted = false
            };
            user2.PasswordHash = passwordHasher.HashPassword(user2, "1368");
            modelBuilder.Entity<AppUser>().HasData(user2);


            //role
            modelBuilder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int>() { Id = 1, Name = "AdminRole", NormalizedName = "ADMINROLE"},
                new IdentityRole<int>() { Id = 2, Name = "SellerRole", NormalizedName = "SELLERROLE"},
                new IdentityRole<int>() { Id = 3, Name = "BuyerRole", NormalizedName = "BUYERROLE" }
                );


            //userRole
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int>() { UserId = 1, RoleId = 1 },
                new IdentityUserRole<int>() { UserId = 1, RoleId = 2 },
                new IdentityUserRole<int>() { UserId = 1, RoleId = 3 },
                new IdentityUserRole<int>() { UserId = 2, RoleId = 2 },
                new IdentityUserRole<int>() { UserId = 2, RoleId = 3 }
                );


            //category
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Title = "پوشاک",
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                },
                new Category()
                {
                    Id = 2,
                    Title = "ابزار",
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                },
                new Category()
                {
                    Id = 3,
                    Title = "ابزار برقی",
                    ParentId = 2,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                },
                new Category()
                {
                    Id = 4,
                    Title = "ابزار غیر برقی",
                    ParentId = 2,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                },
                new Category()
                {
                    Id = 5,
                    Title = "لباس مردانه",
                    ParentId = 1,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                },
                new Category()
                {
                    Id = 6,
                    Title = "لوازم الکترونیک",
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                },
                new Category()
                {
                    Id = 7,
                    Title = "موبایل",
                    ParentId = 6,
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
                    CategoryId = 5,
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
                    Title = "پیراهن مردانه مدل یقه دار",
                    CategoryId = 5,
                    StoreId = 1,
                    Stock = 15,
                    IsConfirmed = true,
                    IsAuction = false,
                    IsEnabled = true,
                    Price = 300000,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                },
                new Product()
                {
                    Id = 3,
                    Title = "دریل مدل 2911",
                    CategoryId = 3,
                    StoreId = 1,
                    Stock = 4,
                    IsConfirmed = true,
                    IsAuction = false,
                    IsEnabled = true,
                    Price = 900000,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                },
                new Product()
                {
                    Id = 4,
                    Title = "انبردست رونیکس مدل ROX-1168",
                    CategoryId = 4,
                    StoreId = 1,
                    Stock = 7,
                    IsConfirmed = true,
                    IsAuction = false,
                    IsEnabled = true,
                    Price = 150000,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                },
                new Product()
                {
                    Id = 5,
                    Title = "موبایل شیائومی redmi note 11",
                    CategoryId = 7,
                    StoreId = 2,
                    Stock = 3,
                    IsConfirmed = true,
                    IsAuction = false,
                    IsEnabled = true,
                    Price = 9500000,
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
                },
                new Seller()
                {
                    Id = 2,
                    AppUserId = 2,
                    FirstName = "کیوان",
                    LastName = "حافظی",
                    Mobile = "09366666666",
                    Address = "تهران پونک",
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
                },
                new Buyer()
                {
                    Id = 2,
                    AppUserId = 2,
                    FirstName = "کیوان",
                    LastName = "حافظی",
                    Mobile = "09366666666",
                    Address = "تهران پونک",
                    CityId = 1,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                });


            //store
            modelBuilder.Entity<Store>().HasData(
                new Store()
                {
                    Id = 1,
                    Title = "همه چی فروشی",
                    IsClosed = false,
                    CreatedAt = DateTime.Now
                },
                new Store()
                {
                    Id = 2,
                    Title = "موبایل کیوان",
                    IsClosed = false,
                    CreatedAt = DateTime.Now
                });


            //comment
            modelBuilder.Entity<Comment>().HasData(
                new Comment()
                {
                    Id = 1,
                    Description = "راضی بودم خوب بود.",
                    Score = 4,
                    IsConfirmed = false,
                    BuyerId = 1,
                    ProductId = 1,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                },
                new Comment()
                {
                    Id = 2,
                    Description = "جنسش بی کیفیت بود.",
                    Score = 2,
                    IsConfirmed = false,
                    BuyerId = 1,
                    ProductId = 2,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                },
                new Comment()
                {
                    Id = 3,
                    Description = "قیمتش خیلی بالاست",
                    Score = 4,
                    IsConfirmed = false,
                    BuyerId = 2,
                    ProductId = 5,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                });


        }
    }
}
