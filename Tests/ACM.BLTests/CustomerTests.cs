using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void FullNameValidValues()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            //--Act
            string expected = "Baggins, Bilbo";
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameFirstEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };

            //--Act
            string expected = "Baggins";
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };

            //--Act
            string expected = "Bilbo";
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateValid()
        {
            //--Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.co"
            };
            var expected = true;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //--Arrange
            var customer = new Customer
            {
                EmailAddress = "fbaggins@hobbiton.co"
            };
            var expected = false;

            //--Act
            var actual = customer.Validate();

            //--Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
