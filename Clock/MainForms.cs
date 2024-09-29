using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		async void roundButtonUp_Click(object sender, EventArgs e)
		{
			for (int i = roundButtonUp.Location.X; i < 345; i++)
			{
				roundButtonUp.Location = new Point(i + 1, roundButtonUp.Location.Y);
				await Task.Delay(1);
			}
			roundButtonBack.BackColor = Color.Green;
		}
	}
}
