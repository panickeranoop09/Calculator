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
    /// Summary description for FizzBuzzTest
    /// </summary>
    [TestClass]
    public class FizzBuzzTest
    {
        public FizzBuzzTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private static void AssertThat(string expected, int start, int end)
        {
            Assert.AreEqual(expected, FizzBuzzSequence.GenerateDisplayString(start, end));
        }
        private static void AssertContainsC(int start, int end)
        {
            AssertContains(start,end, "C");
        }
        private static void AssertContainsE(int start, int end)
        {
            AssertContains(start, end, "E");
        }
        private static void AssertContainsZ(int start, int end)
        {
            AssertContains(start, end, "Z");
        }
        private static void AssertContains(int start, int end, string expected)
        {
            Assert.IsTrue(FizzBuzzSequence.GenerateDisplayString(start, end).Contains(expected));
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
        public void GivenNumberNotDivisibleBy3Or5_ItMustReturnSelfAsString()
        {
            AssertThat("1 2", 1,2);
            AssertThat("7 8", 7, 8);
            AssertThat("13 14", 13, 14);
        }
        [TestMethod]
        public void ItMustReturnCandSelfAsString()
        {
            AssertThat("1 2 C 4", 1,4);
        }
        [TestMethod]
        public void ItMustReturnCEandSelfAsString()
        {
            AssertThat("1 2 C 4 E C 7 8 C", 1, 9);
        }
        [TestMethod]
        public void GivenNumberDivisibleBy3_ResultMustContainC()
        {
            AssertContainsC(1,3);
            AssertContainsC(1,9);
            
        }
        [TestMethod]
        public void GivenNumberDivisibleBy5_ResultMustContainE()
        {
            AssertContainsE(1, 6);
            AssertContainsE(1, 10);
        }
        [TestMethod]
        public void GivenNumberDivisibleBothBy3and5_ResultMustContainZ()
        {
            AssertContainsZ(1,20);
        }
    }
}
