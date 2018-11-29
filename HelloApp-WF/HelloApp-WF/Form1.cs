using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloApp_WF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Text = "Hello world!";
			this.BackColor = Color.Aqua;
			this.Width = 250;
			this.Height = 250;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello");
		}
	}
}
