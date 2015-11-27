// ----------------------------------------------------------------------------
// <copyright file="Student2Map.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.Mappings.TablePerSubclass
{
    using FluentNHibernate.Mapping;
    using Sogeti.NHibernateWorkshop.TablePerSubclass;

    /// <summary>
    /// Represents the map for the student2 entity.
    /// </summary>
    public class Student2Map : SubclassMap<Student2>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Student2Map"/> class.
        /// </summary>
        public Student2Map()
        {
            this.Table("STUDENTS_TPS");
            this.KeyColumn("STUDENT_ID");
            this.Map(e => e.EnrollmentDate, "ENROLLMENT_DATE").Not.Nullable();
        }

        #endregion Constructors
    }
}