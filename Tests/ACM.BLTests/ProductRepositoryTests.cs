using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;


namespace ACM.BLTests
{
    [TestClass]
    public class ProductRepositoryTests
    {
        [TestMethod]
        public void SaveTestValid()
        {
            //--Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(1)
            {
                CurrentPrice = 18M,
                ProductName = "cokolwiek",
                HasChanges = true
            };
            //--Act
            var actual = productRepository.Save(updatedProduct);

            //--Assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //--Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductName = "cokolwiek",
                HasChanges = true
            };
            //--Act
            var actual = productRepository.Save(updatedProduct);

            //--Assert
            Assert.AreEqual(false, actual);
        }
    }
}
