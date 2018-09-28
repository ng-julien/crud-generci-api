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

    public partial class StateProvinceConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<StateProvince>
    {
        public StateProvinceConfiguration()
            : this("Person")
        {
        }

        public StateProvinceConfiguration(string schema)
        {
            ToTable("StateProvince", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"StateProvinceID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceCode).HasColumnName(@"StateProvinceCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.CountryRegionCode).HasColumnName(@"CountryRegionCode").HasColumnType("nvarchar").IsRequired().HasMaxLength(3);
            Property(x => x.IsOnlyStateProvinceFlag).HasColumnName(@"IsOnlyStateProvinceFlag").HasColumnType("bit").IsRequired();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.TerritoryId).HasColumnName(@"TerritoryID").HasColumnType("int").IsRequired();
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.CountryRegion).WithMany(b => b.StateProvinces).HasForeignKey(c => c.CountryRegionCode).WillCascadeOnDelete(false);
            HasRequired(a => a.SalesTerritory).WithMany(b => b.StateProvinces).HasForeignKey(c => c.TerritoryId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
