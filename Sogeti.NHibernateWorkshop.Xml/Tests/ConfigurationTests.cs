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
    public class ConfigurationTests : BaseTestForXmlMappings
    {
        #region Methods

        /// <summary>
        /// Tests the XML mappings configuration.
        /// </summary>
        [Test]
        public void TestXMLMappingsConfiguration()
        {
            using (var transaction = this.Session.BeginTransaction())
            {
                transaction.Rollback();
            }
        }

        #endregion Methods
    }
}