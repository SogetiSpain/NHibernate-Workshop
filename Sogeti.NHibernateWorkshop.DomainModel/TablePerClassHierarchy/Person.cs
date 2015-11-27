// ----------------------------------------------------------------------------
// <copyright file="Person.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.TablePerClassHierarchy
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents an abstract person entity.
    /// </summary>
    public abstract class Person : BaseEntity<Person, Guid>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        protected Person()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        [Required]
        public virtual Address Address
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required]
        [StringLength(50)]
        public virtual string Name
        {
            get;
            set;
        }

        #endregion Properties
    }
}