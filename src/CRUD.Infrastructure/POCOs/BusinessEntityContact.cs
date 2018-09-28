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
    /// Cross-reference table mapping stores, vendors, and employees to people
    ///</summary>
    public partial class BusinessEntityContact
    {

        ///<summary>
        /// Primary key. Foreign key to BusinessEntity.BusinessEntityID.
        ///</summary>
       public int BusinessEntityId { get; set; }

        ///<summary>
        /// Primary key. Foreign key to Person.BusinessEntityID.
        ///</summary>
       public int PersonId { get; set; }

        ///<summary>
        /// Primary key.  Foreign key to ContactType.ContactTypeID.
        ///</summary>
       public int ContactTypeId { get; set; }

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
       public System.Guid Rowguid { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
       public System.DateTime ModifiedDate { get; set; }


        public BusinessEntity BusinessEntity { get; set; }

        public ContactType ContactType { get; set; }

        public Person Person { get; set; }

        public BusinessEntityContact()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>