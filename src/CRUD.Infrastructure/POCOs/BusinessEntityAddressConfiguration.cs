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

    public partial class BusinessEntityAddressConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BusinessEntityAddress>
    {
        public BusinessEntityAddressConfiguration()
            : this("Person")
        {
        }

        public BusinessEntityAddressConfiguration(string schema)
        {
            ToTable("BusinessEntityAddress", schema);
            HasKey(x => new { x.BusinessEntityId, x.AddressId, x.AddressTypeId });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AddressId).HasColumnName(@"AddressID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AddressTypeId).HasColumnName(@"AddressTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.Address).WithMany(b => b.BusinessEntityAddresses).HasForeignKey(c => c.AddressId).WillCascadeOnDelete(false);
            HasRequired(a => a.AddressType).WithMany(b => b.BusinessEntityAddresses).HasForeignKey(c => c.AddressTypeId).WillCascadeOnDelete(false);
            HasRequired(a => a.BusinessEntity).WithMany(b => b.BusinessEntityAddresses).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
