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

    public partial class EmployeePayHistoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmployeePayHistory>
    {
        public EmployeePayHistoryConfiguration()
            : this("HumanResources")
        {
        }

        public EmployeePayHistoryConfiguration(string schema)
        {
            ToTable("EmployeePayHistory", schema);
            HasKey(x => new { x.BusinessEntityId, x.RateChangeDate });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RateChangeDate).HasColumnName(@"RateChangeDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rate).HasColumnName(@"Rate").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.PayFrequency).HasColumnName(@"PayFrequency").HasColumnType("tinyint").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.Employee).WithMany(b => b.EmployeePayHistories).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
