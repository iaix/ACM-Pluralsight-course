using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        [TestMethod]
        public void RetreiveValid()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.co"
            };

            //--Act
            var actual = customerRepository.Retreive(1);

            //--Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
        [TestMethod]
        public void RetreiveExistingWithAddress()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.co",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                                        AddressType = 1,
            City = "NY",
            Country = "US",
            PostalCode = "1234",
            State = "NY",
            StreetLine1 = "asd",
            StreetLine2 = "asdf"
                    },
                    new Address()
                    {
                                        AddressType = 2,
                City = "NYv",
                Country = "USv",
                PostalCode = "12vv4",
                State = "NYv",
                StreetLine1 = "avvsd",
                StreetLine2 = "asdvvf"
                    }

                }
                
            };

            //--Act
            var actual = customerRepository.Retreive(1);

            //--Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);


            }
        }

    }
}
