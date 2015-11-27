// ----------------------------------------------------------------------------
// <copyright file="Student3Map.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.Mappings.TablePerConcreteClass
{
    using FluentNHibernate.Mapping;
    using Sogeti.NHibernateWorkshop.TablePerConcreteClass;

    /// <summary>
    /// Represents the map for the student3 entity.
    /// </summary>
    public class Student3Map : SubclassMap<Student3>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Student3Map"/> class.
        /// </summary>
        public Student3Map()
        {
            this.Table("STUDENTS_TPC");
            this.Map(e => e.EnrollmentDate, "ENROLLMENT_DATE").Not.Nullable();
        }

        #endregion Constructors
    }
}