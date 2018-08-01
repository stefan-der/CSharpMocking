using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Diagnostics;

namespace UnitTest_Kata01.nunitSpecific
{
    [Category("LifecycleDemonstration")]
    class TestLifeCycle
    {
        int oneTimeSetupExecutionCounter = 0;
        int oneTimeTeardownExecutionCounter = 0;
        int setupCounter = 0;
        int teardownCounter = 0;



        #region lifecycle
        public TestLifeCycle()
        {
            printStateToLog("Constructor");
        }

        ~TestLifeCycle()
        {
            printStateToLog("Destructor");
        }

        [OneTimeSetUp]
        public void oneTimeSetup()
        {
            this.oneTimeSetupExecutionCounter++;
            this.printStateToLog("onTimeSetup");
        }

        [OneTimeTearDown]
        public void oneTimeTeardown()
        {
            this.oneTimeTeardownExecutionCounter++;
            this.printStateToLog("oneTimeTearDown");

            // dispalying the State
            this.printCounter("OneTimeSetup", this.oneTimeSetupExecutionCounter);
            this.printCounter("SetupCounter", this.setupCounter);
            this.printCounter("TeardownCounter", this.teardownCounter);
            this.printCounter("OneTimeTeardown", this.oneTimeTeardownExecutionCounter);


        }

        [SetUp]
        public void setup()
        {
            this.setupCounter++;
            this.printStateToLog("setup");
        }

        [TearDown]
        public void tearDown()
        {
            this.teardownCounter++;
            this.printStateToLog("teardown");
        }
        #endregion lifecycle
        #region tests
        [Test]
        public void test1()
        {
            Assert.That(true);
        }
        
        [Test]
        public void test2()
        {
            Assert.That(true);
        }

        #endregion test
        #region helper
        /* Helper functions to Standardize Output */
        public void printStateToLog(String state)
        {
            printMessageToLog(state + " has been executed.");
        }
        public void printMessageToLog(String message)
        {
            System.Console.WriteLine(message);
        }
        /* Helper function to create String of Execution States */
        public void printCounter(String counterName, int counter)
        {
            String message = counterName + "\t" + counter;
            this.printMessageToLog(message);
        }
        #endregion helper
    }
}