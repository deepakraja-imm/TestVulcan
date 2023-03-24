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
   public class SetupPageTest : UnitTestClassBase {
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
      public void T1_001_HomeTheAxis () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         // To select setup page

         IControl Setup_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Setup"
         }, 6);
         Setup_page.Click ();
         Thread.Sleep (1000);

         // To move the +X axis

         IControl Xaxis_move1mm = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 11
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Xaxis_move1mm.Click ();

         IControl Xaxis_move5mm = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 10
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Xaxis_move5mm.Click ();

         IControl Xaxis_move10mm = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 9
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Xaxis_move10mm.Click ();
         Thread.Sleep (2000);

         // To move the +Y axis

         IControl Yaxis_move1mm = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 3
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Yaxis_move1mm.Click ();

         IControl Yaxis_move5mm = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 2
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Yaxis_move5mm.Click ();

         IControl Yaxis_move10mm = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            WPFControlName = "MainWindow"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.DockPanel"
         }).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 1
         }, 4).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Yaxis_move10mm.Click ();
         Thread.Sleep (2000);

         // To move the +Z axis

         IControl Zaxis_move1mm = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 19
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Zaxis_move1mm.Click ();

         IControl Zaxis_move5mm = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 18
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Zaxis_move5mm.Click ();

         IControl Zaxis_move10mm = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 17
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         Zaxis_move10mm.Click ();
         Thread.Sleep (2000);

         // To select homing button

         IControl Homing = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "homing"
         }, 10);
         Homing.Click ();
         Thread.Sleep (3000);

         // To home X axis manually

         IRadioButton Home_Xaxis = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomingDialog"
         }, 2).Find<IRadioButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.RadioButton",
            WPFControlText = "X"
         }.Add ("GroupName", ""), 4);
         Home_Xaxis.Click ();
         Thread.Sleep (1000);

         IButton Start_homing = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomingDialog"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "start"
         }, 3);
         Start_homing.Click ();
         Thread.Sleep (2000);
         //Homing.Click ();
         //Thread.Sleep (2000);


         // to target the Y axis position

         IControl Target_Yaxis = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericEdit",
            WPFControlOrdinalNo = 2
         }, 6);
         Target_Yaxis.DblClick ();
         Thread.Sleep (1000);

         IButton Targetvalue_1 = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericKeyboard"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "1"
         }, 2);
         Targetvalue_1.Click ();

         IButton Targetvalue_00 = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericKeyboard"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "0"
         }, 2);
         Targetvalue_00.Click ();
         Targetvalue_00.Click ();
         Thread.Sleep (1000);

         IButton Equals = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericKeyboard"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "="
         }, 2);
         Equals.Click ();

         IControl StartTarget = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "",
            WPFControlOrdinalNo = 7
         }, 6).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Image"
         });
         StartTarget.Click ();
         Thread.Sleep (2000);
         Homing.Click ();
         Thread.Sleep (1000);

         IRadioButton Auto_homing = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomingDialog"
         }, 2).Find<IRadioButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.RadioButton",
            WPFControlText = "Automatic"
         }.Add ("GroupName", ""), 2);
         Auto_homing.Click ();
         Thread.Sleep (1000);
         Start_homing.Click ();
         Thread.Sleep (2000);
         Homing.Click ();
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
      public void T1_002_Workoffset () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         IControl Setup_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Setup"
         }, 6);
         Setup_page.Click ();
         Thread.Sleep (1000);

         // To select work offset

         IControl Setup_Workoffset = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 2
         }, 7).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.StackPanel"
         }, 2);
         Setup_Workoffset.Click ();
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

         IControl Confirm_done = Driver.Find<IProcess> (new ProcessPattern () {
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
         Confirm_done.Click ();
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
         Setup_Workoffset.Click ();
         Thread.Sleep (1000);

         // To change work offset mode

         IRadioButton offset_manual = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.WorkOffsetDialog"
         }, 2).Find<IRadioButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.RadioButton",
            WPFControlText = "Manual"
         }.Add ("GroupName", ""), 5);
         offset_manual.Click ();
         Thread.Sleep (2000);

         // To Select X value

         IControl Select_xvalue = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.WorkOffsetDialog"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericEdit",
            WPFControlOrdinalNo = 1
         }, 3);
         Select_xvalue.Click ();
         Thread.Sleep (1000);

         // To enter X value

         IButton Enter_xvalue = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericKeyboard"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "1"
         }, 2);
         Enter_xvalue.Click ();

         IButton Enter_xvalue1 = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericKeyboard"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "0"
         }, 2);
         Enter_xvalue1.Click ();
         Thread.Sleep (1000);

         IButton Equals = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "CUILib.NumericKeyboard"
         }, 2).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = "="
         }, 2);
         Equals.Click ();
         Thread.Sleep (1000);
         Confirm_done.DblClick ();
         Thread.Sleep (1000);
         offset_popup.Click ();

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
      public void T1_003_SpeedOverride () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         IControl Setup_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Setup"
         }, 6);
         Setup_page.Click ();
         Thread.Sleep (1000);

         // To select speed override

         IButton speed_override = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 3
         }, 7).Find<IButton> (new WPFPattern () {
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
         Thread.Sleep (1000);

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
         Thread.Sleep (2000);
         speed_override.Click ();

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
            WPFControlText = "Close Vulcan"
         }, 2);
         CloseVulcan.Click ();
      }

          [TestMethod]
      public void T1_004_Settings () {
         Driver.Applications.Run (processName);
         Thread.Sleep (3000);

         IControl Setup_page = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.TextBlock",
            WPFControlText = "Setup"
         }, 6);
         Setup_page.Click ();
         Thread.Sleep (1000);

         // To view the jog settings

         IButton Jogsetting = Driver.Find<IProcess> (new ProcessPattern () {
            ProcessName = "Vulcan"
         }).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "Vulcan.HomePage"
         }, 2).Find<IControl> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Border",
            WPFControlOrdinalNo = 4
         }, 7).Find<IButton> (new WPFPattern () {
            ClrFullClassName = "System.Windows.Controls.Button",
            WPFControlText = ""
         });
         Jogsetting.Click ();
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
