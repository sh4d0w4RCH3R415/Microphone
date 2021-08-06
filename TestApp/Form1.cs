using Microphone;
using System;
using System.Windows.Forms;

namespace TestApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnDisplayMicInfo_Click(object sender, EventArgs e)
		{
			Mic mic = new Mic("A");
			MessageBox.Show("Information About Your Connected Microphone:\n\n" +
				"Device Name: " + mic.Name + "\n" +
				"Device Name (Friendly): " + mic.FriendlyName + "\n" +
				"Volume (Int): " + mic.Volume + "\n" +
				"Volume (Float): " + mic.VolumeF, "Microphone Information",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
