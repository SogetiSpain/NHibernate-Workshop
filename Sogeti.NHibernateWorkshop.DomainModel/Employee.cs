// ----------------------------------------------------------------------------
// <copyright file="Employee.cs" company="SOGETI Spain">
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
    /// Represents an employee.
    /// </summary>
    public class Employee : BaseEntity<Employee, int>
    {
        #region Fields

        /// <summary>
        /// Defines the projects that the employee is assigned or has been assigned.
        /// </summary>
        private readonly ICollection<Project> projects = new HashSet<Project>();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        protected Employee()
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
        /// Gets or sets the company.
        /// </summary>
        /// <value>
        /// The company.
        /// </value>
        public virtual Company Company
        {
            get;
            protected internal set;
        }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        /// <value>
        /// The date of birth.
        /// </value>
        public virtual DateTime? DateOfBirth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>
        /// The email address.
        /// </value>
        [StringLength(255)]
        public virtual string EmailAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [Required]
        [StringLength(30)]
        public virtual string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        public virtual Gender Gender
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [StringLength(30)]
        public virtual string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the phones.
        /// </summary>
        /// <value>
        /// The phones.
        /// </value>
        [Required]
        public virtual PhoneBook Phones
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the projects that the employee is assigned or has been assigned.
        /// </summary>
        /// <value>
        /// The projects that the employee is assigned or has been assigned.
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
        /// Creates a new employee for the specified company.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <returns>
        /// The created employee.
        /// </returns>
        public static Employee CreateEmployee(Company company)
        {
            if (company == null)
            {
                throw new ArgumentNullException();
            }

            var employee = new Employee();
            company.Add(employee);

            return employee;
        }

        #endregion Methods
    }
}