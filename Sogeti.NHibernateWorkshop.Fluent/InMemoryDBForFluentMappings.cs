// ----------------------------------------------------------------------------
// <copyright file="InMemoryDBForFluentMappings.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate;
    using NHibernate.Cfg;
    using NHibernate.Dialect;
    using NHibernate.Driver;
    using NHibernate.Tool.hbm2ddl;

    /// <summary>
    /// Represents an in memory database for the Fluent mappings.
    /// </summary>
    public class InMemoryDBForFluentMappings : IDisposable
    {
        #region Fields

        /// <summary>
        /// Defines the NHibernate configuration.
        /// </summary>
        private readonly Configuration config;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryDBForFluentMappings"/> class.
        /// </summary>
        public InMemoryDBForFluentMappings()
        {
            this.config = Fluently.Configure()
                .Database(
                    SQLiteConfiguration.Standard
                    .Dialect<SQLiteDialect>()
                    .Driver<SQLite20Driver>()
                    .InMemory()
                    .ShowSql())
                .Mappings(
                    m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .ExposeConfiguration(
                    x =>
                    {
                        x.SetProperty(NHibernate.Cfg.Environment.QuerySubstitutions, "false=0;true=1");
                        x.SetProperty(NHibernate.Cfg.Environment.ReleaseConnections, "on_close");
                    })
                .BuildConfiguration();

            this.InitializeSession();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the NHibernate session.
        /// </summary>
        /// <value>
        /// The NHibernate session.
        /// </value>
        public ISession Session
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets the NHibernate session factory.
        /// </summary>
        /// <value>
        /// The NHibernate session factory.
        /// </value>
        public ISessionFactory SessionFactory
        {
            get;
            protected set;
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        public virtual void Dispose()
        {
            if (this.Session != null)
            {
                this.Session.Dispose();
                this.Session = null;
            }

            if (this.SessionFactory != null)
            {
                this.SessionFactory.Dispose();
                this.SessionFactory = null;
            }
        }

        /// <summary>
        /// Initializes the NHibernate session.
        /// </summary>
        protected virtual void InitializeSession()
        {
            this.SessionFactory = this.config.BuildSessionFactory();
            this.Session = this.SessionFactory.OpenSession();

            var schemaExport = new SchemaExport(this.config);
            schemaExport.Execute(true, true, false, this.Session.Connection, TextWriter.Null);
        }

        #endregion Methods
    }
}