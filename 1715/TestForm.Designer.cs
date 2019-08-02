namespace _1715
{
	partial class TestForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.propertyGridControl1 = new PropertyGridBench.PropertyGridControlEx();
			this.buttonLoad = new DevExpress.XtraEditors.SimpleButton();
			this.label1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// propertyGridControl1
			// 
			this.propertyGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.propertyGridControl1.FindPanelVisible = true;
			this.propertyGridControl1.Location = new System.Drawing.Point(0, 55);
			this.propertyGridControl1.Name = "propertyGridControl1";
			this.propertyGridControl1.OptionsFind.Visibility = DevExpress.XtraVerticalGrid.FindPanelVisibility.Always;
			this.propertyGridControl1.Size = new System.Drawing.Size(338, 621);
			this.propertyGridControl1.TabIndex = 1;
			// 
			// buttonLoad
			// 
			this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLoad.Location = new System.Drawing.Point(241, 12);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(85, 32);
			this.buttonLoad.TabIndex = 2;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Appearance.Options.UseTextOptions = true;
			this.label1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.label1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 32);
			this.label1.TabIndex = 3;
			this.label1.Text = "Click on \"Load\" and search for \"fon\" (for Font)";
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(338, 676);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonLoad);
			this.Controls.Add(this.propertyGridControl1);
			this.Name = "TestForm";
			this.Text = "PropertyGrid 17.1.5";
			((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private PropertyGridBench.PropertyGridControlEx propertyGridControl1;
		private DevExpress.XtraEditors.SimpleButton buttonLoad;
		private DevExpress.XtraEditors.LabelControl label1;
	}
}

