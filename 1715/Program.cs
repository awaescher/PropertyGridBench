﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1715
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			DevExpress.Skins.SkinManager.SetDPIAware();
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new TestForm());
		}
	}
}
