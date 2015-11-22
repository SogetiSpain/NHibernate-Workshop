// ----------------------------------------------------------------------------
// <copyright file="Address.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Represents an address.
    /// </summary>
    public class Address : ValueObject<Address>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="addressLine1">The address line1.</param>
        /// <param name="addressLine2">The address line2.</param>
        /// <param name="city">The city.</param>
        /// <param name="country">The country.</param>
        /// <param name="postcode">The postcode.</param>
        public Address(
            string addressLine1,
            string addressLine2,
            string city,
            string country,
            string postcode)
        {
            if (!this.IsValidPostcode(postcode))
            {
                throw new ArgumentException("The specified postcode is not valid!");
            }

            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.Country = country;
            this.Postcode = postcode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        protected Address()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the address line1.
        /// </summary>
        /// <value>
        /// The address line1.
        /// </value>
        [Required]
        [StringLength(100)]
        public virtual string AddressLine1
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets the address line2.
        /// </summary>
        /// <value>
        /// The address line2.
        /// </value>
        [StringLength(100)]
        public virtual string AddressLine2
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [Required]
        [StringLength(50)]
        public virtual string City
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        [Required]
        [StringLength(50)]
        public virtual string Country
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets the postcode.
        /// </summary>
        /// <value>
        /// The postcode.
        /// </value>
        [Required]
        [StringLength(5, MinimumLength = 5)]
        public virtual string Postcode
        {
            get;
            protected set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified postcode is valid.
        /// </summary>
        /// <param name="postcode">The postcode.</param>
        /// <returns>
        ///   <c>true</c> if it is a valid postcode; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsValidPostcode(string postcode)
        {
            if (postcode != null)
            {
                return Regex.IsMatch(postcode, @"^\d{5}$");
            }

            return false;
        }

        /// <summary>
        /// Gets the attributes for equality check.
        /// </summary>
        /// <returns>
        /// A sequence of the attributes for equality check.
        /// </returns>
        protected override IEnumerable<object> GetAttributesForEqualityCheck()
        {
            return new object[]
            {
                this.AddressLine1,
                this.AddressLine2,
                this.City,
                this.Country,
                this.Postcode
            };
        }

        #endregion Methods
    }
}