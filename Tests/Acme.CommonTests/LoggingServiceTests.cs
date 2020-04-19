using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTests
{
    [TestClass]
    public class LoggingServiceTests
    {
        [TestMethod]
        public void WriteToFileTests()
        {
            // Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "asd@sda.pl",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                Description = "sdfsdfsf",
                CurrentPrice = 6M
            };
            changedItems.Add(product);


            // Act
            LoggingService.WriteToFile(changedItems);

            // Assert

        }

    }
}
