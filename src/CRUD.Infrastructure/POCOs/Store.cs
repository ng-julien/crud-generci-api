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
    /// Customers (resellers) of Adventure Works products.
    ///</summary>
    public partial class Store
    {

        ///<summary>
        /// Primary key. Foreign key to Customer.BusinessEntityID.
        ///</summary>
       public int BusinessEntityId { get; set; }

        ///<summary>
        /// Name of the store.
        ///</summary>
       public string Name { get; set; }

        ///<summary>
        /// ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.
        ///</summary>
       public int? SalesPersonId { get; set; }

        ///<summary>
        /// Demographic informationg about the store such as the number of employees, annual sales and store type.
        ///</summary>
       public string Demographics { get; set; }

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
       public System.Guid Rowguid { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
       public System.DateTime ModifiedDate { get; set; }

        public ICollection<Customer> Customers { get; set; }


        public BusinessEntity BusinessEntity { get; set; }

        public SalesPerson SalesPerson { get; set; }

        public Store()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Customers = new List<Customer>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
