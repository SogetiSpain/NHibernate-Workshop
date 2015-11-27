// ----------------------------------------------------------------------------
// <copyright file="Instructor2Map.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.Mappings.TablePerSubclass
{
    using FluentNHibernate.Mapping;
    using Sogeti.NHibernateWorkshop.TablePerSubclass;

    /// <summary>
    /// Represents the map for the instructor2 entity.
    /// </summary>
    public class Instructor2Map : SubclassMap<Instructor2>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Instructor2Map"/> class.
        /// </summary>
        public Instructor2Map()
        {
            this.Table("INSTRUCTORS_TPS");
            this.KeyColumn("INSTRUCTOR_ID");
            this.Map(e => e.HireDate, "HIRE_DATE").Not.Nullable();
        }

        #endregion Constructors
    }
}