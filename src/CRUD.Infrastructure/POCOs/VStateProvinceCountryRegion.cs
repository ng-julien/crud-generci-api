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

    public partial class VStateProvinceCountryRegion
    {
       public int StateProvinceId { get; set; }
       public string StateProvinceCode { get; set; }
       public bool IsOnlyStateProvinceFlag { get; set; }
       public string StateProvinceName { get; set; }
       public int TerritoryId { get; set; }
       public string CountryRegionCode { get; set; }
       public string CountryRegionName { get; set; }

        public VStateProvinceCountryRegion()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
