// ----------------------------------------------------------------------------
// <copyright file="Company.cs" company="SOGETI Spain">
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
    /// Represents a company.
    /// </summary>
    public class Company : BaseEntity<Company, Guid>
    {
        #region Fields

        /// <summary>
        /// Defines the employees that the company has.
        /// </summary>
        private readonly ICollection<Employee> employees = new HashSet<Employee>();

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets the employees that the company has.
        /// </summary>
        /// <value>
        /// The employees that the company has.
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
        [StringLength(50)]
        public virtual string Name
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Adds the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public virtual void Add(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException();
            }

            if (this.employees.Contains(employee))
            {
                throw new InvalidOperationException("The company already has this employee!");
            }

            this.employees.Add(employee);
            employee.Company = this;
        }

        /// <summary>
        /// Removes the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>
        ///   <c>true</c> if the employee was successfully removed from the collection; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool Remove(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException();
            }

            if (!this.employees.Contains(employee))
            {
                throw new InvalidOperationException("The company hasn't this employee!");
            }

            if (this.employees.Remove(employee))
            {
                employee.Company = null;
                return true;
            }

            return false;
        }

        #endregion Methods
    }
}