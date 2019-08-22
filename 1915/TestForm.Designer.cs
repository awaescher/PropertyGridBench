namespace _1915
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
			this.buttonLoad = new DevExpress.XtraEditors.SimpleButton();
			this.propertyGridControl1 = new PropertyGridBench.PropertyGridControlEx();
			this.label1 = new DevExpress.XtraEditors.LabelControl();
			this.toggleFilterWorkaround = new DevExpress.XtraEditors.ToggleSwitch();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleFilterWorkaround.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonLoad
			// 
			this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLoad.Location = new System.Drawing.Point(251, 12);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(85, 32);
			this.buttonLoad.TabIndex = 3;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
			// 
			// propertyGridControl1
			// 
			this.propertyGridControl1.FindPanelVisible = true;
			this.propertyGridControl1.Location = new System.Drawing.Point(0, 94);
			this.propertyGridControl1.Name = "propertyGridControl1";
			this.propertyGridControl1.OptionsFind.Visibility = DevExpress.XtraVerticalGrid.FindPanelVisibility.Always;
			this.propertyGridControl1.Size = new System.Drawing.Size(348, 594);
			this.propertyGridControl1.TabIndex = 0;
			this.propertyGridControl1.CustomPropertyDescriptors += new DevExpress.XtraVerticalGrid.Events.CustomPropertyDescriptorsEventHandler(this.PropertyGridControl1_CustomPropertyDescriptors);
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
			this.label1.Size = new System.Drawing.Size(233, 32);
			this.label1.TabIndex = 4;
			this.label1.Text = "Click on \"Load\" and search for \"fon\" (for Font)";
			// 
			// toggleFilterWorkaround
			// 
			this.toggleFilterWorkaround.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.toggleFilterWorkaround.Location = new System.Drawing.Point(250, 53);
			this.toggleFilterWorkaround.Name = "toggleFilterWorkaround";
			this.toggleFilterWorkaround.Properties.AutoWidth = true;
			this.toggleFilterWorkaround.Properties.OffText = "Off";
			this.toggleFilterWorkaround.Properties.OnText = "On";
			this.toggleFilterWorkaround.Properties.ShowText = false;
			this.toggleFilterWorkaround.Size = new System.Drawing.Size(84, 28);
			this.toggleFilterWorkaround.TabIndex = 5;
			this.toggleFilterWorkaround.Toggled += new System.EventHandler(this.ToggleFilterWorkaround_Toggled);
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl1.Appearance.Options.UseTextOptions = true;
			this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl1.Location = new System.Drawing.Point(12, 50);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(233, 34);
			this.labelControl1.TabIndex = 6;
			this.labelControl1.Text = "Use filter workaround";
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 688);
			this.Controls.Add(this.toggleFilterWorkaround);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonLoad);
			this.Controls.Add(this.propertyGridControl1);
			this.Controls.Add(this.labelControl1);
			this.Name = "TestForm";
			this.Text = "PropertyGrid 19.1.5";
			((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toggleFilterWorkaround.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PropertyGridBench.PropertyGridControlEx propertyGridControl1;
		private DevExpress.XtraEditors.SimpleButton buttonLoad;
		private DevExpress.XtraEditors.LabelControl label1;
		private DevExpress.XtraEditors.ToggleSwitch toggleFilterWorkaround;
		private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}

