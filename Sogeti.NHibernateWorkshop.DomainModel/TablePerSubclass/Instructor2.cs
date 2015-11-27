// ----------------------------------------------------------------------------
// <copyright file="Instructor2.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.TablePerSubclass
{
    using System;

    /// <summary>
    /// Represents an instructor entity.
    /// </summary>
    public class Instructor2 : Person2
    {
        #region Properties

        /// <summary>
        /// Gets or sets the hire date.
        /// </summary>
        /// <value>
        /// The hire date.
        /// </value>
        public virtual DateTime HireDate
        {
            get;
            set;
        }

        #endregion Properties
    }
}