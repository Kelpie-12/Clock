﻿using Clock.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		private Button currentBtn;
		private Panel leftBorderBtn;
		private Form currentChildForm;
		public MainForm()
		{
			InitializeComponent();
			homeTime.Text = DateTime.Now.ToString("HH:mm:ss");
			leftBorderBtn = new Panel();
			leftBorderBtn.Size = new Size(7, 60);
			panelMenu.Controls.Add(leftBorderBtn);
			this.Text = string.Empty;
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
		}
		private struct RGBColors
		{
			public static Color color1 = Color.FromArgb(172, 126, 241);
			public static Color color2 = Color.FromArgb(249, 118, 176);
			public static Color color3 = Color.FromArgb(253, 138, 114);
			public static Color color4 = Color.FromArgb(95, 77, 221);
			public static Color color5 = Color.FromArgb(249, 88, 155);
			public static Color color6 = Color.FromArgb(24, 161, 251);
		}

		private void ActivateButton(object senderBtn, Color color) 
		{
			if (senderBtn != null)
			{
			DisableButton();
				//Button
				currentBtn = (Button)senderBtn;
				currentBtn.BackColor = Color.FromArgb(37, 36, 81);
				currentBtn.ForeColor = color;
				currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				//currentBtn.IconColor = color;
				currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currentBtn.ImageAlign = ContentAlignment.MiddleRight;
				//Left border button
				leftBorderBtn.BackColor = color;
				leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
				leftBorderBtn.Visible = true;
				leftBorderBtn.BringToFront();
				//Current Child Form Icon
				//iconCurrentChildForm.IconChar = currentBtn.IconChar;
				//iconCurrentChildForm.IconColor = color;
			}
		}
		private void DisableButton()
		{
			if (currentBtn != null)
			{
				currentBtn.BackColor = Color.FromArgb(31, 30, 68);
				currentBtn.ForeColor = Color.WhiteSmoke;
				currentBtn.TextAlign = ContentAlignment.MiddleLeft;
				//currentBtn.IconColor = Color.Gainsboro;
				currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			}
		}
		private void OpenChildForm(Form childForm)
		{
			if (currentChildForm != null)
			{
				currentChildForm.Close();
			}
			currentChildForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle=FormBorderStyle.None;
			childForm.Dock=DockStyle.Fill;
			panelDesktop.Controls.Add(childForm);
			panelDesktop.Tag= childForm;
			childForm.BringToFront();
			childForm.Show();
			lblTitleChildForm.Text = childForm.Text;

		}

		private void buttonAlarm_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new FormAlarms());
		}

		private void buttonTimer_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color2);
			OpenChildForm(new FormTimer());
		}

		private void buttonStopwatch_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color3);
			OpenChildForm(new FormStopwatch());
		}

		private void buttonSetting_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color4);
			OpenChildForm(new FormSettings());
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			if (currentChildForm!=null)
				currentChildForm.Close();
			Reset();
		}
		private void Reset()
		{
			DisableButton();
			leftBorderBtn.Visible = false;
			lblTitleChildForm.Text = "Home";
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void timerHome_Tick(object sender, EventArgs e)
		{
			homeTime.Text = DateTime.Now.ToString("HH:mm:ss");
		}
	}
}
