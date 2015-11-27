// ----------------------------------------------------------------------------
// <copyright file="Student2.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.TablePerSubclass
{
    using System;

    /// <summary>
    /// Represents an student entity.
    /// </summary>
    public class Student2 : Person2
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
