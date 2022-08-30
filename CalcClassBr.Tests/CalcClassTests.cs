using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcClassBr.Tests
{
    [TestClass]
    public class CalcClassTests
    {
        public TestContext TestContext { get; set; }
        [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\losti\UnitTestData.mdf;Integrated Security=True;Connect Timeout=30", "TestNumbers", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestMultiplicateMethodFromCalculator()
        {
            //Arrange
            long a = (long)TestContext.DataRow["a"];
            long b = (long)TestContext.DataRow["b"];
            long expected = (long)TestContext.DataRow["expected"];

            //Act
            var result = CalcClass.Mult(a, b);
            var reversed = CalcClass.Mult(b, a);

            //Assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected, reversed);
        }
    }
}
