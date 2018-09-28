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

    public partial class EmployeeDepartmentHistoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmployeeDepartmentHistory>
    {
        public EmployeeDepartmentHistoryConfiguration()
            : this("HumanResources")
        {
        }

        public EmployeeDepartmentHistoryConfiguration(string schema)
        {
            ToTable("EmployeeDepartmentHistory", schema);
            HasKey(x => new { x.BusinessEntityId, x.StartDate, x.DepartmentId, x.ShiftId });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DepartmentId).HasColumnName(@"DepartmentID").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ShiftId).HasColumnName(@"ShiftID").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName(@"StartDate").HasColumnType("date").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.EndDate).HasColumnName(@"EndDate").HasColumnType("date").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.Department).WithMany(b => b.EmployeeDepartmentHistories).HasForeignKey(c => c.DepartmentId).WillCascadeOnDelete(false);
            HasRequired(a => a.Employee).WithMany(b => b.EmployeeDepartmentHistories).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false);
            HasRequired(a => a.Shift).WithMany(b => b.EmployeeDepartmentHistories).HasForeignKey(c => c.ShiftId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>