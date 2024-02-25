using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingDemo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		//Windows form applications run on a single thread.
		private void btnProcess1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("İşlem 1 çalıştı");
		}

		private void btnProcess2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("İşlem 2 çalıştı");
		}
	}
}
