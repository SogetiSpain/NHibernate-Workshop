// ----------------------------------------------------------------------------
// <copyright file="Project.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents a project.
    /// </summary>
    public class Project : BaseEntity<Project, Guid>
    {
        #region Fields

        /// <summary>
        /// Defines the assigned employees that the project has.
        /// </summary>
        private readonly ICollection<Employee> employees = new HashSet<Employee>();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Project"/> class.
        /// </summary>
        protected Project()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        /// <value>
        /// The customer.
        /// </value>
        public virtual Customer Customer
        {
            get;
            protected internal set;
        }

        /// <summary>
        /// Gets the employees that the project has.
        /// </summary>
        /// <value>
        /// The employees that the project has.
        /// </value>
        public virtual IEnumerable<Employee> Employees
        {
            get
            {
                return this.employees as IEnumerable<Employee>;
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required]
        [StringLength(100)]
        public virtual string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the period.
        /// </summary>
        /// <value>
        /// The period.
        /// </value>
        [Required]
        public virtual Period Period
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Creates a new project for the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <returns>
        /// The created project.
        /// </returns>
        public static Project CreateProject(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException();
            }

            var project = new Project();
            customer.Add(project);

            return project;
        }

        #endregion Methods
    }
}