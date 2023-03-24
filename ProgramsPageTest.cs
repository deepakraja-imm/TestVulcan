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
   public class ProgramsPageTest : UnitTestClassBase {
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
      public void T3_001_DIN_EditLaserpage () {
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


         // To select bulb program

         IControl Program_name = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Bulb"
         }, 8);
         Program_name.Click ();
         Thread.Sleep (1000);

         // To select edit option

         IControl Program_edit = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 2
         }, 7).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel"
         }, 2);
         Program_edit.Click ();
         Thread.Sleep (1000);

         // To select DIN_laser functions tab

         IControl Laserfunction_tab = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.EditPage"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabItem",
            WPFControlText = "Laser functions"
         });
         Laserfunction_tab.Click ();
         Thread.Sleep (1000);

         // To select material combobox

         IComboBox Material_combo = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.EditPage"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IScrollViewReal> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ScrollViewer",
            WPFControlText = ""
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Grid",
            WPFControlOrdinalNo = 1
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Grid",
            WPFControlOrdinalNo = 1
         }).Find<IComboBox> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBox",
            WPFControlOrdinalNo = 1
         });
         Material_combo.Click ();
         Thread.Sleep (1000);

         // to change the material

         IControl MS_material = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBoxItem",
            WPFControlText = "MS"
         }, 3);
         MS_material.Click ();
         Thread.Sleep (1000);


         // To select the thickness combobox

         IComboBox Thickness_combo = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.EditPage"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IScrollViewReal> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ScrollViewer",
            WPFControlText = ""
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Grid",
            WPFControlOrdinalNo = 1
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Grid",
            WPFControlOrdinalNo = 1
         }).Find<IComboBox> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBox",
            WPFControlOrdinalNo = 2
         });
         Thickness_combo.Click ();
         Thread.Sleep (1000);

         // to change the material thickness

         IControl Thickness_1mm = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBoxItem",
            WPFControlText = "1"
         }, 3);
         Thickness_1mm.Click ();
         Thread.Sleep (1000);

         // To select the Nozzle combobox

         IComboBox Nozzle_combo = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.EditPage"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IScrollViewReal> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ScrollViewer",
            WPFControlText = ""
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Grid",
            WPFControlOrdinalNo = 1
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Grid",
            WPFControlOrdinalNo = 1
         }).Find<IComboBox> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBox",
            WPFControlOrdinalNo = 3
         });
         Nozzle_combo.Click ();
         Thread.Sleep (1000);

         // to change the nozzle type

         IControl Nozzle_alphanumeric = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBoxItem",
            WPFControlText = "SAMPLE01"
         }, 3);
         Nozzle_alphanumeric.Click ();
         Thread.Sleep (1000);

         // to select DIN_text tab

         IControl DINtext_tab = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.EditPage"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabItem",
            WPFControlText = "DIN Text"
         });
         DINtext_tab.Click ();
         Thread.Sleep (3000);

         // to save the program

         IControl programsave = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.EditPage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "save"
         }, 7);
         programsave.Click ();
         Thread.Sleep (1000);

         // to load the program

         IControl LOAD_program = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "run",
            WPFControlOrdinalNo = 1
         }, 10);
         LOAD_program.Click ();

         // to START the program from RUN page

         IControl Start_program = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "start"
         }, 11);
         Start_program.Click ();
         Thread.Sleep (10000);

         // To pause and abort the program

         IButton Pauseprog = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.VerticalToolbar",
            WPFControlText = ""
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 2
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Pauseprog.Click ();
         Thread.Sleep (2000);
         Pauseprog.Click (); //abort
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
