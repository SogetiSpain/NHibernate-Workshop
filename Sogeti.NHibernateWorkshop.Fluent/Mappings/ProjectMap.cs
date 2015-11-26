// ----------------------------------------------------------------------------
// <copyright file="ProjectMap.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop
{
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Represents the map for the project entity.
    /// </summary>
    public class ProjectMap : ClassMap<Project>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMap"/> class.
        /// </summary>
        public ProjectMap()
        {
            this.Table("PROJECTS");

            this.Id(e => e.Id, "PROJECT_ID").GeneratedBy.Guid();
            this.Map(e => e.Name, "NAME").Length(100).Not.Nullable();

            this.Component<Period>(
                x => x.Period,
                m =>
                {
                    m.Map(x => x.StartDate, "START_DATE").Not.Nullable();
                    m.Map(x => x.EndDate, "END_DATE");
                });

            this.HasMany<Employee>(e => e.Employees)
                .Access.CamelCaseField()
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("FK_EMPLOYEES_PROJECTS_02")
                .KeyColumns.Add("PROJECT_ID", i => i.Index("IDX_EMPPRO_PROJECT_ID"))
                .Table("EMPLOYEES_PROJECTS")
                .AsSet();

            this.References<Customer>(e => e.Customer)
                .Column("CUSTOMER_ID")
                .Not.Nullable();
        }

        #endregion Constructors
    }
}