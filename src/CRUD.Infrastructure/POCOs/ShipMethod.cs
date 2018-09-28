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
    /// Shipping company lookup table.
    ///</summary>
    public partial class ShipMethod : IEntity<int>
    {

        ///<summary>
        /// Primary key for ShipMethod records.
        ///</summary>
       public int Id { get; set; }

        ///<summary>
        /// Shipping company name.
        ///</summary>
       public string Name { get; set; }

        ///<summary>
        /// Minimum shipping charge.
        ///</summary>
       public decimal ShipBase { get; set; }

        ///<summary>
        /// Shipping charge per pound.
        ///</summary>
       public decimal ShipRate { get; set; }

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
       public System.Guid Rowguid { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
       public System.DateTime ModifiedDate { get; set; }

        public ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

        public ShipMethod()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
            SalesOrderHeaders = new List<SalesOrderHeader>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
