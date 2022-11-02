using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class CategoryTranslationConfiguration : IEntityTypeConfiguration<CategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoryTranslation> builder)
        {
            builder.ToTable("CategoryTranslation");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Language).WithMany(x => x.CategoryTranslation).HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.Category).WithMany(x => x.CategoryTranslation).HasForeignKey(x => x.CategoryId);
        }
    }
}
