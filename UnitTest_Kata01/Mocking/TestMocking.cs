using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace UnitTest_Kata01.Mocking
{
    [Category("Mocking")]
    public class TestMocking
    {
        [Test]
        public void basicsOfMocking()
        {
            Object[] output = new Object[2];
           

            // Vereinfachter Recordset
            output[0] = new LinkedList<String>().AddFirst("Peter, Lustig");
            output[1] = new LinkedList<String>().AddFirst("Franz, Brantwein");

            // Setup 
            // erzeugt Mock Instanz
            var idh = new Mock<IDatabaseHandler>();

            // wenn genau dieser String eingeht dann gib output zurück
            idh.Setup(f => f.ExecSqlQuery("SELECT * FROM users")).Returns(output);


            // Execute
            KlasseDieIDatabaseHandlerBenoetigt klasseZuTesten = new KlasseDieIDatabaseHandlerBenoetigt(idh.Object);
            Assert.That(klasseZuTesten.searchUsers().Length.Equals(2));
            Assert.That(klasseZuTesten.searchUsers(), Is.Not.Null);

        }

        [Test]
        public void howMyClassHandlesAnException()
        {
            // erzeugt Mock Instanz
            var idh = new Mock<IDatabaseHandler>();
            idh.Setup(f => f.ExecSqlQuery(It.IsAny<String>())).Throws<ArgumentException>();

            // Test
            KlasseDieIDatabaseHandlerBenoetigt klasseZuTesten = new KlasseDieIDatabaseHandlerBenoetigt(idh.Object);
            Assert.That(klasseZuTesten.searchUsers(), Is.Null);

        }

        [Test]
        public void howToCheckVoidFunctions()
        {
            // erzeugt Mock Instanz
            var idh = new Mock<IDatabaseHandler>();
            KlasseDieIDatabaseHandlerBenoetigt klasseZuTesten = new KlasseDieIDatabaseHandlerBenoetigt(idh.Object);
            idh.Setup(m => m.init());


            // Exec
            klasseZuTesten.initDatabaseHandler();


            // Verify => Überwachung von Calls
            idh.Verify(m => m.init(), Times.AtLeast(1));
            idh.Verify(m => m.init(), Times.AtMost(2));
            //idh.Verify(m => m.init(), Times.Exactly(3));
        }

    }
}
