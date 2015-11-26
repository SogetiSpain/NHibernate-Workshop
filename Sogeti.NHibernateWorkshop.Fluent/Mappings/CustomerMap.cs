// ----------------------------------------------------------------------------
// <copyright file="CustomerMap.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop
{
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Represents the map for the customer entity.
    /// </summary>
    public class CustomerMap : ClassMap<Customer>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerMap"/> class.
        /// </summary>
        public CustomerMap()
        {
            this.Table("CUSTOMERS");

            this.Id(e => e.Id, "CUSTOMER_ID").GeneratedBy.GuidComb();
            this.Map(e => e.Name, "NAME").Length(100).Not.Nullable();

            this.HasMany<Project>(e => e.Projects)
                .Access.CamelCaseField()
                .BatchSize(25)
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("FK_PROJECTS_CUSTOMERS")
                .Inverse()
                .KeyColumn("CUSTOMER_ID")
                .LazyLoad()
                .AsSet();
        }

        #endregion Constructors
    }
}