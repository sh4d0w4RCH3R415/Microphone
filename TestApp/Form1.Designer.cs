
namespace TestApp
{
	partial class Form1
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
			this.btnDisplayMicInfo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnDisplayMicInfo
			// 
			this.btnDisplayMicInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDisplayMicInfo.Location = new System.Drawing.Point(143, 150);
			this.btnDisplayMicInfo.Name = "btnDisplayMicInfo";
			this.btnDisplayMicInfo.Size = new System.Drawing.Size(172, 35);
			this.btnDisplayMicInfo.TabIndex = 0;
			this.btnDisplayMicInfo.Text = "Display Microphone Information";
			this.btnDisplayMicInfo.UseVisualStyleBackColor = true;
			this.btnDisplayMicInfo.Click += new System.EventHandler(this.btnDisplayMicInfo_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 344);
			this.Controls.Add(this.btnDisplayMicInfo);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnDisplayMicInfo;
	}
}

