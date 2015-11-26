// ----------------------------------------------------------------------------
// <copyright file="BaseTestForFluentMappings.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop
{
    using NHibernate;
    using NUnit.Framework;

    /// <summary>
    /// Represents an abstract test for the Fluent mappings.
    /// </summary>
    public abstract class BaseTestForFluentMappings
    {
        #region Fields

        /// <summary>
        /// Defines the database.
        /// </summary>
        private InMemoryDBForFluentMappings database;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTestForFluentMappings"/> class.
        /// </summary>
        protected BaseTestForFluentMappings()
        {
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the session.
        /// </summary>
        /// <value>
        /// The session.
        /// </value>
        protected ISession Session
        {
            get;
            private set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Called when the test is finalized.
        /// </summary>
        [TestFixtureTearDown]
        public void OnFinalize()
        {
            if (this.database != null)
            {
                this.database.Dispose();
                this.database = null;
            }
        }

        /// <summary>
        /// Called when the test is initialized.
        /// </summary>
        [TestFixtureSetUp]
        public void OnInitialize()
        {
            this.database = new InMemoryDBForFluentMappings();
            this.Session = this.database.Session;
        }

        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// The entity identifier.
        /// </returns>
        protected object Save(ISession session, object entity)
        {
            object entityId = null;
            using (var transaction = session.BeginTransaction())
            {
                entityId = session.Save(entity);
                transaction.Commit();
            }

            return entityId;
        }

        #endregion Methods
    }
}