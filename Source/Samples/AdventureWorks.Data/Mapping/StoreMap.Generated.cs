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
    public partial class StoreMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.Store>
    {
        public StoreMap()
        {
            // table
            ToTable("Store", "Sales");

            // keys
            HasKey(t => t.CustomerID);

            // Properties
            Property(t => t.CustomerID)
                .HasColumnName("CustomerID")
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.SalesPersonID)
                .HasColumnName("SalesPersonID")
                .IsOptional();
            Property(t => t.Demographics)
                .HasColumnName("Demographics")
                .IsOptional();
            Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasRequired(t => t.Customer)
                .WithOptional(t => t.Store)
                .WillCascadeOnDelete(false);
            HasOptional(t => t.SalesPerson)
                .WithMany(t => t.Stores)
                .HasForeignKey(d => d.SalesPersonID)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}

