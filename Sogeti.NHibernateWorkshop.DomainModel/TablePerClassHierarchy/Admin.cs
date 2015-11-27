// ----------------------------------------------------------------------------
// <copyright file="Admin.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.TablePerClassHierarchy
{
    using System;

    /// <summary>
    /// Represents an admin entity.
    /// </summary>
    public class Admin : Person
    {
        #region Properties

        /// <summary>
        /// Gets or sets the admin date.
        /// </summary>
        /// <value>
        /// The admin date.
        /// </value>
        public virtual DateTime? AdminDate
        {
            get;
            set;
        }

        #endregion Properties
    }
}