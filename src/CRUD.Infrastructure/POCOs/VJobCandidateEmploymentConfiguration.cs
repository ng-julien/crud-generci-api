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

    public partial class VJobCandidateEmploymentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VJobCandidateEmployment>
    {
        public VJobCandidateEmploymentConfiguration()
            : this("HumanResources")
        {
        }

        public VJobCandidateEmploymentConfiguration(string schema)
        {
            ToTable("vJobCandidateEmployment", schema);
            HasKey(x => x.JobCandidateId);

            Property(x => x.JobCandidateId).HasColumnName(@"JobCandidateID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Emp46StartDate).HasColumnName(@"Emp.StartDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Emp46EndDate).HasColumnName(@"Emp.EndDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Emp46OrgName).HasColumnName(@"Emp.OrgName").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Emp46JobTitle).HasColumnName(@"Emp.JobTitle").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Emp46Responsibility).HasColumnName(@"Emp.Responsibility").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Emp46FunctionCategory).HasColumnName(@"Emp.FunctionCategory").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Emp46IndustryCategory).HasColumnName(@"Emp.IndustryCategory").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Emp46Loc46CountryRegion).HasColumnName(@"Emp.Loc.CountryRegion").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Emp46Loc46State).HasColumnName(@"Emp.Loc.State").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Emp46Loc46City).HasColumnName(@"Emp.Loc.City").HasColumnType("nvarchar(max)").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
