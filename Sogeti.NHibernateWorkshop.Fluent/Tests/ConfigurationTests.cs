// ----------------------------------------------------------------------------
// <copyright file="ConfigurationTests.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop
{
    using NUnit.Framework;

    /// <summary>
    /// Represents the configuration tests.
    /// </summary>
    [TestFixture]
    public class ConfigurationTests : BaseTestForFluentMappings
    {
        #region Methods

        /// <summary>
        /// Tests the fluent NHibernate configuration.
        /// </summary>
        [Test]
        public void TestFluentNHibernateConfiguration()
        {
            var transaction = this.Session.BeginTransaction();
            transaction.Commit();
            transaction.Dispose();
            transaction = null;
        }

        #endregion Methods
    }
}