using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Clock.Forms
{
	public partial class FormStopwatch : Form
	{
		System.Timers.Timer timer;
		int h, m, s, ms;

		private void startButton_Click(object sender, EventArgs e)
		{
			timer.Start();
		}

		private void stopButton_Click(object sender, EventArgs e)
		{
			timer.Stop();	
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			timer.Stop();
			h=0; m=0; s=0; ms = 0;
			StopwatchLabel.Text = "00:00:00:00";
		}

		public FormStopwatch()
		{
			InitializeComponent();
		}

		private void FormStopwatch_Load(object sender, EventArgs e)
		{
			timer=new System.Timers.Timer();
			timer.Interval = 1;
			timer.Elapsed += OnTimerEvent;
		}

		private void OnTimerEvent(object sender, ElapsedEventArgs e)
		{
			Invoke(new Action(() => 
			{
				ms += 1;
				if (ms==100)
				{
					ms = 0;
					s += 1;
				}
				if (s==60)
				{
					s = 0;
					m += 1;
				}
				if (m==60)
				{
					m = 0;
					h += 1;
				}	
			StopwatchLabel.Text=string.Format("{0}:{1}:{2}:{3}",h.ToString().ToString().PadLeft(2,'0'), m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'), ms.ToString().ToString().PadLeft(2, '0'));
			}
			));
		}
	}
}
