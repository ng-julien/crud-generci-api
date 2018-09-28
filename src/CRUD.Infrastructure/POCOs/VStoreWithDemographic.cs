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

    public partial class VStoreWithDemographic
    {
       public int BusinessEntityId { get; set; }
       public string Name { get; set; }
       public decimal? AnnualSales { get; set; }
       public decimal? AnnualRevenue { get; set; }
       public string BankName { get; set; }
       public string BusinessType { get; set; }
       public int? YearOpened { get; set; }
       public string Specialty { get; set; }
       public int? SquareFeet { get; set; }
       public string Brands { get; set; }
       public string Internet { get; set; }
       public int? NumberEmployees { get; set; }

        public VStoreWithDemographic()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
