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
    public partial class CustomerMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.Customer>
    {
        public CustomerMap()
        {
            // table
            ToTable("Customer", "Sales");

            // keys
            HasKey(t => t.CustomerID);

            // Properties
            Property(t => t.CustomerID)
                .HasColumnName("CustomerID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.TerritoryID)
                .HasColumnName("TerritoryID")
                .IsOptional();
            Property(t => t.AccountNumber)
                .HasColumnName("AccountNumber")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .HasMaxLength(10)
                .IsRequired();
            Property(t => t.CustomerType)
                .HasColumnName("CustomerType")
                .HasMaxLength(1)
                .IsRequired();
            Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasOptional(t => t.SalesTerritory)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.TerritoryID)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}

