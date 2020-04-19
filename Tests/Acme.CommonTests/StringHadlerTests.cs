using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTests
{
    [TestClass]
    public class StringHadlerTests
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            // Act
            var actual = StringHandler.InsertSpaces(source);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            // Act
            var actual = StringHandler.InsertSpaces(source);

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
