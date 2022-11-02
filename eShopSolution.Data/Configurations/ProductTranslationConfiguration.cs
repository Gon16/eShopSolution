using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductTranslationConfiguration : IEntityTypeConfiguration<ProductTranslation>
    {
        public void Configure(EntityTypeBuilder<ProductTranslation> builder)
        {
            builder.ToTable("ProductTranslation");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Language).WithMany(x => x.ProductTranslation).HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.Product).WithMany(x => x.productTranslation).HasForeignKey(x => x.ProductId);
        }
    }
}
