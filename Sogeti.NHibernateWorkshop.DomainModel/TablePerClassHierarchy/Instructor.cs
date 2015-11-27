// ----------------------------------------------------------------------------
// <copyright file="Instructor.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.TablePerClassHierarchy
{
    using System;

    /// <summary>
    /// Represents an instructor entity.
    /// </summary>
    public class Instructor : Person
    {
        #region Properties

        /// <summary>
        /// Gets or sets the hire date.
        /// </summary>
        /// <value>
        /// The hire date.
        /// </value>
        public virtual DateTime? HireDate
        {
            get;
            set;
        }

        #endregion Properties
    }
}