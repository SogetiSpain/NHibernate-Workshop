// ----------------------------------------------------------------------------
// <copyright file="PhoneBook.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a phone book.
    /// </summary>
    public class PhoneBook : ValueObject<PhoneBook>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneBook" /> class.
        /// </summary>
        /// <param name="homeNumber">The home number.</param>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <param name="workNumber">The work number.</param>
        public PhoneBook(
            PhoneNumber homeNumber,
            PhoneNumber mobileNumber,
            PhoneNumber workNumber)
        {
            this.HomeNumber = homeNumber;
            this.MobileNumber = mobileNumber;
            this.WorkNumber = workNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneBook"/> class.
        /// </summary>
        protected PhoneBook()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the home number.
        /// </summary>
        /// <value>
        /// The home number.
        /// </value>
        public virtual PhoneNumber HomeNumber
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets the mobile number.
        /// </summary>
        /// <value>
        /// The mobile number.
        /// </value>
        public virtual PhoneNumber MobileNumber
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets the work number.
        /// </summary>
        /// <value>
        /// The work number.
        /// </value>
        public virtual PhoneNumber WorkNumber
        {
            get;
            protected set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format(
                "Home:{0};Mobile:{1};Work:{2}",
                this.HomeNumber,
                this.MobileNumber,
                this.WorkNumber);
        }

        /// <summary>
        /// Gets the attributes for equality check.
        /// </summary>
        /// <returns>
        /// A sequence of the attributes for equality check.
        /// </returns>
        protected override IEnumerable<object> GetAttributesForEqualityCheck()
        {
            return new object[] { this.HomeNumber, this.MobileNumber, this.WorkNumber };
        }

        #endregion Methods
    }
}