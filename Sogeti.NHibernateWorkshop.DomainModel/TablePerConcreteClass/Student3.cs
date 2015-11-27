// ----------------------------------------------------------------------------
// <copyright file="Student3.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.TablePerConcreteClass
{
    using System;

    /// <summary>
    /// Represents an student entity.
    /// </summary>
    public class Student3 : Person3
    {
        #region Properties

        /// <summary>
        /// Gets or sets the enrollment date.
        /// </summary>
        /// <value>
        /// The enrollment date.
        /// </value>
        public virtual DateTime EnrollmentDate
        {
            get;
            set;
        }

        #endregion Properties
    }
}