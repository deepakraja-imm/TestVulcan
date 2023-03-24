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
   public class CreatePageTest : UnitTestClassBase {
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
      public void T2_001_CreateJob () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         IControl Create_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Create"
         }, 6);
         Create_page.Click ();
         Thread.Sleep (1000);

         // To disable the selected DXF program

         IControl Deselect = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            WPFControlName = "MainWindow"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.DockPanel"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Grid",
            WPFControlOrdinalNo = 1
         }, 4);
         Deselect.Click ();
         Thread.Sleep (1000);

         // To select the DXF program

         IControl Select_program = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Grid",
            WPFControlOrdinalNo = 4
         }, 6);
         Select_program.Click ();
         Thread.Sleep (1000);

         // To select create option

         IControl Create_option = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "create job"
         }, 10);
         Create_option.Click ();
         Thread.Sleep (1000);
          
         // To select layouts tab

         IControl layouts_tab = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.JobSettings"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabItem",
            WPFControlText = "Layouts"
         });
         layouts_tab.Click ();
         Thread.Sleep (1000);

         // To select the  generated layouts

         IControl Click_layout = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.JobSettings"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IScrollViewReal> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ScrollViewer",
            WPFControlText = ""
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Grid"
         }, 3);
         Click_layout.Click ();
         Thread.Sleep (1000);


         // To save the layouts

         IControl Save_layouts = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.JobSettings"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "save layouts"
         }, 8);
         Save_layouts.Click ();
         Thread.Sleep (1000);

         // To enter the name of layout

         ITextEdit Save_name = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.SaveAsDialog"
         }, 2).Find<ITextEdit> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBox"
         }, 3);
         Save_name.Click ();
         Thread.Sleep (1000);
         Save_name.SetText ("sample123");
         Thread.Sleep (1000);


         // To click done in Save layouts

         IControl Save_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.SaveAsDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 2
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Save_done.Click ();
         Thread.Sleep (2000);

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

         IButton CloseVulcan = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "Close Vulcan"
         }, 2);
         CloseVulcan.Click ();
      }
      [TestMethod]
      public void T2_001_SimulateJob () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         IControl Programs_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Programs"
         }, 6);
         Programs_page.Click ();

         // To select simulate option

         IControl Simulate_layouts = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "simulate"
         }, 10);
         Simulate_layouts.Click ();
         Thread.Sleep (1000);

         // To change the speed

         IButton Change_speed = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.SimulatePage"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "1x"
         }, 3);
         Change_speed.Click ();
         Thread.Sleep (1000);

         // To change the speed from 1x to 5x

         IControl speed_5x = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         }, 2).Find<IBar> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ContextMenu"
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.MenuItem",
            WPFControlText = "5x"
         });
         speed_5x.Click ();
         Thread.Sleep (1000);

         // To play simulation

         IControl Play_simulation = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.SimulatePage"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 1
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Play_simulation.Click ();
         Thread.Sleep (10000);

         IButton Simulation_complete = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.SimulatePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.DockPanel",
            WPFControlOrdinalNo = 1
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.DockPanel",
            WPFControlOrdinalNo = 1
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 4
         }, 3).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Simulation_complete.Click ();

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

         IButton CloseVulcan = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "Close Vulcan"
         }, 2);
         CloseVulcan.Click ();


      }
         static string processName = @"C:\Program Files\Metamation\Vulcan\Vulcan.exe";
   }
}
