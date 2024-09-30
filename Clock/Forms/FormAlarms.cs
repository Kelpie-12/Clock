using Clock.Custom_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock.Forms
{
	public partial class FormAlarms : Form
	{
		public FormAlarms()
		{
			InitializeComponent();
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			checkedListBox1.Items.Add(new ToggleButton());
			panel1.CreateControl();
			ToggleButton a= new ToggleButton();	
			
		}
	}
}
