using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTest_Kata01.nunitSpecific
{
    [Category("ConstraintsDemo")]
    class Constraints
    {
       
        // einfache Bedingung
        [Test]
        public void simpleConstraint()
        {
            int integerZero = 0;
            Assert.That(integerZero, Is.Zero);   
        }


        // Zusammengesetzte Bedingung für einen einfachen Wert
        public void combinationOfConstraints2()
        {
            int integerZero = 0;
            Assert.That(integerZero, Is.GreaterThan(-1).And.LessThan(1));
        }


        // Zusammengesetzte Bedingungen für Komplexe Business Logik
        [Test]
        public void combinationOfConstraints()
        {
            int menge = 101;
            bool mengenRabattGewaehrt = true;

            Assert.Multiple(() =>
            {
                Assert.That(menge, Is.GreaterThan(100));
                Assert.That(mengenRabattGewaehrt, Is.True);
            });
        }





    }
}
