using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTest_Kata01.nunitBasics
{
    [Category("Exceptions")]
    class TestExceptions
    {
        [Test]
        public void testAnException()
        {
            Assert.Throws<NullReferenceException>(throwANewNullReferenceException);
        }



        public void throwANewNullReferenceException()
        {
            throw new NullReferenceException();
        }

    }
}
