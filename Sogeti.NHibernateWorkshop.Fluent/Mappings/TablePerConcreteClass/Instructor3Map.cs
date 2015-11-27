// ----------------------------------------------------------------------------
// <copyright file="Instructor3Map.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.Mappings.TablePerConcreteClass
{
    using FluentNHibernate.Mapping;
    using Sogeti.NHibernateWorkshop.TablePerConcreteClass;

    /// <summary>
    /// Represents the map for the instructor3 entity.
    /// </summary>
    public class Instructor3Map : SubclassMap<Instructor3>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Instructor3Map"/> class.
        /// </summary>
        public Instructor3Map()
        {
            this.Table("INSTRUCTORS_TPC");
            this.Map(e => e.HireDate, "HIRE_DATE").Not.Nullable();
        }

        #endregion Constructors
    }
}