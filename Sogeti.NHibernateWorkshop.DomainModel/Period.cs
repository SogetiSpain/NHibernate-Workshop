// ----------------------------------------------------------------------------
// <copyright file="Period.cs" company="SOGETI Spain">
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
    /// Represents a period.
    /// </summary>
    public class Period : ValueObject<Period>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Period"/> class.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        public Period(DateTime startDate)
            : this(startDate, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Period"/> class.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        public Period(DateTime startDate, DateTime? endDate)
        {
            if (!this.IsValidPeriod(startDate, endDate))
            {
                throw new ArgumentException("The specified period is not valid!");
            }

            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Period"/> class.
        /// </summary>
        protected Period()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public virtual DateTime? EndDate
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        [Required]
        public virtual DateTime StartDate
        {
            get;
            protected set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified period is valid.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>
        ///   <c>true</c> if it is a valid period; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsValidPeriod(DateTime startDate, DateTime? endDate)
        {
            if (endDate.HasValue && (endDate.Value > startDate))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the attributes for equality check.
        /// </summary>
        /// <returns>
        /// A sequence of the attributes for equality check.
        /// </returns>
        protected override IEnumerable<object> GetAttributesForEqualityCheck()
        {
            return new object[] { this.StartDate, this.EndDate };
        }

        #endregion Methods
    }
}