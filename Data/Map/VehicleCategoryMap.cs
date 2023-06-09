﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;
using TesteBitzen.Models;

namespace TesteBitzen.Data.Map
{
    public class VehicleCategoryMap : IEntityTypeConfiguration<VehicleCategoryModel>
    {
        public void Configure(EntityTypeBuilder<VehicleCategoryModel> builder)
        {
            builder.HasKey(x => x.VehicleCategoryId);
            builder.Property(x => x.VehicleCategory).HasMaxLength(255);
            builder.Property(x => x.VehicleFuelType).HasMaxLength(255);
            builder.Property(x => x.VehicleRentCost);
        }
    }
}
