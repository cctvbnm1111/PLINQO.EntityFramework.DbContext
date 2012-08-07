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
    public partial class ProductModelMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.ProductModel>
    {
        public ProductModelMap()
        {
            // table
            ToTable("ProductModel", "Production");

            // keys
            HasKey(t => t.ProductModelID);

            // Properties
            Property(t => t.ProductModelID)
                .HasColumnName("ProductModelID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.CatalogDescription)
                .HasColumnName("CatalogDescription")
                .IsOptional();
            Property(t => t.Instructions)
                .HasColumnName("Instructions")
                .IsOptional();
            Property(t => t.Rowguid)
                .HasColumnName("rowguid")
                .IsRequired();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships

            InitializeMapping();
        }
    }
}
