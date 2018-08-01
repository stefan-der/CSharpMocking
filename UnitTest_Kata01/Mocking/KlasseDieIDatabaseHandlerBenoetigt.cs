using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Kata01.Mocking
{
    class KlasseDieIDatabaseHandlerBenoetigt
    {
        IDatabaseHandler databaseHandler = null;

        public KlasseDieIDatabaseHandlerBenoetigt(IDatabaseHandler databaseHandler)
        {
            this.databaseHandler = databaseHandler;
        }


        public Object[] searchUsers()
        {
            Object[] output = null;
            try
            {
                output = this.databaseHandler.ExecSqlQuery("SELECT * FROM users");
            }
            catch
            {
                // fängt alle! Fehler und gibt statt dessen Null zurück
            }
            return output;
        }

        public void initDatabaseHandler()
        {
            this.databaseHandler.init();
            // doppelt hält besser
            this.databaseHandler.init();
        }

    }
}
