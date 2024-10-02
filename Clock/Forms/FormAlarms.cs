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

		private void roundButton1_Click(object sender, EventArgs e)
		{
	
		}

		private void buttonAddAlarms_Click(object sender, EventArgs e)
		{


			ToggleButton a = new ToggleButton(changeCheck1);		
			int countControl = CountControl(panelAlarms);
			a.Name = $"Check{CountControl(panelAlarms)+1}";
			a.Checked = false;
			
			a.Location = new Point(changeCheck1.Location.X, changeCheck1.Location.Y+ countControl*50);
			panelAlarms.Controls.Add(a);

			Label label =  new Label(); 
			label.Location = new Point(Alarm1.Location.X, Alarm1.Location.Y + countControl * 50);
			label.Name = $"Alarm{CountControl(panelAlarms) + 1}";
			label.Text = DateTime.Now.ToString("hh:mm:ss tt");
			//label.Font.Size 
			label.Font = new Font("Microsoft Sans Serif", 18);
			panelAlarms.Controls.Add(label);
		


		}
		private int CountControl(Panel panel)
		{
			int count = 0;
			foreach(Control c in panel.Controls) 
			{
				if (c.GetType() == typeof(ToggleButton))
					count++;
			}
			return count;
		}
	}
}
