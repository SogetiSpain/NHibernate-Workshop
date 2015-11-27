// ----------------------------------------------------------------------------
// <copyright file="PersonMap.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.Mappings.TablePerClassHierarchy
{
    using FluentNHibernate.Mapping;
    using Sogeti.NHibernateWorkshop.TablePerClassHierarchy;

    /// <summary>
    /// Represents the map for the person entity.
    /// </summary>
    public class PersonMap : ClassMap<Person>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonMap"/> class.
        /// </summary>
        public PersonMap()
        {
            this.Table("PERSONS");
            this.Id(e => e.Id, "PERSON_ID").GeneratedBy.Guid();

            this.DiscriminateSubClassesOnColumn("PERSON_TYPE").Not.Nullable();

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