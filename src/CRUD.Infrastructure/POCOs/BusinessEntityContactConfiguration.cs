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

    public partial class BusinessEntityContactConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BusinessEntityContact>
    {
        public BusinessEntityContactConfiguration()
            : this("Person")
        {
        }

        public BusinessEntityContactConfiguration(string schema)
        {
            ToTable("BusinessEntityContact", schema);
            HasKey(x => new { x.BusinessEntityId, x.PersonId, x.ContactTypeId });

            Property(x => x.BusinessEntityId).HasColumnName(@"BusinessEntityID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PersonId).HasColumnName(@"PersonID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContactTypeId).HasColumnName(@"ContactTypeID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName(@"rowguid").HasColumnType("uniqueidentifier").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.BusinessEntity).WithMany(b => b.BusinessEntityContacts).HasForeignKey(c => c.BusinessEntityId).WillCascadeOnDelete(false);
            HasRequired(a => a.ContactType).WithMany(b => b.BusinessEntityContacts).HasForeignKey(c => c.ContactTypeId).WillCascadeOnDelete(false);
            HasRequired(a => a.Person).WithMany(b => b.BusinessEntityContacts).HasForeignKey(c => c.PersonId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
