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
    /// Manufacturing work orders.
    ///</summary>
    public partial class WorkOrder : IEntity<int>
    {

        ///<summary>
        /// Primary key for WorkOrder records.
        ///</summary>
       public int Id { get; set; }

        ///<summary>
        /// Product identification number. Foreign key to Product.ProductID.
        ///</summary>
       public int ProductId { get; set; }

        ///<summary>
        /// Product quantity to build.
        ///</summary>
       public int OrderQty { get; set; }

        ///<summary>
        /// Quantity built and put in inventory.
        ///</summary>
       public int StockedQty { get; private set; }

        ///<summary>
        /// Quantity that failed inspection.
        ///</summary>
       public short ScrappedQty { get; set; }

        ///<summary>
        /// Work order start date.
        ///</summary>
       public System.DateTime StartDate { get; set; }

        ///<summary>
        /// Work order end date.
        ///</summary>
       public System.DateTime? EndDate { get; set; }

        ///<summary>
        /// Work order due date.
        ///</summary>
       public System.DateTime DueDate { get; set; }

        ///<summary>
        /// Reason for inspection failure.
        ///</summary>
       public short? ScrapReasonId { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
       public System.DateTime ModifiedDate { get; set; }

        public ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }


        public Product Product { get; set; }

        public ScrapReason ScrapReason { get; set; }

        public WorkOrder()
        {
            ModifiedDate = System.DateTime.Now;
            WorkOrderRoutings = new List<WorkOrderRouting>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
