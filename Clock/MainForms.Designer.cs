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
			this.LabelTime = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.roundButtonUp = new Clock.RoundButton();
			this.roundButtonBack = new Clock.RoundButton();
			this.SuspendLayout();
			// 
			// LabelTime
			// 
			this.LabelTime.AutoSize = true;
			this.LabelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelTime.Location = new System.Drawing.Point(115, 6);
			this.LabelTime.Name = "LabelTime";
			this.LabelTime.Size = new System.Drawing.Size(174, 73);
			this.LabelTime.TabIndex = 0;
			this.LabelTime.Text = "Time";
			this.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(317, 249);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// roundButtonUp
			// 
			this.roundButtonUp.BackColor = System.Drawing.Color.Snow;
			this.roundButtonUp.BackgroundColor = System.Drawing.Color.Snow;
			this.roundButtonUp.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.roundButtonUp.BorderRadius = 20;
			this.roundButtonUp.BorderSize = 0;
			this.roundButtonUp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.roundButtonUp.FlatAppearance.BorderSize = 0;
			this.roundButtonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.roundButtonUp.ForeColor = System.Drawing.Color.White;
			this.roundButtonUp.Location = new System.Drawing.Point(299, 109);
			this.roundButtonUp.Name = "roundButtonUp";
			this.roundButtonUp.Size = new System.Drawing.Size(40, 40);
			this.roundButtonUp.TabIndex = 5;
			this.roundButtonUp.TextColor = System.Drawing.Color.White;
			this.roundButtonUp.UseVisualStyleBackColor = false;
			this.roundButtonUp.Click += new System.EventHandler(this.roundButtonUp_Click);
			// 
			// roundButtonBack
			// 
			this.roundButtonBack.BackColor = System.Drawing.Color.DimGray;
			this.roundButtonBack.BackgroundColor = System.Drawing.Color.DimGray;
			this.roundButtonBack.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.roundButtonBack.BorderRadius = 25;
			this.roundButtonBack.BorderSize = 0;
			this.roundButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.roundButtonBack.FlatAppearance.BorderSize = 0;
			this.roundButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.roundButtonBack.ForeColor = System.Drawing.Color.White;
			this.roundButtonBack.Location = new System.Drawing.Point(292, 104);
			this.roundButtonBack.Name = "roundButtonBack";
			this.roundButtonBack.Size = new System.Drawing.Size(100, 50);
			this.roundButtonBack.TabIndex = 4;
			this.roundButtonBack.TextColor = System.Drawing.Color.White;
			this.roundButtonBack.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(404, 284);
			this.ControlBox = false;
			this.Controls.Add(this.roundButtonUp);
			this.Controls.Add(this.roundButtonBack);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.LabelTime);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LabelTime;
		private System.Windows.Forms.Button button1;
		private RoundButton roundButtonBack;
		private RoundButton roundButtonUp;
	}
}

