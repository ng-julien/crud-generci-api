// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace CRUD.Infrastructure.POCOs
{
    using System;
    using System.Collections.Generic;

    public partial class VJobCandidateEducationConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VJobCandidateEducation>
    {
        public VJobCandidateEducationConfiguration()
            : this("HumanResources")
        {
        }

        public VJobCandidateEducationConfiguration(string schema)
        {
            ToTable("vJobCandidateEducation", schema);
            HasKey(x => x.JobCandidateId);

            Property(x => x.JobCandidateId).HasColumnName(@"JobCandidateID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Edu46Level).HasColumnName(@"Edu.Level").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Edu46StartDate).HasColumnName(@"Edu.StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Edu46EndDate).HasColumnName(@"Edu.EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Edu46Degree).HasColumnName(@"Edu.Degree").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Edu46Major).HasColumnName(@"Edu.Major").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Edu46Minor).HasColumnName(@"Edu.Minor").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Edu46Gpa).HasColumnName(@"Edu.GPA").HasColumnType("nvarchar").IsOptional().HasMaxLength(5);
            Property(x => x.Edu46GpaScale).HasColumnName(@"Edu.GPAScale").HasColumnType("nvarchar").IsOptional().HasMaxLength(5);
            Property(x => x.Edu46School).HasColumnName(@"Edu.School").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Edu46Loc46CountryRegion).HasColumnName(@"Edu.Loc.CountryRegion").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Edu46Loc46State).HasColumnName(@"Edu.Loc.State").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Edu46Loc46City).HasColumnName(@"Edu.Loc.City").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
