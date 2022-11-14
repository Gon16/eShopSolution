using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extentions
{
  public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "HomeKeywork", Value = "This is keywork page of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description page of eShopSolution" }
                );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    Sort = 1,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    Sort = 2,
                    Status = Status.Active,
                });
            modelBuilder.Entity<CategoryTranslation>().HasData(
                      new CategoryTranslation()
                      {
                          Id=1,
                          CategoryId = 1,
                          Name = "Áo nam",
                          LanguageId = "vi-VN",
                          SeoAlias = "ao-nam",
                          SeoDescription = "Sản phẩm áo nam",
                          SeoTitle = "Sản phẩm áo nam"
                      },
                       new CategoryTranslation()
                       {
                           Id =2,
                           CategoryId = 1,
                           Name = "Men shirt",
                           LanguageId = "en-US",
                           SeoAlias = "men-shirt",
                           SeoDescription = "the shirt for men",
                           SeoTitle = "the shirt for men"
                       },
                        new CategoryTranslation()
                        {
                            Id =3,
                            CategoryId = 2,
                            Name = "Áo nữ",
                            LanguageId = "vi-VN",
                            SeoAlias = "ao-nu",
                            SeoDescription = "Sản phẩm áo nữ",
                            SeoTitle = "Sản phẩm áo nữ"
                        },
                        new CategoryTranslation()
                        {
                            Id =4,
                            CategoryId = 2,
                            Name = "Women shirt",
                            LanguageId = "en-US",
                            SeoAlias = "women-shirt",
                            SeoDescription = "the shirt for women",
                            SeoTitle = "the shirt for women"
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
                                    Id =1,
                                    Name = "Áo sơ mi nam",
                                    LanguageId = "vi-VN",
                                    SeoAlias = "ao-so-mi-nam",
                                    SeoDescription = "Áo sơ mi nam",
                                    SeoTitle = "Áo sơ mi nam",
                                    Details = "Áo sơ mi nam",
                                    Description = "Áo sơ mi nam"
                                },
                        new ProductTranslation()
                        {
                            Id = 2,
                            Name = "Men T-shirt",
                            LanguageId = "en-US",
                            SeoAlias = "men-tshirt",
                            SeoDescription = "the shirt for men",
                            SeoTitle = "the shirt for men",
                            Details = "Description of product",
                            Description = "T-shirt"
                        });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 });

        }
    }
}
