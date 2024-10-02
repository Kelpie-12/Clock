namespace Clock.Forms
{
	partial class FormStopwatch
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
			this.StopwatchLabel = new System.Windows.Forms.Label();
			this.startButton = new Clock.RoundButton();
			this.stopButton = new Clock.RoundButton();
			this.resetButton = new Clock.RoundButton();
			this.SuspendLayout();
			// 
			// StopwatchLabel
			// 
			this.StopwatchLabel.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StopwatchLabel.ForeColor = System.Drawing.Color.White;
			this.StopwatchLabel.Location = new System.Drawing.Point(-7, 71);
			this.StopwatchLabel.Name = "StopwatchLabel";
			this.StopwatchLabel.Size = new System.Drawing.Size(530, 120);
			this.StopwatchLabel.TabIndex = 0;
			this.StopwatchLabel.Text = "00:00:00:00";
			// 
			// startButton
			// 
			this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(151)))));
			this.startButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(151)))));
			this.startButton.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.startButton.BorderRadius = 20;
			this.startButton.BorderSize = 0;
			this.startButton.FlatAppearance.BorderSize = 0;
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.startButton.ForeColor = System.Drawing.Color.White;
			this.startButton.Location = new System.Drawing.Point(18, 283);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(150, 40);
			this.startButton.TabIndex = 1;
			this.startButton.Text = "Start";
			this.startButton.TextColor = System.Drawing.Color.White;
			this.startButton.UseVisualStyleBackColor = false;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// stopButton
			// 
			this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(86)))), ((int)(((byte)(91)))));
			this.stopButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(86)))), ((int)(((byte)(91)))));
			this.stopButton.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.stopButton.BorderRadius = 20;
			this.stopButton.BorderSize = 0;
			this.stopButton.FlatAppearance.BorderSize = 0;
			this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stopButton.ForeColor = System.Drawing.Color.White;
			this.stopButton.Location = new System.Drawing.Point(185, 283);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(150, 40);
			this.stopButton.TabIndex = 2;
			this.stopButton.Text = "Stop";
			this.stopButton.TextColor = System.Drawing.Color.White;
			this.stopButton.UseVisualStyleBackColor = false;
			this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(196)))));
			this.resetButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(196)))));
			this.resetButton.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.resetButton.BorderRadius = 20;
			this.resetButton.BorderSize = 0;
			this.resetButton.FlatAppearance.BorderSize = 0;
			this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.resetButton.ForeColor = System.Drawing.Color.White;
			this.resetButton.Location = new System.Drawing.Point(352, 283);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(150, 40);
			this.resetButton.TabIndex = 3;
			this.resetButton.Text = "Reset";
			this.resetButton.TextColor = System.Drawing.Color.White;
			this.resetButton.UseVisualStyleBackColor = false;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// FormStopwatch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
			this.ClientSize = new System.Drawing.Size(520, 379);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.StopwatchLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormStopwatch";
			this.Text = "Stopwatch";
			this.Load += new System.EventHandler(this.FormStopwatch_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label StopwatchLabel;
		private RoundButton startButton;
		private RoundButton stopButton;
		private RoundButton resetButton;
	}
}