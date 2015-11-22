// ----------------------------------------------------------------------------
// <copyright file="Gender.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop
{
    /// <summary>
    /// Defines the types of gender.
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// Represents a not specified gender.
        /// </summary>
        NotSpecified = 0,

        /// <summary>
        /// Represents the male gender.
        /// </summary>
        Male = 1,

        /// <summary>
        /// Represents the female gender.
        /// </summary>
        Female = 2
    }
}