namespace Clock
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonSetting = new System.Windows.Forms.Button();
			this.buttonStopwatch = new System.Windows.Forms.Button();
			this.buttonTimer = new System.Windows.Forms.Button();
			this.buttonAlarm = new System.Windows.Forms.Button();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.btnHome = new System.Windows.Forms.PictureBox();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.lblTitleChildForm = new System.Windows.Forms.Label();
			this.panelShafow = new System.Windows.Forms.Panel();
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.homeTime = new System.Windows.Forms.Label();
			this.timerHome = new System.Windows.Forms.Timer(this.components);
			this.panelMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			this.panelTitleBar.SuspendLayout();
			this.panelDesktop.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.panelMenu.Controls.Add(this.buttonClose);
			this.panelMenu.Controls.Add(this.buttonSetting);
			this.panelMenu.Controls.Add(this.buttonStopwatch);
			this.panelMenu.Controls.Add(this.buttonTimer);
			this.panelMenu.Controls.Add(this.buttonAlarm);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(200, 450);
			this.panelMenu.TabIndex = 4;
			// 
			// buttonClose
			// 
			this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonClose.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonClose.FlatAppearance.BorderSize = 0;
			this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonClose.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.buttonClose.Location = new System.Drawing.Point(0, 340);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.buttonClose.Size = new System.Drawing.Size(200, 60);
			this.buttonClose.TabIndex = 10;
			this.buttonClose.Text = "Close";
			this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonSetting
			// 
			this.buttonSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.buttonSetting.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonSetting.FlatAppearance.BorderSize = 0;
			this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSetting.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.buttonSetting.Location = new System.Drawing.Point(0, 280);
			this.buttonSetting.Name = "buttonSetting";
			this.buttonSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.buttonSetting.Size = new System.Drawing.Size(200, 60);
			this.buttonSetting.TabIndex = 9;
			this.buttonSetting.Text = "Setting";
			this.buttonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSetting.UseVisualStyleBackColor = false;
			this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
			// 
			// buttonStopwatch
			// 
			this.buttonStopwatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.buttonStopwatch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonStopwatch.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonStopwatch.FlatAppearance.BorderSize = 0;
			this.buttonStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonStopwatch.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.buttonStopwatch.Location = new System.Drawing.Point(0, 220);
			this.buttonStopwatch.Name = "buttonStopwatch";
			this.buttonStopwatch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.buttonStopwatch.Size = new System.Drawing.Size(200, 60);
			this.buttonStopwatch.TabIndex = 7;
			this.buttonStopwatch.Text = "Stopwatch";
			this.buttonStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonStopwatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonStopwatch.UseVisualStyleBackColor = false;
			this.buttonStopwatch.Click += new System.EventHandler(this.buttonStopwatch_Click);
			// 
			// buttonTimer
			// 
			this.buttonTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.buttonTimer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonTimer.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonTimer.FlatAppearance.BorderSize = 0;
			this.buttonTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.buttonTimer.Location = new System.Drawing.Point(0, 160);
			this.buttonTimer.Name = "buttonTimer";
			this.buttonTimer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.buttonTimer.Size = new System.Drawing.Size(200, 60);
			this.buttonTimer.TabIndex = 6;
			this.buttonTimer.Text = "Timer";
			this.buttonTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonTimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonTimer.UseVisualStyleBackColor = false;
			this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
			// 
			// buttonAlarm
			// 
			this.buttonAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.buttonAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAlarm.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonAlarm.FlatAppearance.BorderSize = 0;
			this.buttonAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAlarm.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.buttonAlarm.Location = new System.Drawing.Point(0, 100);
			this.buttonAlarm.Name = "buttonAlarm";
			this.buttonAlarm.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.buttonAlarm.Size = new System.Drawing.Size(200, 60);
			this.buttonAlarm.TabIndex = 5;
			this.buttonAlarm.Text = "Alarm";
			this.buttonAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonAlarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonAlarm.UseVisualStyleBackColor = false;
			this.buttonAlarm.Click += new System.EventHandler(this.buttonAlarm_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.Controls.Add(this.btnHome);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.panelLogo.Size = new System.Drawing.Size(200, 100);
			this.panelLogo.TabIndex = 0;
			// 
			// btnHome
			// 
			this.btnHome.Image = global::Clock.Properties.Resources.LogoPanel;
			this.btnHome.Location = new System.Drawing.Point(13, 12);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(164, 70);
			this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnHome.TabIndex = 0;
			this.btnHome.TabStop = false;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(520, 58);
			this.panelTitleBar.TabIndex = 5;
			this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
			// 
			// lblTitleChildForm
			// 
			this.lblTitleChildForm.AutoSize = true;
			this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTitleChildForm.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.lblTitleChildForm.Location = new System.Drawing.Point(25, 24);
			this.lblTitleChildForm.Name = "lblTitleChildForm";
			this.lblTitleChildForm.Size = new System.Drawing.Size(52, 20);
			this.lblTitleChildForm.TabIndex = 0;
			this.lblTitleChildForm.Text = "Home";
			// 
			// panelShafow
			// 
			this.panelShafow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
			this.panelShafow.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelShafow.Location = new System.Drawing.Point(200, 58);
			this.panelShafow.Name = "panelShafow";
			this.panelShafow.Size = new System.Drawing.Size(520, 13);
			this.panelShafow.TabIndex = 6;
			// 
			// panelDesktop
			// 
			this.panelDesktop.Controls.Add(this.homeTime);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(200, 71);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(520, 379);
			this.panelDesktop.TabIndex = 7;
			// 
			// homeTime
			// 
			this.homeTime.AutoSize = true;
			this.homeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.homeTime.Location = new System.Drawing.Point(158, 136);
			this.homeTime.Name = "homeTime";
			this.homeTime.Size = new System.Drawing.Size(0, 73);
			this.homeTime.TabIndex = 0;
			// 
			// timerHome
			// 
			this.timerHome.Enabled = true;
			this.timerHome.Interval = 500;
			this.timerHome.Tick += new System.EventHandler(this.timerHome_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(720, 450);
			this.ControlBox = false;
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelShafow);
			this.Controls.Add(this.panelTitleBar);
			this.Controls.Add(this.panelMenu);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.panelMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			this.panelDesktop.ResumeLayout(false);
			this.panelDesktop.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Button buttonAlarm;
		private System.Windows.Forms.Button buttonSetting;
		private System.Windows.Forms.Button buttonStopwatch;
		private System.Windows.Forms.Button buttonTimer;
		private System.Windows.Forms.PictureBox btnHome;
		private System.Windows.Forms.Panel panelTitleBar;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Panel panelShafow;
		private System.Windows.Forms.Panel panelDesktop;
		private System.Windows.Forms.Label lblTitleChildForm;
		private System.Windows.Forms.Label homeTime;
		private System.Windows.Forms.Timer timerHome;
	}
}

