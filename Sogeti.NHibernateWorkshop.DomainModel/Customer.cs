// ----------------------------------------------------------------------------
// <copyright file="Customer.cs" company="SOGETI Spain">
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
    /// Represents a customer.
    /// </summary>
    public class Customer : BaseEntity<Customer, Guid>
    {
        #region Fields

        /// <summary>
        /// Defines the projects that the customer has.
        /// </summary>
        private readonly ICollection<Project> projects = new HashSet<Project>();

        #endregion Fields

        #region Properties

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
        /// Gets the projects that the customer has.
        /// </summary>
        /// <value>
        /// The projects that the customer has.
        /// </value>
        public virtual IEnumerable<Project> Projects
        {
            get
            {
                return this.projects as IEnumerable<Project>;
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Adds the specified project.
        /// </summary>
        /// <param name="project">The project.</param>
        public virtual void Add(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException();
            }

            if (this.projects.Contains(project))
            {
                throw new InvalidOperationException("The customer already has this project!");
            }

            this.projects.Add(project);
            project.Customer = this;
        }

        /// <summary>
        /// Removes the specified project.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>
        ///   <c>true</c> if the project was successfully removed from the collection; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool Remove(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException();
            }

            if (!this.projects.Contains(project))
            {
                throw new InvalidOperationException("The customer hasn't this project!");
            }

            if (this.projects.Remove(project))
            {
                project.Customer = null;
                return true;
            }

            return false;
        }

        #endregion Methods
    }
}