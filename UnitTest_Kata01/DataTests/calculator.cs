using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Kata01.DataTests
{
    class calculator
    {
        public static int add(int first, int second)
        {
            if(first <0 || second <0 || first>=int.MaxValue || second >= int.MaxValue)
            {
                throw new CalculatorException();
            }


            return first + second;
        }
    }
}
