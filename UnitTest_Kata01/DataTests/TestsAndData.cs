using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace UnitTest_Kata01.DataTests
{
    [Category("Tests with inline Test Data")]
    class TestsAndData
    {

        [TestCase(1, 0, 1)]
        [TestCase(1, 2, 3)]
        [TestCase(2, 2, 4)]
        [Test]
        public void testWithDataAddFunction(int first, int second, int solution)
        {
            Assert.That(calculator.add(first, second).Equals(solution));
        }

    }
}
