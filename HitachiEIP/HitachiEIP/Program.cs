﻿using System;
using System.Windows.Forms;
using EIP_Base;

namespace H_EIP {
   static class Program {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new Browser("192.168.0.1", 44818, @"c:\Temp\EIP"));
      }
   }
}
