using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using GettingNthRoot;

namespace GettingNthRootTests
{
    [TestClass]
    public class RootCounterClassTests
    {
        [TestMethod]
        public void GetRoot_PositiveIntegerNumberPositiveDegreeFractionAccuracy_Root()
        {
            int degree = 15;
            double arrangeRoot = 12345;
            double number = Math.Pow(arrangeRoot, degree);
            double actRoot = RootCounter.GetRoot(number, degree, 0.0000000001);
            Assert.AreEqual(arrangeRoot, actRoot);
        }

        [TestMethod]
        public void GetRoot_PositiveIntegerNumberNegativeDegreeFractionAccuracy_Root()
        {
            int degree = -5;
            double arrangeRoot = 12345;
            double number = Math.Pow(arrangeRoot, degree);         
            double actRoot = RootCounter.GetRoot(number, degree, 0.0000000001);
            Assert.AreEqual(arrangeRoot, actRoot);
        }

        [TestMethod]
        public void GetRoot_PositiveFractionNumberPositiveDegreeFractionAccuracy_Root()
        {
            int degree = 15;
            double arrangeRoot = 0.1122334455;
            double number = Math.Pow(arrangeRoot, degree);
            double actRoot = RootCounter.GetRoot(number, degree, 0.0000000001);
            Assert.AreEqual(arrangeRoot, actRoot);
        }

        [TestMethod]
        public void GetRoot_PositiveFractionNumberNegativeDegreeFractionAccuracy_Root()
        {
            int degree = -5;
            double arrangeRoot = 0.1122334455;
            double number = Math.Pow(arrangeRoot, -degree);
            double actRoot = RootCounter.GetRoot(number, degree, 0.0000000001);
            Assert.AreEqual(arrangeRoot, actRoot, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetRoot_NegativeNumber_ArgumentException()
        {
            double actRoot = RootCounter.GetRoot(-1, 10, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetRoot_NullNumber_ArgumentException()
        {
            double actRoot = RootCounter.GetRoot(0, 10, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetRoot_NegativeAccuracy_ArgumentException()
        {
            double actRoot = RootCounter.GetRoot(11111, 10, -0.0000000001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetRoot_NullDegree_ArgumentException()
        {
            double actRoot = RootCounter.GetRoot(10, 0, 0.0001);
        }

    }
}
