using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartBear.TestLeft.TestObjects;
using SmartBear.TestLeft.TestObjects.WinForms;
using SmartBear.TestLeft.TestObjects.WPF;

namespace TestVulcan {
   [TestClass]
   public class VersionTest : UnitTestClassBase {
      #region Class initializers
      [ClassInitialize]
      public static void ClassInitialize (TestContext context) {
         UnitTestClassBase.InitializeClass (context);
      }

      [ClassCleanup]
      public static void ClassCleanUp () {
         UnitTestClassBase.FinalizeClass ();
      }
      #endregion

      [TestMethod]
      public void T7_001_PfieldParameter () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To check version

         IControl version = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            WPFControlName = "MainWindow"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.DockPanel"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         version.Click ();
         Thread.Sleep (2000);


         IControl version_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.VersionInfoDlg"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         }, 4);
         version_done.Click ();
         Thread.Sleep (1000);

         // To select OFF button

         IControl Off = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Off"
         }, 6);
         Off.Click ();
         Thread.Sleep (1000);

         IButton CloseVulcan = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "Close Vulcan"
         }, 2);
         CloseVulcan.Click ();
         Thread.Sleep (1000);
      }
      static string processName = @"C:\Program Files\Metamation\Vulcan\Vulcan.exe";
   }
}

