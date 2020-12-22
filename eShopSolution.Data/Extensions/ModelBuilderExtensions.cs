using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Data seeding
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is Home Keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is Home Description of eShopSolution" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active,
                });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Áo nam",
                    LanguageId = "vi",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm áo thời trang nam",
                    SeoTitle = "Sản phẩm áo thời trang nam"
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Men shirt",
                    LanguageId = "en",
                    SeoAlias = "men-shirt",
                    SeoDescription = "Shirt products for men",
                    SeoTitle = "Shirt products for men"
                },
                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Áo nữ",
                    LanguageId = "vi",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm áo thời trang nữ",
                    SeoTitle = "Sản phẩm áo thời trang nữ"
                },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Women shirt",
                    LanguageId = "en",
                    SeoAlias = "women-shirt",
                    SeoDescription = "Shirt products for women",
                    SeoTitle = "Shirt products for women"
                });

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0
                });

            modelBuilder.Entity<ProductTranslation>().HasData(
                        new ProductTranslation()
                        {
                            Id = 1,
                            ProductId = 1,
                            Name = "Áo sơ mi nam trắng Việt Tiến",
                            LanguageId = "vi",
                            SeoAlias = "ao-so-mi-nam-trang-Viet-Tien",
                            SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                            SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                            Details = "Áo sơ mi nam trắng Việt Tiến",
                            Description = "Áo sơ mi nam trắng Việt Tiến"
                        },
                        new ProductTranslation()
                        {
                            Id = 2,
                            ProductId = 1,
                            Name = "Viet Tien Men T-shirt",
                            LanguageId = "en",
                            SeoAlias = "Viet-Tien-men-t-shirt",
                            SeoDescription = "Viet Tien Men T-shirt",
                            SeoTitle = "Viet Tien Men T-shirt",
                            Details = "Viet Tien Men T-shirt",
                            Description = ""
                        });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory { ProductId = 1, CategoryId = 1 }
                );

            //identity
            var roleId = new Guid("36E2E33F-7136-4652-B5B6-9873CA6310CC");
            var adminId = new Guid("E953781A-DE39-459C-A246-9FD5035478E5");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "tuanhung30121998@gmail.com",
                NormalizedEmail = "tuanhung30121998@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Hung",
                LastName = "Tran",
                Dob = new DateTime(2020, 12, 30)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<Slide>().HasData(
                new Slide() { Id = 1, Name = "Second Thumbnail Label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 1, Url = "#", Image = "/themes/images/carousel/1.png", Status = Status.Active },
                new Slide() { Id = 2, Name = "Second Thumbnail Label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 2, Url = "#", Image = "/themes/images/carousel/2.png", Status = Status.Active },
                new Slide() { Id = 3, Name = "Second Thumbnail Label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 3, Url = "#", Image = "/themes/images/carousel/3.png", Status = Status.Active },
                new Slide() { Id = 4, Name = "Second Thumbnail Label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 4, Url = "#", Image = "/themes/images/carousel/4.png", Status = Status.Active },
                new Slide() { Id = 5, Name = "Second Thumbnail Label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 5, Url = "#", Image = "/themes/images/carousel/5.png", Status = Status.Active },
                new Slide() { Id = 6, Name = "Second Thumbnail Label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 6, Url = "#", Image = "/themes/images/carousel/6.png", Status = Status.Active }
                );
        }
    }
}