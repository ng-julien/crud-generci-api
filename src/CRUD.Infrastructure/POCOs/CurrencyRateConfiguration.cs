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

    public partial class CurrencyRateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CurrencyRate>
    {
        public CurrencyRateConfiguration()
            : this("Sales")
        {
        }

        public CurrencyRateConfiguration(string schema)
        {
            ToTable("CurrencyRate", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"CurrencyRateID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CurrencyRateDate).HasColumnName(@"CurrencyRateDate").HasColumnType("datetime").IsRequired();
            Property(x => x.FromCurrencyCode).HasColumnName(@"FromCurrencyCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.ToCurrencyCode).HasColumnName(@"ToCurrencyCode").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.AverageRate).HasColumnName(@"AverageRate").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.EndOfDayRate).HasColumnName(@"EndOfDayRate").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").HasColumnType("datetime").IsRequired();

            HasRequired(a => a.Currency_FromCurrencyCode).WithMany(b => b.CurrencyRates_FromCurrencyCode).HasForeignKey(c => c.FromCurrencyCode).WillCascadeOnDelete(false);
            HasRequired(a => a.Currency_ToCurrencyCode).WithMany(b => b.CurrencyRates_ToCurrencyCode).HasForeignKey(c => c.ToCurrencyCode).WillCascadeOnDelete(false);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
