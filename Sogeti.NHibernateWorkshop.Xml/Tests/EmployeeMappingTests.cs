// ----------------------------------------------------------------------------
// <copyright file="EmployeeMappingTests.cs" company="SOGETI Spain">
//     Copyright © 2015 SOGETI Spain. All rights reserved.
//     NHibernate Workshop by Carlos Mendible & Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace Sogeti.NHibernateWorkshop.Tests
{
    using System;
    using NUnit.Framework;

    /// <summary>
    /// Represents the mapping tests for the Employee entity.
    /// </summary>
    [TestFixture]
    public class EmployeeMappingTests : BaseTestForXmlMappings
    {
        public void Test()
        {
            /*
            object carlosId = null;
            object oscarId = null;
            */

            var customer = new Customer();
            customer.Name = "Sogeti Spain, S.L.U.";
            this.Save(this.Session, customer);

            var project = Project.CreateProject(customer);
            project.Name = "Workshop de Formación: NHibernate";
            project.Period = new Period(DateTime.Today);
            this.Save(this.Session, project);

            /*
            using (var transaction = this.Session.BeginTransaction())
            {
                carlosId = this.Session.Save(
                    new Employee
                    {
                        Address = new Address("Calle Palma 15, 1ºC", null, "San Sebastián de los Reyes", "España", "28700"),
                        EmailAddress = "carlos.mendible@sogetiworkshop.com",
                        FirstName = "Carlos",
                        Gender = Gender.Male,
                        LastName = "Mendible",
                        Phones = new PhoneBook(
                            new PhoneNumber("911 112 223"),
                            new PhoneNumber("676 112 233"),
                            new PhoneNumber("+34 918 889 900", "123"))
                    });

                oscarId = this.Session.Save(
                    new Employee
                    {
                        Address = new Address("Avda. Manoteras 43, 6ºA", null, "Fuenlabrada", "España", "28940"),
                        DateOfBirth = new DateTime(1975, 1, 1),
                        EmailAddress = "oscar.fernandez@sogetiworkshop.com",
                        FirstName = "Óscar",
                        Gender = Gender.Male,
                        LastName = "Fernández",
                        Phones = new PhoneBook(
                            null,
                            new PhoneNumber("676 445 566"),
                            new PhoneNumber("+34 918 889 900", "234"))
                    });

                transaction.Commit();
            }

            this.Session.Clear();

            using (var transaction = this.Session.BeginTransaction())
            {
                var carlos = this.Session.Get<Employee>(carlosId);
                Assert.That(carlos.Address, Is.Not.Null);
                Assert.That(carlos.Address.AddressLine1, Is.EqualTo("Calle Palma 15, 1ºC"));
                Assert.That(carlos.Address.AddressLine2, Is.Null);
                Assert.That(carlos.Address.City, Is.EqualTo("San Sebastián de los Reyes"));
                Assert.That(carlos.Address.Country, Is.EqualTo("España"));
                Assert.That(carlos.Address.Postcode, Is.EqualTo("28700"));
                Assert.That(carlos.DateOfBirth, Is.Null);
                Assert.That(carlos.EmailAddress, Is.EqualTo("carlos.mendible@sogetiworkshop.com"));
                Assert.That(carlos.FirstName, Is.EqualTo("Carlos"));
                Assert.That(carlos.Gender, Is.EqualTo(Gender.Male));
                Assert.That(carlos.LastName, Is.EqualTo("Mendible"));
                Assert.That(carlos.Phones, Is.Not.Null);
                Assert.That(carlos.Phones.HomeNumber, Is.EqualTo(new PhoneNumber("911 112 223")));
                Assert.That(carlos.Phones.MobileNumber, Is.EqualTo(new PhoneNumber("676 112 233")));
                Assert.That(carlos.Phones.WorkNumber.Number, Is.EqualTo("+34 918 889 900"));
                Assert.That(carlos.Phones.WorkNumber.Extension, Is.EqualTo("123"));

                var oscar = this.Session.Get<Employee>(oscarId);
                Assert.That(oscar.Address, Is.Not.Null);
                Assert.That(oscar.Address.AddressLine1, Is.EqualTo("Avda. Manoteras 43, 6ºA"));
                Assert.That(oscar.Address.AddressLine2, Is.Null);
                Assert.That(oscar.Address.City, Is.EqualTo("Fuenlabrada"));
                Assert.That(oscar.Address.Country, Is.EqualTo("España"));
                Assert.That(oscar.Address.Postcode, Is.EqualTo("28940"));
                Assert.That(oscar.DateOfBirth, Is.EqualTo(new DateTime(1975, 1, 1)));
                Assert.That(oscar.EmailAddress, Is.EqualTo("oscar.fernandez@sogetiworkshop.com"));
                Assert.That(oscar.FirstName, Is.EqualTo("Óscar"));
                Assert.That(oscar.Gender, Is.Not.EqualTo(Gender.Female));
                Assert.That(oscar.LastName, Is.EqualTo("Fernández"));
                Assert.That(oscar.Phones, Is.Not.Null);
                Assert.That(
                    oscar.Phones,
                    Is.EqualTo(
                        new PhoneBook(
                            null,
                            new PhoneNumber("676 445 566"),
                            new PhoneNumber("+34 918 889 900", "234"))));

                transaction.Commit();
            }
            */
        }
    }
}