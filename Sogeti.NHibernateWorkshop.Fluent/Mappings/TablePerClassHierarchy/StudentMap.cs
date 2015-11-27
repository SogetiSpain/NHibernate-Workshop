// ----------------------------------------------------------------------------
// <copyright file="StudentMap.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.Mappings.TablePerClassHierarchy
{
    using FluentNHibernate.Mapping;
    using Sogeti.NHibernateWorkshop.TablePerClassHierarchy;

    /// <summary>
    /// Represents the map for the student entity.
    /// </summary>
    public class StudentMap : SubclassMap<Student>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="StudentMap"/> class.
        /// </summary>
        public StudentMap()
        {
            this.DiscriminatorValue(3);
            this.Map(e => e.EnrollmentDate, "ENROLLMENT_DATE");
        }

        #endregion Constructors
    }
}