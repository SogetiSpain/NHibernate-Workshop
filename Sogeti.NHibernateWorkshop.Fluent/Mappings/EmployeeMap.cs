// ----------------------------------------------------------------------------
// <copyright file="EmployeeMap.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop
{
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Represents the map for the employee entity.
    /// </summary>
    public class EmployeeMap : ClassMap<Employee>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeMap"/> class.
        /// </summary>
        public EmployeeMap()
        {
            this.Table("EMPLOYEES");

            this.Id(e => e.Id, "EMPLOYEE_ID").GeneratedBy.HiLo("10");

            this.Component<Address>(
                x => x.Address,
                m =>
                {
                    m.Map(x => x.AddressLine1, "ADDRESS_LINE1").Length(100).Not.Nullable();
                    m.Map(x => x.AddressLine2, "ADDRESS_LINE2").Length(100);
                    m.Map(x => x.City, "CITY").Length(50).Not.Nullable();
                    m.Map(x => x.Country, "COUNTRY").Length(50).Not.Nullable();
                    m.Map(x => x.Postcode, "ZIP_CODE").Length(5).Not.Nullable();
                });

            this.Map(e => e.DateOfBirth, "BIRTH_DATE");
            this.Map(e => e.EmailAddress, "EMAIL_ADDRESS").Length(255);
            this.Map(e => e.FirstName, "FIRST_NAME").Length(30).Not.Nullable();
            this.Map(e => e.Gender, "GENDER");
            this.Map(e => e.LastName, "LAST_NAME").Length(30);

            this.Component<PhoneBook>(
                x => x.Phones,
                m =>
                {
                    m.Component<PhoneNumber>(
                        y => y.HomeNumber,
                        n =>
                        {
                            n.Map(y => y.Number, "HOME_PHONE_NUMBER").Length(20);
                            n.Map(y => y.Extension, "HOME_PHONE_EXTENSION").Length(5);
                        });
                    m.Component<PhoneNumber>(
                        y => y.MobileNumber,
                        n =>
                        {
                            n.Map(y => y.Number, "MOBILE_PHONE_NUMBER").Length(20).Not.Nullable();
                            n.Map(y => y.Extension, "MOBILE_PHONE_EXTENSION").Length(5);
                        });
                    m.Component<PhoneNumber>(
                        y => y.WorkNumber,
                        n =>
                        {
                            n.Map(y => y.Number, "WORK_PHONE_NUMBER").Length(20).Not.Nullable();
                            n.Map(y => y.Extension, "WORK_PHONE_EXTENSION").Length(5);
                        });
                });

            this.HasMany<Project>(e => e.Projects)
                .Access.CamelCaseField()
                .Cascade.AllDeleteOrphan()
                .ForeignKeyConstraintName("FK_EMPLOYEES_PROJECTS_01")
                .KeyColumns.Add("EMPLOYEE_ID", i => i.Index("IDX_EMPPRO_EMPLOYEE_ID"))
                .Table("EMPLOYEES_PROJECTS")
                .AsSet();

            this.References<Company>(e => e.Company)
                .Column("COMPANY_ID")
                .Index("IDX_EMPLOYEES_COMPANY_ID")
                .Not.Nullable();
        }

        #endregion Constructors
    }
}