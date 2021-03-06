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
    public partial class SalesTaxRateMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.SalesTaxRate>
    {
        public SalesTaxRateMap()
        {
            // table
            ToTable("SalesTaxRate", "Sales");

            // keys
            HasKey(t => t.SalesTaxRateID);

            // Properties
            Property(t => t.SalesTaxRateID)
                .HasColumnName("SalesTaxRateID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.StateProvinceID)
                .HasColumnName("StateProvinceID")
                .IsRequired();
            Property(t => t.TaxType)
                .HasColumnName("TaxType")
                .IsRequired();
            Property(t => t.TaxRate)
                .HasColumnName("TaxRate")
                .HasPrecision(10, 4)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasRequired(t => t.StateProvince)
                .WithMany(t => t.SalesTaxRates)
                .HasForeignKey(d => d.StateProvinceID)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}
