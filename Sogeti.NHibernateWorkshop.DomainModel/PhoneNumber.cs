// ----------------------------------------------------------------------------
// <copyright file="PhoneNumber.cs" company="SOGETI Spain">
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
    /// Represents a phone number.
    /// </summary>
    public class PhoneNumber : ValueObject<PhoneNumber>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        /// <param name="number">The number.</param>
        public PhoneNumber(string number)
            : this(number, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="extension">The extension.</param>
        public PhoneNumber(string number, string extension)
        {
            if (!this.IsValidPhone(number))
            {
                throw new ArgumentException("The specified number is not a valid phone number!");
            }

            this.Number = number;
            this.Extension = extension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber"/> class.
        /// </summary>
        protected PhoneNumber()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        [StringLength(5)]
        public virtual string Extension
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        [Required]
        [StringLength(20)]
        public virtual string Number
        {
            get;
            protected set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Determines whether the specified number is a valid phone number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>
        ///   <c>true</c> if it is valid; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsValidPhone(string number)
        {
            if (number != null)
            {
                return Regex.IsMatch(number, @"(([+]?34) ?)?(6(([0-9]{8})|([0-9]{2} [0-9]{6})|([0-9]{2} [0-9]{3} [0-9]{3}))|9(([0-9]{8})|([0-9]{2} [0-9]{6})|([1-9] [0-9]{7})|([0-9]{2} [0-9]{3} [0-9]{3})|([0-9]{2} [0-9]{2} [0-9]{2} [0-9]{2})))");
            }

            return false;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(this.Extension))
            {
                return string.Format("{0}-{1}", this.Number, this.Extension);
            }

            return this.Number;
        }

        /// <summary>
        /// Gets the attributes for equality check.
        /// </summary>
        /// <returns>
        /// A sequence of the attributes for equality check.
        /// </returns>
        protected override IEnumerable<object> GetAttributesForEqualityCheck()
        {
            return new object[] { this.Number, this.Extension };
        }

        #endregion Methods
    }
}