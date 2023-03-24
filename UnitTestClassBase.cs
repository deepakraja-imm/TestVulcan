using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;
using SmartBear.TestLeft;

namespace TestVulcan {
   [TestClass]
   public class UnitTestClassBase {
      static private TestContext _testContext;
      static private IDriver _driver;

      static UnitTestClassBase () {
         //Create a local Driver object
         _driver = new LocalDriver ();

         //Use line below instead of the above to create a remote Driver
         //_driver = new RemoteDriver("myhost", "userName", "password");

         //Uncomment the line below to perform additional checks during code execution
         //_driver.Options.Debug.RuntimeChecks = SmartBear.TestLeft.Options.RuntimeChecks.All;
      }

      protected static IDriver Driver
      {
         get
         {
            return _driver;
         }
      }

      public TestContext TestContext
      {
         get
         {
            return _testContext;
         }
         set
         {
            _testContext = value;
         }
      }

      [ClassInitialize]
      public static void InitializeClass (TestContext context) {
         _testContext = context;
      }

      [ClassCleanup]
      public static void FinalizeClass () {
         _driver.Log.Save (_testContext.ResultsDirectory + @"\TestVulcan TestResults", Log.Format.Html);
      }

      [TestInitialize]
      public void BasicSetUp () {
         _driver.Log.OpenFolder (_testContext.FullyQualifiedTestClassName + "." + _testContext.TestName);
      }

      [TestCleanup]
      public void BasicTearDown () {
         if (_testContext.CurrentTestOutcome != UnitTestOutcome.Passed) {
            _driver.Log.Error ("The test failed. See information on errors in the MSTest log.");
            _testContext.AddResultFile (_testContext.ResultsDirectory + @"\TestVulcan TestResults\index.htm");
         }

         _driver.Log.CloseFolder ();
      }
   }
}
