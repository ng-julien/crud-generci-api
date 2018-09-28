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
    /// Lookup table of customer purchase reasons.
    ///</summary>
    public partial class SalesReason : IEntity<int>
    {

        ///<summary>
        /// Primary key for SalesReason records.
        ///</summary>
       public int Id { get; set; }

        ///<summary>
        /// Sales reason description.
        ///</summary>
       public string Name { get; set; }

        ///<summary>
        /// Category the sales reason belongs to.
        ///</summary>
       public string ReasonType { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
       public System.DateTime ModifiedDate { get; set; }

        public ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }

        public SalesReason()
        {
            ModifiedDate = System.DateTime.Now;
            SalesOrderHeaderSalesReasons = new List<SalesOrderHeaderSalesReason>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
