// ----------------------------------------------------------------------------
// <copyright file="Admin3Map.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.Mappings.TablePerConcreteClass
{
    using FluentNHibernate.Mapping;
    using Sogeti.NHibernateWorkshop.TablePerConcreteClass;

    /// <summary>
    /// Represents the map for the admin3 entity.
    /// </summary>
    public class Admin3Map : SubclassMap<Admin3>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Admin3Map"/> class.
        /// </summary>
        public Admin3Map()
        {
            this.Table("ADMINS_TPC");
            this.Map(e => e.AdminDate, "ADMIN_DATE").Not.Nullable();
        }

        #endregion Constructors
    }
}