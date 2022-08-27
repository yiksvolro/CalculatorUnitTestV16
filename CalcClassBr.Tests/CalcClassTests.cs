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

            //Assert
            Assert.AreEqual(expected, result);
        }
        //[TestMethod]
        //public void MultiplicateNegative5AndPositive3ReturnsNegative15()
        //{
        //    //Arrange
        //    long a = -5;
        //    long b = 3;
        //    long expected = -15;

        //    //Act
        //    var result = CalcClass.Mult(a,b);

        //    //Assert
        //    Assert.AreEqual(expected, result);
        //}
        //[TestMethod]
        //public void MultiplicateNegative5AndNegative8Returns40()
        //{
        //    //Arrange
        //    long a = -5;
        //    long b = -8;
        //    long expected = 40;

        //    //Act
        //    var result = CalcClass.Mult(a, b);

        //    //Assert
        //    Assert.AreEqual(expected, result);
        //}
        //[TestMethod]
        //public void MultiplicateToZero()
        //{
        //    //Arrange
        //    long a = 0;
        //    long b = 1;
        //    long expected = 0;

        //    //Act
        //    var result = CalcClass.Mult(a, b);

        //    //Assert
        //    Assert.AreEqual(expected, result);
        //}
    }
}
