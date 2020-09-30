using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Mapping
{
    public class KategoriMapping : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Ad).HasMaxLength(100);
            builder.HasMany(i => i.Uruns).WithOne(i => i.Kategori).HasForeignKey(i => i.KategoriId);
        }
    }
}
