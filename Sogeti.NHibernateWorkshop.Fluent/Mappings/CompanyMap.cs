// ----------------------------------------------------------------------------
// <copyright file="CompanyMap.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop
{
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Represents the map for the company entity.
    /// </summary>
    public class CompanyMap : ClassMap<Company>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyMap"/> class.
        /// </summary>
        public CompanyMap()
        {
            this.Table("COMPANIES");

            this.Id(e => e.Id, "COMPANY_ID").GeneratedBy.GuidComb();
            this.Map(e => e.Name, "NAME").Length(50).Not.Nullable();

            this.HasMany<Employee>(e => e.Employees)
                .Access.CamelCaseField()
                .BatchSize(25)
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("FK_EMPLOYEES_COMPANIES")
                .Inverse()
                .KeyColumn("COMPANY_ID")
                .LazyLoad()
                .AsSet();
        }

        #endregion Constructors
    }
}