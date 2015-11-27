// ----------------------------------------------------------------------------
// <copyright file="AdminMap.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.Mappings.TablePerClassHierarchy
{
    using FluentNHibernate.Mapping;
    using Sogeti.NHibernateWorkshop.TablePerClassHierarchy;

    /// <summary>
    /// Represents the map for the admin entity.
    /// </summary>
    public class AdminMap : SubclassMap<Admin>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminMap"/> class.
        /// </summary>
        public AdminMap()
        {
            this.DiscriminatorValue(1);
            this.Map(e => e.AdminDate, "ADMIN_DATE");
        }

        #endregion Constructors
    }
}