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
   public class RunPageTest : UnitTestClassBase {
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
      public void T5_001_StartandStopPrg () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select RUN page

         IControl RUNpage = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Run"
         }, 6);
         RUNpage.Click ();
         Thread.Sleep (1000);

         // To start the program

         IButton Startprog = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.VerticalToolbar",
            WPFControlText = ""
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 1
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Startprog.Click ();
         Thread.Sleep (5000);

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

      [TestMethod]
      public void T5_002_EditTheProg () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select RUN page

         IControl RUNpage = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Run"
         }, 6);
         RUNpage.Click ();
         Thread.Sleep (1000);

         // To edit the program
         IButton Editprog = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.VerticalToolbar",
            WPFControlText = ""
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 3
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Editprog.Click ();
         Thread.Sleep (1000);

         // Adding and Deleting Remnant 

         IButton Add_Remnant = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.EditPage"
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
         Add_Remnant.Click ();
         Thread.Sleep (2000);

         IButton Delete_Remnant = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.EditPage"
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
         Delete_Remnant.Click ();
         Thread.Sleep (1000);

         // To select Display option

         IButton Display_opt = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.EditPage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.VerticalToolbar",
            WPFControlText = ""
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 2
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Display_opt.Click ();
         Thread.Sleep (1000);

         ICheckBox Deselect_traverse = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.DisplayDialog"
         }, 2).Find<ICheckBox> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.CheckBox",
            WPFControlText = "Traverse"
         }, 2);
         Deselect_traverse.Click ();
         Thread.Sleep (2000);
         Deselect_traverse.Click ();
         Thread.Sleep (1000);

         // Highlight Wirejoint 

         IControl Highlight_wirejoint = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.EditPage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.VerticalToolbar",
            WPFControlText = ""
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 3
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel"
         }, 2);
         Highlight_wirejoint.Click ();
         Thread.Sleep (1000);

         IControl Highlight_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.PromptBox"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         }, 4);
         Highlight_done.Click ();
         Thread.Sleep (2000);

         // To edit settings

         IButton Edit_settings = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.EditPage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.VerticalToolbar",
            WPFControlText = ""
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 4
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });

         Edit_settings.Click ();
         Thread.Sleep (1000);

         // To save the program after edit

         IButton Edit_save = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.EditPage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 12
         }, 4).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Edit_save.Click ();
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
      public void T5_003_Workoffset () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         IControl RUNpage = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Run"
         }, 6);
         RUNpage.Click ();
         Thread.Sleep (1000);

         IButton Run_Workoffset = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.VerticalToolbar",
            WPFControlText = ""
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 4
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Run_Workoffset.Click ();
         Thread.Sleep (1000);

         // To change work offset mode

         IRadioButton offset_machinezero = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.WorkOffsetDialog"
         }, 2).Find<IRadioButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.RadioButton",
            WPFControlText = "Machine zero point"
         }.Add ("GroupName", ""), 5);
         offset_machinezero.Click ();
         Thread.Sleep (2000);

         // To confirm the work offset mode

         IControl Confirm_machinezero = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.WorkOffsetDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 2
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Confirm_machinezero.Click ();
         Thread.Sleep (1000);

         IControl offset_popup = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.PromptBox"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         }, 4);
         offset_popup.Click ();
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
      public void T5_004_ReentryPoint () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         IControl RUNpage = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Run"
         }, 6);
         RUNpage.Click ();
         Thread.Sleep (1000);

         // Re-entry point

         IButton RUN_reentry = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.VerticalToolbar",
            WPFControlText = ""
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 5
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         RUN_reentry.Click ();
         Thread.Sleep (1000);

         IButton blockinput = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.BlockSearchDialog"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.DockPanel",
            WPFControlOrdinalNo = 1
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.DockPanel",
            WPFControlOrdinalNo = 1
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 1
         }, 3).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         blockinput.Click ();
         Thread.Sleep (1000);

         IControl block_numericEdit = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.BlockSearchInputDlg"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericEdit",
            WPFControlOrdinalNo = 1
         }, 3);
         block_numericEdit.Click ();
         Thread.Sleep (1000);

         IButton blockinputVAL_9 = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericKeyboard"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "9"
         }, 2);
         blockinputVAL_9.Click ();
         Thread.Sleep (2000);

         IControl blockinput_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.BlockSearchInputDlg"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 2
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         blockinput_done.Click ();
         Thread.Sleep (1000);

         // Goto function

         IButton GoTo = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.BlockSearchDialog"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.DockPanel",
            WPFControlOrdinalNo = 1
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.DockPanel",
            WPFControlOrdinalNo = 1
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 2
         }, 3).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         GoTo.Click ();
         Thread.Sleep (1000);

         IControl GoTo_move = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.GoToOptionsDlg"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 1
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         GoTo_move.DblClick ();
         Thread.Sleep (1000);
         GoTo_move.DblClick ();
         Thread.Sleep (1000);
         GoTo_move.DblClick ();
         Thread.Sleep (2000);

         IRadioButton GoTo_contour = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.GoToOptionsDlg"
         }, 2).Find<IRadioButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.RadioButton",
            WPFControlText = "contour"
         }.Add ("GroupName", ""), 4);
         GoTo_contour.Click ();


         IControl GoTo_move1 = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.GoToOptionsDlg"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 1
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         GoTo_move1.DblClick ();
         Thread.Sleep (1000);
         GoTo_move1.DblClick ();
         Thread.Sleep (1000);
         GoTo_move1.DblClick ();
         Thread.Sleep (2000);

         // To save re-entry

         IButton Save_Reentry = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.BlockSearchDialog"
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
         Save_Reentry.Click ();
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
      public void T5_005_SpeedOverride () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         IControl RUNpage = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Run"
         }, 6);
         RUNpage.Click ();
         Thread.Sleep (1000);

         // To select speed override

         IButton speed_override = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.VerticalToolbar",
            WPFControlText = ""
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 6
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         speed_override.Click ();

         ITrackBarReal override_slider = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.SpeedOverrideDialog"
         }, 2).Find<ITrackBarReal> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Slider"
         }, 2);
         override_slider.wPosition = 50;
         Thread.Sleep (2000);


         IControl increase_override = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.SpeedOverrideDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 5
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         increase_override.DblClick ();

         IControl decrease_override = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.SpeedOverrideDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 4
         }, 3).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         decrease_override.Click ();
         Thread.Sleep (1000);

         IWindow luxSurface = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IWindow> (new WinFormsPattern () {
            ClrFullClassName = "System.Windows.Forms.Integration.WinFormsAdapter",
            WndCaption = ""
         }, 2).Find<IWindow> (new WinFormsPattern () {
            WinFormsControlName = "LuxSurface"
         });
         luxSurface.Click ();
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
      public void T5_006_Display () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         IControl RUNpage = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Run"
         }, 6);
         RUNpage.Click ();
         Thread.Sleep (1000);

         // To select display option

         IButton RUN_display = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.VerticalToolbar",
            WPFControlText = ""
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 7
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         RUN_display.Click ();
         Thread.Sleep (1000);


         ICheckBox Sheetdisplay = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.DisplayDialog"
         }, 2).Find<ICheckBox> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.CheckBox",
            WPFControlText = "Sheet"
         }, 2);
         Sheetdisplay.Click ();
         Thread.Sleep (1000);
         Sheetdisplay.Click ();
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
      public void T5_007_Status () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

          IControl RUNpage = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Run"
         }, 6);
         RUNpage.Click ();
         Thread.Sleep (1000);

         // To view program status

         IButton Runstatus = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 8
         }, 8).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Runstatus.Click ();
         Thread.Sleep (1000);

         IControl Machinestatus = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.MachineInfo"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabItem",
            WPFControlText = "Machine status"
         });
         Machinestatus.Click ();
         Thread.Sleep (1000);

         IButton statusreset = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.MachineInfo"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "Reset",
            WPFControlOrdinalNo = 1
         }, 2);
         statusreset.Click ();
         Thread.Sleep (1000);

         //IWPFPasswordEdit Status_passwordBox = Driver.Find<IProcess> (new ProcessPattern () {
         //   ProcessName = "Vulcan"
         //}).Find<IControl> (new WPFPattern () {
         //   ClrFullClassName = "Vulcan.AuthenticationDlg"
         //}, 2).Find<IWPFPasswordEdit> (new WPFPattern () {
         //   ClrFullClassName = "System.Windows.Controls.PasswordBox"
         //}, 3);
         //Status_passwordBox.wText = "600119";


         IControl Resetdone = Driver.Find<IProcess> (new ProcessPattern () {
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
         Resetdone.Click ();
         Thread.Sleep (2000);

         IControl Resetpopup = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.PromptBox"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         }, 4);
         Resetpopup.Click ();
         Thread.Sleep (1000);

         IControl Processmonitor = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.MachineInfo"
         }, 2).Find<ITabControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabControl"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TabItem",
            WPFControlText = "Process monitor"
         });
         Processmonitor.Click ();
         Thread.Sleep (1000);

         IButton Runstatus_done = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.MachineInfo"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         }, 5);
         Runstatus_done.Click ();
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
      public void T5_008_ProgramCtrls () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         IControl RUNpage = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Run"
         }, 6);
         RUNpage.Click ();
         Thread.Sleep (1000);

         // To display program controls

         IButton ProgControls = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 9
         }, 8).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         ProgControls.Click ();
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

      static string processName = @"C:\Program Files\Metamation\Vulcan\Vulcan.exe";
   }
}
