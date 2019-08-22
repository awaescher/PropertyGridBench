using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1913
{
	public partial class TestForm : XtraForm
	{
		public TestForm()
		{
			InitializeComponent();
		}

		private void PropertyGridControl1_CustomPropertyDescriptors(object sender, DevExpress.XtraVerticalGrid.Events.CustomPropertyDescriptorsEventArgs e)
		{
			System.Threading.Thread.Sleep(1000);
		}

		private void ButtonLoad_Click(object sender, EventArgs e)
		{
			var sw = Stopwatch.StartNew();
			propertyGridControl1.SelectedObject = this;
			label1.Text = $"Took {sw.ElapsedMilliseconds / 1000} seconds.";
		}
	}
}
