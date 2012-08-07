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
    public partial class VendorAddressMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.VendorAddress>
    {
        public VendorAddressMap()
        {
            // table
            ToTable("VendorAddress", "Purchasing");

            // keys
            HasKey(t => new { t.VendorID, t.AddressID });

            // Properties
            Property(t => t.VendorID)
                .HasColumnName("VendorID")
                .IsRequired();
            Property(t => t.AddressID)
                .HasColumnName("AddressID")
                .IsRequired();
            Property(t => t.AddressTypeID)
                .HasColumnName("AddressTypeID")
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasRequired(t => t.Address)
                .WithMany(t => t.VendorAddresses)
                .HasForeignKey(d => d.AddressID)
                .WillCascadeOnDelete(false);
            HasRequired(t => t.AddressType)
                .WithMany(t => t.VendorAddresses)
                .HasForeignKey(d => d.AddressTypeID)
                .WillCascadeOnDelete(false);
            HasRequired(t => t.Vendor)
                .WithMany(t => t.VendorAddresses)
                .HasForeignKey(d => d.VendorID)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}

