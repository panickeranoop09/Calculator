using Calculator.core;
using Calculator.core.Repository;
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    /// <summary>
    /// Summary description for PrintNumberTest
    /// </summary>
    [TestClass]
    public class PrintNumberTest
    {
        public PrintNumberTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void PrintNumbers_For10Numbers()
        {
            //Arrange
            var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //actual
            var actual = PrintNumberSequence.Print(10);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PrintNumbers_For20Numbers()
        {
            //Arrange
            var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //actual
            var actual = PrintNumberSequence.Print(20);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
