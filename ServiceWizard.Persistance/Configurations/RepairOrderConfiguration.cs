using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceWizard.Domain.Entities;

namespace ServiceWizard.Persistance.Configurations
{
    public class RepairOrderConfiguration : IEntityTypeConfiguration<RepairOrder>
    {
        public void Configure(EntityTypeBuilder<RepairOrder> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.CreatedBy).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Created).IsRequired();
            builder.Property(e => e.LastModifiedBy).HasMaxLength(50);
            builder.Property(e => e.LastModified);
            builder.Property(e => e.StatusId).IsRequired();
            builder.Property(e => e.InactivatedBy).HasMaxLength(50);
            builder.Property(e => e.Inactivated);
            builder.Property(e => e.DescriptionClient).HasMaxLength(500);
            builder.Property(e => e.CostEstimate).HasPrecision(18, 2);
            builder.Property(e => e.CostFinal).HasPrecision(18, 2);
            builder.Property(e => e.DeviceId).IsRequired();
            builder.Property(e => e.RepairTypeId).IsRequired();
            builder.Property(e => e.Notes).HasMaxLength(500);
            builder.HasOne(e => e.Device).WithMany(e => e.RepairOrders).HasForeignKey(e => e.DeviceId);
            builder.HasOne(e => e.RepairType).WithMany(e => e.RepairOrders).HasForeignKey(e => e.RepairTypeId);
        }
    }
}
