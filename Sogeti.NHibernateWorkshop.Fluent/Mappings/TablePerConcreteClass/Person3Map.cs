// ----------------------------------------------------------------------------
// <copyright file="Person3Map.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.Mappings.TablePerConcreteClass
{
    using FluentNHibernate.Mapping;
    using Sogeti.NHibernateWorkshop.TablePerConcreteClass;

    /// <summary>
    /// Represents the map for the person3 entity.
    /// </summary>
    public class Person3Map : ClassMap<Person3>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Person3Map"/> class.
        /// </summary>
        public Person3Map()
        {
            this.Table("PERSONS_TPC");
            this.Id(e => e.Id, "ID").GeneratedBy.Guid();

            this.UseUnionSubclassForInheritanceMapping();

            this.Map(e => e.Name, "NAME").Length(100).Not.Nullable();
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
        }

        #endregion Constructors
    }
}