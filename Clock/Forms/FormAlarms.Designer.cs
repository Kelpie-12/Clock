namespace Clock.Forms
{
	partial class FormAlarms
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
			this.Alarm1 = new System.Windows.Forms.Label();
			this.panelAlarms = new System.Windows.Forms.Panel();
			this.buttonAddAlarms = new System.Windows.Forms.Button();
			this.buttonChenge = new Clock.RoundButton();
			this.changeCheck1 = new Clock.Custom_Controls.ToggleButton();
			this.panelAlarms.SuspendLayout();
			this.SuspendLayout();
			// 
			// Alarm1
			// 
			this.Alarm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Alarm1.Location = new System.Drawing.Point(40, 80);
			this.Alarm1.Name = "Alarm1";
			this.Alarm1.Size = new System.Drawing.Size(336, 40);
			this.Alarm1.TabIndex = 0;
			this.Alarm1.Text = "ALARMS";
			// 
			// panelAlarms
			// 
			this.panelAlarms.Controls.Add(this.buttonChenge);
			this.panelAlarms.Controls.Add(this.buttonAddAlarms);
			this.panelAlarms.Controls.Add(this.changeCheck1);
			this.panelAlarms.Controls.Add(this.Alarm1);
			this.panelAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelAlarms.Location = new System.Drawing.Point(0, 0);
			this.panelAlarms.Name = "panelAlarms";
			this.panelAlarms.Size = new System.Drawing.Size(520, 379);
			this.panelAlarms.TabIndex = 6;
			// 
			// buttonAddAlarms
			// 
			this.buttonAddAlarms.AutoSize = true;
			this.buttonAddAlarms.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAddAlarms.FlatAppearance.BorderSize = 0;
			this.buttonAddAlarms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddAlarms.ForeColor = System.Drawing.Color.MidnightBlue;
			this.buttonAddAlarms.Location = new System.Drawing.Point(435, 10);
			this.buttonAddAlarms.Name = "buttonAddAlarms";
			this.buttonAddAlarms.Size = new System.Drawing.Size(63, 65);
			this.buttonAddAlarms.TabIndex = 3;
			this.buttonAddAlarms.Text = "+";
			this.buttonAddAlarms.UseVisualStyleBackColor = true;
			this.buttonAddAlarms.Click += new System.EventHandler(this.buttonAddAlarms_Click);
			// 
			// buttonChenge
			// 
			this.buttonChenge.BackColor = System.Drawing.Color.MidnightBlue;
			this.buttonChenge.BackgroundColor = System.Drawing.Color.MidnightBlue;
			this.buttonChenge.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.buttonChenge.BorderRadius = 20;
			this.buttonChenge.BorderSize = 0;
			this.buttonChenge.FlatAppearance.BorderSize = 0;
			this.buttonChenge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonChenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonChenge.ForeColor = System.Drawing.Color.White;
			this.buttonChenge.Location = new System.Drawing.Point(30, 25);
			this.buttonChenge.Name = "buttonChenge";
			this.buttonChenge.Size = new System.Drawing.Size(150, 40);
			this.buttonChenge.TabIndex = 4;
			this.buttonChenge.Text = "Change";
			this.buttonChenge.TextColor = System.Drawing.Color.White;
			this.buttonChenge.UseVisualStyleBackColor = false;
			// 
			// changeCheck1
			// 
			this.changeCheck1.Location = new System.Drawing.Point(400, 80);
			this.changeCheck1.MinimumSize = new System.Drawing.Size(45, 22);
			this.changeCheck1.Name = "changeCheck1";
			this.changeCheck1.OffBackColor = System.Drawing.Color.MidnightBlue;
			this.changeCheck1.OffToggleColor = System.Drawing.Color.DarkGray;
			this.changeCheck1.OnBackColor = System.Drawing.Color.MidnightBlue;
			this.changeCheck1.OnToggleColor = System.Drawing.Color.Lime;
			this.changeCheck1.Size = new System.Drawing.Size(100, 40);
			this.changeCheck1.SolidStyle = true;
			this.changeCheck1.TabIndex = 2;
			this.changeCheck1.Text = "toggleButton1";
			this.changeCheck1.UseVisualStyleBackColor = true;
			// 
			// FormAlarms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 379);
			this.Controls.Add(this.panelAlarms);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAlarms";
			this.Text = "Alarms";
			this.panelAlarms.ResumeLayout(false);
			this.panelAlarms.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label Alarm1;
		private Custom_Controls.ToggleButton changeCheck1;
		private System.Windows.Forms.Panel panelAlarms;
		private System.Windows.Forms.Button buttonAddAlarms;
		private RoundButton buttonChenge;
	}
}