using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCLab.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab.Controllers.Tests
{
    [TestClass()]
    public class HelloWorldControllerTests
    {
        [TestMethod()]
        public void TestTest()
        {
            // Arrange 
            var controller = new HelloWorldController();
            string expected = "Test id:1";

            // Act
            string actual = controller.Test(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}