using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Kata01.DataTests
{


    /* Test Hülle */
    [TestFixture]
    [Category("Tests with external Test Data")]
    public class MyTests
    {
        [TestCaseSource(typeof(DataSourceClassImpl), "TestCases")]
        [Test]
        public void addTest(int first, int second, int solution)
        {
            Assert.That(calculator.add(first, second).Equals(solution));
        }
    }



    /* Test Cases */
    public class DataSourceClassImpl
    {
        public static IEnumerable TestCases
        {
            get
            {

                // Unit Tests aufrufen
                yield return new TestCaseData(1, 3, 4);
                yield return new TestCaseData(4, 2, 6);
                yield return new TestCaseData(1, 2, 3);
            }
        }
    }
}
