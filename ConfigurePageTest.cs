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
   public class ConfigurePageTest : UnitTestClassBase {
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
      public void T6_001_TRUMPFLTT_ViewDefaults () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select configure page

         IControl Configure_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Configure"
         }, 6);
         Configure_page.Click ();
         Thread.Sleep (1000);

         // To select laser database

         IControl laserDB = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Laser Database"
         }, 6);
         laserDB.Click ();
         Thread.Sleep (1000);

         // To change the parameter

         IControl General_param = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel",
            WPFControlOrdinalNo = 6
         }, 9).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericEdit"
         });
         General_param.Click ();
         Thread.Sleep (1000);

         IButton numeric_4 = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericKeyboard"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "4"
         }, 2);
         numeric_4.Click ();
         Thread.Sleep (1000);

         IButton equal = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericKeyboard"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "="
         }, 2);
         equal.Click ();
         Thread.Sleep (1000);

         // To view defaults

         IControl default_value = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 4
         }, 4);
         default_value.Click ();
         Thread.Sleep (3000);

         // To deselect defaults

         IControl default_valueDeselect = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 4
         }, 4);
         default_valueDeselect.Click ();
         Thread.Sleep (1000);

         // To close the DB window

         IButton laserDB_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 7
         }, 4).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         laserDB_done.Click ();
         Thread.Sleep (1000);

         IControl Cancel_laserDBdone = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.PromptBox"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 1
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Cancel_laserDBdone.Click ();
         Thread.Sleep (3000);

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
      public void T6_002_TRUMPFLTT_RestoreDefaults () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select configure page

         IControl Configure_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Configure"
         }, 6);
         Configure_page.Click ();
         Thread.Sleep (1000);

         // To select laser database

         IControl laserDB = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Laser Database"
         }, 6);
         laserDB.Click ();
         Thread.Sleep (1000);

         // To change the parameter

         IControl General_param = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel",
            WPFControlOrdinalNo = 6
         }, 9).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericEdit"
         });
         General_param.Click ();
         Thread.Sleep (1000);

         IButton numeric_4 = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericKeyboard"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "4"
         }, 2);
         numeric_4.Click ();
         Thread.Sleep (1000);

         IButton equal = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericKeyboard"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "="
         }, 2);
         equal.Click ();
         Thread.Sleep (1000);

         // To restore defaults

         IButton restore_default = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 5
         }, 4).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         restore_default.Click ();
         Thread.Sleep (3000);

         // To close the DB window

         IButton laserDB_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 7
         }, 4).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         laserDB_done.Click ();
         Thread.Sleep (1000);

         IControl Cancel_laserDBdone = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.PromptBox"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 1
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Cancel_laserDBdone.Click ();
         Thread.Sleep (3000);



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
      public void T6_003_TRUMPFLTT_Import () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select configure page

         IControl Configure_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Configure"
         }, 6);
         Configure_page.Click ();
         Thread.Sleep (1000);

         // To select laser database

         IControl laserDB = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Laser Database"
         }, 6);
         laserDB.Click ();
         Thread.Sleep (1000);

         // To select import option

         IButton import_DB = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.VerticalToolbar",
            WPFControlText = ""
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 1
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         import_DB.Click ();
         Thread.Sleep (2000);

         //Done import

         IControl confirm_import = Driver.Find<IProcess> (new ProcessPattern () {
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
         confirm_import.Click ();
         Thread.Sleep (2000);

         //Cancel import

         //IControl Cancel_import = Driver.Find<IProcess> (new ProcessPattern () {
         //   ProcessName = "Vulcan"
         //}).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "CUILib.FileOpenDlg"
         //}, 2).Find<IButton> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.Button",
         //   WPFControlText = "",
         //   WPFControlOrdinalNo = 2
         //}, 3).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.Image"
         //});
         //Cancel_import.Click ();
         //Thread.Sleep (1000);

         // To close the DB window

         IButton laserDB_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 7
         }, 4).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         laserDB_done.Click ();
         Thread.Sleep (1000);

         IControl Cancel_laserDBdone = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.PromptBox"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 1
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Cancel_laserDBdone.Click ();
         Thread.Sleep (3000);

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
      public void T6_004_TRUMPFLTT_SaveDefaults () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select configure page

         IControl Configure_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Configure"
         }, 6);
         Configure_page.Click ();
         Thread.Sleep (1000);

         // To select laser database

         IControl laserDB = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Laser Database"
         }, 6);
         laserDB.Click ();
         Thread.Sleep (1000);

         // To select save as defaults

         IButton save_defaults = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 6
         }, 4).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         save_defaults.Click ();
         Thread.Sleep (1000);

         IWPFPasswordEdit passwordBox = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.AuthenticationDlg"
         }, 2).Find<IWPFPasswordEdit> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.PasswordBox"
         }, 3);
         passwordBox.Click ();
         passwordBox.wText = "600119";
         Thread.Sleep (1000);

         IControl confirm_savedefaults = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.AuthenticationDlg"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 2
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         confirm_savedefaults.Click ();
         Thread.Sleep (4000);

         IControl Enterpass_popup = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.PromptBox"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         }, 4);
         Enterpass_popup.Click ();
         Thread.Sleep (1000);

         // To close the DB window

         IButton laserDB_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 7
         }, 4).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         laserDB_done.Click ();
         Thread.Sleep (1000);

         IControl Cancel_laserDBdone = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.PromptBox"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 1
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Cancel_laserDBdone.Click ();
         Thread.Sleep (3000);

         //IControl dockPanel = Driver.Find<IProcess> (new ProcessPattern () {
         //   ProcessName = "Vulcan"
         //}).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "Vulcan.HomePage"
         //}, 2).Find<IControl> (new WPFPattern () {
         //   WPFControlName = "MainWindow"
         //}).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.DockPanel"
         //});
         //dockPanel.Click ();

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
      public void T6_005_TRUMPFLTT_ChangePiercemode () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select configure page

         IControl Configure_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Configure"
         }, 6);
         Configure_page.Click ();
         Thread.Sleep (1000);

         // To select laser database

         IControl laserDB = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Laser Database"
         }, 6);
         laserDB.Click ();
         Thread.Sleep (1000);

         IRadioButton Pierce_gentle = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IRadioButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.RadioButton",
            WPFControlText = "Pierce gentle"
         }.Add ("GroupName", "Main"), 7);
         Pierce_gentle.Click ();
         Thread.Sleep (1000);

         IComboBox Piercemode_comboBox = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel",
            WPFControlOrdinalNo = 13
         }, 9).Find<IComboBox> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBox"
         }.Add ("DisplayMemberPath", "Value"));
         Piercemode_comboBox.Click ();
         Thread.Sleep (1000);

         IControl PierceandWidening1combo = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBoxItem",
            WPFControlText = "[PiercingAndWidening1, Piercing & widening1]"
         }, 3);
         PierceandWidening1combo.Click ();
         Thread.Sleep (2000);
         // Pierce gentle order number changes
         //Pierce_gentle.Click ();
         //Thread.Sleep (1000);
         //Piercemode_comboBox.Click ();
         //Thread.Sleep (1000);

         // second try

         //IRadioButton Pierce_gentle1 = Driver.Find<IProcess> (new ProcessPattern () {
         //   ProcessName = "Vulcan"
         //}).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         //}, 2).Find<ITabControl> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.TabControl"
         //}, 2).Find<IRadioButton> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.RadioButton",
         //   WPFControlText = "Pierce gentle"
         //}.Add ("GroupName", "Main"), 7);
         //Pierce_gentle1.Click ();

         //IComboBox Piercemode_comboBox1 = Driver.Find<IProcess> (new ProcessPattern () {
         //   ProcessName = "Vulcan"
         //}).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         //}, 2).Find<ITabControl> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.TabControl"
         //}, 2).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.StackPanel",
         //   WPFControlOrdinalNo = 13
         //}, 9).Find<IComboBox> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.ComboBox"
         //}.Add ("DisplayMemberPath", "Value"));
         //Piercemode_comboBox1.Click ();


         //IControl PierceandWidening1n2combo = Driver.Find<IProcess> (new ProcessPattern () {
         //   ProcessName = "Vulcan"
         //}).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         //}, 2).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.ComboBoxItem",
         //   WPFControlText = "[PiercingAndWidening1AndWidening2, Piercing & widening1 & widening2]"
         //}, 3);
         //PierceandWidening1n2combo.Click ();
         //Thread.Sleep (1000);

         ITextEdit laserDB_done1 = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.TrumpfLaserDBView"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 7
         }, 4).Find<ITextEdit> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         laserDB_done1.Click ();
         Thread.Sleep (1000);


         IControl Cancel_laserDBdone1 = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.PromptBox"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 1
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Cancel_laserDBdone1.Click ();
         Thread.Sleep (3000);

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
      public void T6_006_Workoffset () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select configure page

         IControl Configure_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Configure"
         }, 6);
         Configure_page.Click ();
         Thread.Sleep (1000);

         // To make workoffset as (0,0)

         IControl Config_Workoffset = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Work offsets"
         }, 6);
         Config_Workoffset.Click ();
         Thread.Sleep (1000);

         IControl S1_offset = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.WorkOffsetsDialog"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "S1 "
         }, 5);
         S1_offset.Click ();
         Thread.Sleep (2000);

         IButton Import_pos = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.WorkOffsetsDialog"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.VerticalToolbar",
            WPFControlText = ""
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 1
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Import_pos.Click ();
         Thread.Sleep (1000);

         IButton Import_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.WorkOffsetsDialog"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 5
         }, 4).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Import_done.Click ();
         Thread.Sleep (1000);

         IControl Import_donepopup = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.PromptBox"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 2
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Import_donepopup.Click ();
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

      [TestMethod]
      public void T6_007_MachineSettings_Orientation () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select configure page

         IControl Configure_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Configure"
         }, 6);
         Configure_page.Click ();
         Thread.Sleep (1000);

         IControl Machinesettings = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Machine Settings"
         }, 6);
         Machinesettings.Click ();
         Thread.Sleep (1000);

         IComboBox Orientation_comboBox = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "RightAngle.EditMachineSettings"
         }, 2).Find<IScrollViewReal> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ScrollViewer",
            WPFControlText = ""
         }, 7).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel",
            WPFControlOrdinalNo = 1
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel",
            WPFControlOrdinalNo = 1
         }).Find<IComboBox> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBox"
         });
         Orientation_comboBox.Click ();
         Thread.Sleep (1000);

         IControl Landscape_Orientation = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBoxItem",
            WPFControlText = "Landscape"
         }, 3);
         Landscape_Orientation.Click ();
         Thread.Sleep (1000);

         //IControl Portrait_Orientation = driver.Find<IProcess> (new ProcessPattern () {
         //   ProcessName = "Vulcan"
         //}).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         //}, 2).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.ComboBoxItem",
         //   WPFControlText = "Portrait"
         //}, 3);
         //Portrait_Orientation.Click ();
         //Thread.Sleep (1000);

         IRadioButton Save_Machinesettings = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "RightAngle.EditMachineSettings"
         }, 2).Find<IRadioButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.RadioButton",
            WPFControlText = "Close"
         }.Add ("GroupName", ""), 3);
         Save_Machinesettings.Click ();
         Thread.Sleep (1000);

         IButton SavenReload = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "Save and reload parameters"
         }, 2);
         SavenReload.Click ();
         Thread.Sleep (5000);

         IControl Programs_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Programs"
         }, 6);
         Programs_page.Click ();
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

      [TestMethod]
      public void T6_008_MachineSettings_Theme () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select configure page

         IControl Configure_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Configure"
         }, 6);
         Configure_page.Click ();
         Thread.Sleep (1000);

         IControl Machinesettings = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Machine Settings"
         }, 6);
         Machinesettings.Click ();
         Thread.Sleep (1000);

         IComboBox Theme_combo = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "RightAngle.EditMachineSettings"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel",
            WPFControlOrdinalNo = 9
         }, 9).Find<IComboBox> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBox"
         });
         Theme_combo.Click ();
         Thread.Sleep (1000);

         IControl Grey_theme = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBoxItem",
            WPFControlText = "Grey"
         }, 3);
         Grey_theme.Click ();
         Thread.Sleep (1000);

         // Blue theme

         //IControl Blue_theme = driver.Find<IProcess> (new ProcessPattern () {
         //   ProcessName = "Vulcan"
         //}).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         //}, 2).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.ComboBoxItem",
         //   WPFControlText = "Blue"
         //}, 3);
         //Blue_theme.Click ();
         //Thread.Sleep (1000);


         IRadioButton Save_Machinesettings = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "RightAngle.EditMachineSettings"
         }, 2).Find<IRadioButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.RadioButton",
            WPFControlText = "Close"
         }.Add ("GroupName", ""), 3);
         Save_Machinesettings.Click ();
         Thread.Sleep (1000);

         IButton SavenReload = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "Save and reload parameters"
         }, 2);
         SavenReload.Click ();
         Thread.Sleep (5000);

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
      public void T6_009_MachineSettings_EngtoCN_lang () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select configure page

         IControl Configure_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Configure"
         }, 6);
         Configure_page.Click ();
         Thread.Sleep (1000);

         IControl Machinesettings = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Machine Settings"
         }, 6);
         Machinesettings.Click ();
         Thread.Sleep (1000);

         IComboBox Lang_comboBox = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "RightAngle.EditMachineSettings"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel",
            WPFControlOrdinalNo = 8
         }, 9).Find<IComboBox> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBox"
         });
         Lang_comboBox.Click ();
         Thread.Sleep (1000);

         IControl Chinese_Lang = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBoxItem",
            WPFControlText = "CN"
         }, 3);
         Chinese_Lang.Click ();
         Thread.Sleep (1000);

         IRadioButton Save_Machinesettings = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "RightAngle.EditMachineSettings"
         }, 2).Find<IRadioButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.RadioButton",
            WPFControlText = "Close"
         }.Add ("GroupName", ""), 3);
         Save_Machinesettings.Click ();
         Thread.Sleep (1000);

         IButton SavenReload = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "Save and reload parameters"
         }, 2);
         SavenReload.Click ();
         Thread.Sleep (5000);

         // To select OFF button

         IControl Off = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "关闭"
         }, 6);
         Off.Click ();

         IButton CloseVulcan = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "关闭Vulcan"
         }, 2);
         CloseVulcan.Click ();
      }

      [TestMethod]
      public void T6_010_MachineSettings_CNtoEng_lang () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To change from chinese to english language


         IControl Configure_CN = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "配置"
         }, 6);
         Configure_CN.Click ();
         Thread.Sleep (1000);

         IControl Machinesettings_CN = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "机床设置"
         }, 6);
         Machinesettings_CN.Click ();
         Thread.Sleep (1000);

         IComboBox Orientation_comboBox = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "RightAngle.EditMachineSettings"
         }, 2).Find<IScrollViewReal> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ScrollViewer",
            WPFControlText = ""
         }, 7).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel",
            WPFControlOrdinalNo = 1
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel",
            WPFControlOrdinalNo = 1
         }).Find<IComboBox> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBox"
         });
         Orientation_comboBox.Click ();
         Thread.Sleep (1000);

         IControl Portrait_CN = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBoxItem",
            WPFControlText = "纵向"
         }, 3);
         Portrait_CN.Click ();
         Thread.Sleep (1000);

         IComboBox Theme_combo = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "RightAngle.EditMachineSettings"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel",
            WPFControlOrdinalNo = 9
         }, 9).Find<IComboBox> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBox"
         });
         Theme_combo.Click ();
         Thread.Sleep (1000);

         IControl Blue_CN = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBoxItem",
            WPFControlText = "蓝色"
         }, 3);
         Blue_CN.Click ();
         Thread.Sleep (1000);

         IComboBox Lang_comboBox = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "RightAngle.EditMachineSettings"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel",
            WPFControlOrdinalNo = 8
         }, 9).Find<IComboBox> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBox"
         });
         Lang_comboBox.Click ();
         Thread.Sleep (1000);

         IControl English_CN = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Primitives.PopupRoot"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.ComboBoxItem",
            WPFControlText = "英文"
         }, 3);
         English_CN.Click ();
         Thread.Sleep (1000);

         IRadioButton SaveMK_CN = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "RightAngle.EditMachineSettings"
         }, 2).Find<IRadioButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.RadioButton",
            WPFControlText = "关闭"
         }.Add ("GroupName", ""), 3);
         SaveMK_CN.Click ();
         Thread.Sleep (1000);

         IButton SavenReload_CN = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.ExitDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "保存并重新加载参数"
         }, 2);
         SavenReload_CN.Click ();
         Thread.Sleep (5000);

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
