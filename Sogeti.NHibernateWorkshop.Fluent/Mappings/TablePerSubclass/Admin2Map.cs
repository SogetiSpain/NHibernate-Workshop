// ----------------------------------------------------------------------------
// <copyright file="Admin2Map.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.Mappings.TablePerSubclass
{
    using FluentNHibernate.Mapping;
    using Sogeti.NHibernateWorkshop.TablePerSubclass;

    /// <summary>
    /// Represents the map for the admin2 entity.
    /// </summary>
    public class Admin2Map : SubclassMap<Admin2>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Admin2Map"/> class.
        /// </summary>
        public Admin2Map()
        {
            this.Table("ADMINS_TPS");
            this.KeyColumn("ADMIN_ID");
            this.Map(e => e.AdminDate, "ADMIN_DATE").Not.Nullable();
        }

        #endregion Constructors
    }
}