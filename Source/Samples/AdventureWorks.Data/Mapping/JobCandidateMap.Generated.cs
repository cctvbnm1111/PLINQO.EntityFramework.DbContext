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
    public partial class JobCandidateMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdventureWorks.Data.Entities.JobCandidate>
    {
        public JobCandidateMap()
        {
            // table
            ToTable("JobCandidate", "HumanResources");

            // keys
            HasKey(t => t.JobCandidateID);

            // Properties
            Property(t => t.JobCandidateID)
                .HasColumnName("JobCandidateID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(t => t.EmployeeID)
                .HasColumnName("EmployeeID")
                .IsOptional();
            Property(t => t.Resume)
                .HasColumnName("Resume")
                .IsOptional();
            Property(t => t.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            // Relationships
            HasOptional(t => t.Employee)
                .WithMany(t => t.JobCandidates)
                .HasForeignKey(d => d.EmployeeID)
                .WillCascadeOnDelete(false);

            InitializeMapping();
        }
    }
}

