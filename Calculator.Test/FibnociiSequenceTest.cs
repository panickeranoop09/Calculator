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
    /// Summary description for FibnociiSequenceTest
    /// </summary>
    [TestClass]
    public class FibnociiSequenceTest
    {
        public FibnociiSequenceTest()
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
        public void Test_Find_Fibonacci_Sequence_At_Position_Correct_8()
        {
            //Arrange
            var expected = new List<int> { 0,1, 1, 2, 3, 5, 8,13,21 };

            //Actual
            var actual = FibonacciSequence.GetAllFibonacciNumbers(10);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Find_Fibonacii_Sequence_At_Position_Corrent_5()
        {
            //Arrange
            var expected = new List<int> { 0,1,1,2,3,5,8};

            //Actual
            var actual = FibonacciSequence.GetAllFibonacciNumbers(5);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        
        
       
    }
}
