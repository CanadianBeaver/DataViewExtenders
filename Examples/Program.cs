﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Examples
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      var mForm = new MainForm();
      CBComponents.Forms.FormServices.MainWindow = mForm;
      Application.Run(mForm);
    }
  }
}
