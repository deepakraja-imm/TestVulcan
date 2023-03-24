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
   public class DiagnosticsWindowTest : UnitTestClassBase {
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
      public void T7_001_PfieldParameter() {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);
         // To select diagnostics option

         IButton Diagnostics_option = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Diagnostics_option.Click ();
         Thread.Sleep (1000);

         // To select Pfield parameter

         IButton Pfield = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.DiagnosticsWnd"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "PField Parameter"
         }, 2);
         Pfield.Click ();
         Thread.Sleep (1000);

         // To close the Pfield popup

         IControl Pfield_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.PFieldDisplay"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         }, 4);
         Pfield_done.Click ();
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
         Off.DblClick ();

         IButton CloseVulcan = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            WPFControlText = "Close Vulcan"
         }, 2);
         CloseVulcan.Click ();
      }

      [TestMethod]
      public void T7_002_ErrorLog () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);
         // To select diagnostics option

         IButton Diagnostics_option = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Diagnostics_option.Click ();
         Thread.Sleep (1000);

         // To select error log

         IButton Errorlog = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.DiagnosticsWnd"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "Error Log"
         }, 2);
         Errorlog.Click ();
         Thread.Sleep (1000);

         // To close the errorlog popup

         IControl Errorlog_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ErrorLogDlg"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         }, 4);
         Errorlog_done.Click ();
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
         Off.DblClick ();

         IButton CloseVulcan = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            WPFControlText = "Close Vulcan"
         }, 2);
         CloseVulcan.Click ();
      }
      [TestMethod]
      public void T7_003_LoadBackup () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select diagnostics option

         IButton Diagnostics_option = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Diagnostics_option.Click ();
         Thread.Sleep (1000);

         // To select load backup

         IButton Loadbackup = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.DiagnosticsWnd"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "Load backup"
         }, 2);
         Loadbackup.Click ();
         Thread.Sleep (1000);

         // To close the load popup done

         IControl Loadbackup_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.FileOpenDlg"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.DockPanel",
            WPFControlOrdinalNo = 1
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.DockPanel",
            WPFControlOrdinalNo = 1
         }).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 1
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Loadbackup_done.Click ();
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
         Off.DblClick ();

         IButton CloseVulcan = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            WPFControlText = "Close Vulcan"
         }, 2);
         CloseVulcan.Click ();
      }

      [TestMethod]
      public void T7_004_SaveBackup () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select diagnostics option

         IButton Diagnostics_option = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Diagnostics_option.Click ();
         Thread.Sleep (1000);

         // To select save backup

         IButton Savebackup = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.DiagnosticsWnd"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "Save backup"
         }, 2);
         Savebackup.Click ();
         Thread.Sleep (1000);

         ICheckBox Databackup = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.BackupDlg"
         }, 2).Find<ICheckBox> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.CheckBox",
            WPFControlText = "Data"
         }, 2);
         Databackup.Click ();
         Thread.Sleep (1000);

         // To close the save backup done

         IControl Savebackup_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.BackupDlg"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 2
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Savebackup_done.Click ();
         Thread.Sleep (4000);

         IControl Confirm_popup = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.PromptBox"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         }, 4);
         Confirm_popup.Click ();
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
         Off.DblClick ();

         IButton CloseVulcan = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            WPFControlText = "Close Vulcan"
         }, 2);
         CloseVulcan.Click ();
      }

      [TestMethod]
      public void T7_005_License () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select diagnostics option

         IButton Diagnostics_option = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Diagnostics_option.Click ();
         Thread.Sleep (1000);

         // To select license

         IButton License = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.DiagnosticsWnd"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "License"
         }, 2);
         License.Click ();
         Thread.Sleep (1000);

         IControl License_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.LicenseDlg"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         }, 4);
         License_done.Click ();
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
         Off.DblClick ();

         IButton CloseVulcan = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            WPFControlText = "Close Vulcan"
         }, 2);
         CloseVulcan.Click ();
          }

      [TestMethod]
      public void T7_006_Oscillator () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select diagnostics option

         IButton Diagnostics_option = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Diagnostics_option.Click ();
         Thread.Sleep (1000);

         // To select oscillator popup

         IButton oscillator = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.DiagnosticsWnd"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "Oscillator data"
         }, 2);
         oscillator.Click ();
         Thread.Sleep (1000);

         IControl oscillator_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.PromptBox"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.DockPanel"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.DockPanel"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         }, 2);
         oscillator_done.Click ();
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
         Off.DblClick ();

         IButton CloseVulcan = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            WPFControlText = "Close Vulcan"
         }, 2);
         CloseVulcan.Click ();
      }
         static string processName = @"C:\Program Files\Metamation\Vulcan\Vulcan.exe";
   }
}
