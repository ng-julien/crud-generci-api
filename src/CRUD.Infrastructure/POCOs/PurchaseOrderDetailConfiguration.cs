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

    public partial class PurchaseOrderDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PurchaseOrderDetail>
    {
        public PurchaseOrderDetailConfiguration()
            : this("Purchasing")
        {
        }

        public PurchaseOrderDetailConfiguration(string schema)
        {
            ToTable("PurchaseOrderDetail", schema);
            HasKey(x => new { x.PurchaseOrderId, x.Id });

            Property(x => x.PurchaseOrderId).HasColumnName(@"PurchaseOrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Id).HasColumnName(@"PurchaseOrderDetailID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DueDate).HasColumnName(@"DueDate").HasColumnType("datetime").IsRequired();
            Property(x => x.OrderQty).HasColumnName(@"OrderQty").HasColumnType("smallint").IsRequired();
            Property(x => x.ProductId).HasColumnName(@"ProductID").HasColumnType("int").IsRequired();
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.LineTotal).HasColumnName(@"LineTotal").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.ReceivedQty).HasColumnName(@"ReceivedQty").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.RejectedQty).HasColumnName(@"RejectedQty").HasColumnType("decimal").IsRequired().HasPrecision(8,2);
            Property(x => x.StockedQty).HasColumnName(@"StockedQty").HasColumnType("decimal").IsRequired().HasPrecision(9,2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.Product).WithMany(b => b.PurchaseOrderDetails).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false);
            HasRequired(a => a.PurchaseOrderHeader).WithMany(b => b.PurchaseOrderDetails).HasForeignKey(c => c.PurchaseOrderId).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
