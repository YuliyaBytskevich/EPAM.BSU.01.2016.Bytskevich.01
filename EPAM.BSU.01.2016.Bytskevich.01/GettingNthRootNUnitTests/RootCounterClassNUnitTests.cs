using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using GettingNthRoot;

namespace GettingNthRootNUnitTests
{
    [TestFixture]
    public class RootCounterClassNUnitTests
    {
        public IEnumerable<TestCaseData> TestValues
        {
            get
            {
                yield return new TestCaseData(Math.Pow(11223344, 4), 4, 0.0000000001).Returns(11223344);
                yield return new TestCaseData(Math.Pow(12345, -5), -5, 0.0000000001).Returns(12345);
                yield return new TestCaseData(Math.Pow(0.12345, 11), 11, 0.0000000001).Returns(0.12345);
                yield return new TestCaseData(Math.Pow(0.111, -7), -7, 0.0000000001).Returns(0.111);
                yield return new TestCaseData(-1, 10, 0.000000001).Throws(typeof(ArgumentException));
                yield return new TestCaseData(0, 10, 0.000000001).Throws(typeof(ArgumentException));
                yield return new TestCaseData(500, 0, 0.000000001).Throws(typeof(ArgumentException));
                yield return new TestCaseData(1024, 10, -0.000000001).Throws(typeof(ArgumentException));
            }
        }

        [Test, TestCaseSource(nameof(TestValues))]
        public double GetRoot_RootOf(double number, int degree, double requiredAccuracy)
        {
            return RootCounter.GetRoot(number, degree, requiredAccuracy);
        }

    }
}
