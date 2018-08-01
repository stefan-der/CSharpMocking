using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Kata01.Mocking
{
    interface IDatabaseHandler
    {
        Object[] ExecSqlQuery(String query);
        void init();

    }
}
