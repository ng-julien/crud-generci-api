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
    /// Cross-reference table mapping products and product photos.
    ///</summary>
    public partial class ProductProductPhoto
    {

        ///<summary>
        /// Product identification number. Foreign key to Product.ProductID.
        ///</summary>
       public int ProductId { get; set; }

        ///<summary>
        /// Product photo identification number. Foreign key to ProductPhoto.ProductPhotoID.
        ///</summary>
       public int ProductPhotoId { get; set; }

        ///<summary>
        /// 0 = Photo is not the principal image. 1 = Photo is the principal image.
        ///</summary>
       public bool Primary { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
       public System.DateTime ModifiedDate { get; set; }


        public Product Product { get; set; }

        public ProductPhoto ProductPhoto { get; set; }

        public ProductProductPhoto()
        {
            Primary = false;
            ModifiedDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
