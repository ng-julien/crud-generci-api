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
    /// Sales representative current information.
    ///</summary>
    public partial class SalesPerson
    {

        ///<summary>
        /// Primary key for SalesPerson records. Foreign key to Employee.BusinessEntityID
        ///</summary>
       public int BusinessEntityId { get; set; }

        ///<summary>
        /// Territory currently assigned to. Foreign key to SalesTerritory.SalesTerritoryID.
        ///</summary>
       public int? TerritoryId { get; set; }

        ///<summary>
        /// Projected yearly sales.
        ///</summary>
       public decimal? SalesQuota { get; set; }

        ///<summary>
        /// Bonus due if quota is met.
        ///</summary>
       public decimal Bonus { get; set; }

        ///<summary>
        /// Commision percent received per sale.
        ///</summary>
       public decimal CommissionPct { get; set; }

        ///<summary>
        /// Sales total year to date.
        ///</summary>
       public decimal SalesYtd { get; set; }

        ///<summary>
        /// Sales total of previous year.
        ///</summary>
       public decimal SalesLastYear { get; set; }

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
       public System.Guid Rowguid { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
       public System.DateTime ModifiedDate { get; set; }

        public ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        public ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        public ICollection<Store> Stores { get; set; }


        public Employee Employee { get; set; }

        public SalesTerritory SalesTerritory { get; set; }

        public SalesPerson()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            SalesOrderHeaders = new List<SalesOrderHeader>();
            SalesPersonQuotaHistories = new List<SalesPersonQuotaHistory>();
            SalesTerritoryHistories = new List<SalesTerritoryHistory>();
            Stores = new List<Store>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
