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

    ///<summary>
    /// Cross-reference table mapping products to special offer discounts.
    ///</summary>
    public partial class SpecialOfferProduct
    {

        ///<summary>
        /// Primary key for SpecialOfferProduct records.
        ///</summary>
       public int SpecialOfferId { get; set; }

        ///<summary>
        /// Product identification number. Foreign key to Product.ProductID.
        ///</summary>
       public int ProductId { get; set; }

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
       public System.Guid Rowguid { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
       public System.DateTime ModifiedDate { get; set; }

        public ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }


        public Product Product { get; set; }

        public SpecialOffer SpecialOffer { get; set; }

        public SpecialOfferProduct()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesOrderDetails = new List<SalesOrderDetail>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
