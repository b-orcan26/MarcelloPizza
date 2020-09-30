using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Mapping
{
    public class UrunMapping : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Ad).HasMaxLength(120);
            builder.Property(i => i.Icindekiler).HasMaxLength(220);
         
        }
    }
}
