// ----------------------------------------------------------------------------
// <copyright file="InstructorMap.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.Mappings.TablePerClassHierarchy
{
    using FluentNHibernate.Mapping;
    using Sogeti.NHibernateWorkshop.TablePerClassHierarchy;

    /// <summary>
    /// Represents the map for the instructor entity.
    /// </summary>
    public class InstructorMap : SubclassMap<Instructor>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="InstructorMap"/> class.
        /// </summary>
        public InstructorMap()
        {
            this.DiscriminatorValue(2);
            this.Map(e => e.HireDate, "HIRE_DATE");
        }

        #endregion Constructors
    }
}