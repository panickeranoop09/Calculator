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
    /// Summary description for OddNumberTest
    /// </summary>
    [TestClass]
    public class OddNumberTest
    {
        public OddNumberTest()
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
        public void CheckOddNumberTest_For10Numbers()
        {
            //Arrange
            var expected = new List<int> { 1, 3, 5, 7, 9 };

            //actual
            var actual = OddNumberSequence.Check(10);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckOddNumberTest_For20Numbers()
        {
            //Arrange
            var expected = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            //Actual
            var actual = OddNumberSequence.Check(20);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
