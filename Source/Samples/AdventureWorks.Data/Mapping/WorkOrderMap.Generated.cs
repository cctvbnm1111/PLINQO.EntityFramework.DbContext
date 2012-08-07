﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks.Data.Mapping
{
    public partial class WorkOrderMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.WorkOrder>
    {
        public WorkOrderMap()
        {
            // table
            ToTable("WorkOrder", "Production");

            // keys
            HasKey(t => t.WorkOrderID);

            // Properties
            Property(t => t.WorkOrderID)
                .HasColumnName("WorkOrderID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.ProductID)
                .HasColumnName("ProductID")
                .IsRequired();
            Property(t => t.OrderQty)
                .HasColumnName("OrderQty")
                .IsRequired();
            Property(t => t.StockedQty)
                .HasColumnName("StockedQty")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .IsRequired();
            Property(t => t.ScrappedQty)
                .HasColumnName("ScrappedQty")
                .IsRequired();
            Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .IsRequired();
            Property(t => t.EndDate)
                .HasColumnName("EndDate")
                .IsOptional();
            Property(t => t.DueDate)
                .HasColumnName("DueDate")
                .IsRequired();
            Property(t => t.ScrapReasonID)
                .HasColumnName("ScrapReasonID")
                .IsOptional();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasRequired(t => t.Product)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.ProductID)
                .WillCascadeOnDelete(false);
            HasOptional(t => t.ScrapReason)
                .WithMany(t => t.WorkOrders)
                .HasForeignKey(d => d.ScrapReasonID)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}

