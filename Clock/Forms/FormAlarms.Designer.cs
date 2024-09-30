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
			this.label1 = new System.Windows.Forms.Label();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toggleButton1 = new Clock.Custom_Controls.ToggleButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(85, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ALARMS";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "1234",
            "12345",
            "234"});
			this.checkedListBox1.Location = new System.Drawing.Point(66, 138);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(275, 150);
			this.checkedListBox1.TabIndex = 1;
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(261, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 100);
			this.panel1.TabIndex = 3;
			// 
			// toggleButton1
			// 
			this.toggleButton1.Checked = true;
			this.toggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toggleButton1.Location = new System.Drawing.Point(241, 183);
			this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
			this.toggleButton1.Name = "toggleButton1";
			this.toggleButton1.OffBackColor = System.Drawing.Color.Black;
			this.toggleButton1.OffToggleColor = System.Drawing.Color.IndianRed;
			this.toggleButton1.OnBackColor = System.Drawing.Color.MidnightBlue;
			this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
			this.toggleButton1.Size = new System.Drawing.Size(100, 40);
			this.toggleButton1.TabIndex = 2;
			this.toggleButton1.Text = "toggleButton1";
			this.toggleButton1.UseVisualStyleBackColor = true;
			// 
			// FormAlarms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 379);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toggleButton1);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAlarms";
			this.Text = "Alarms";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private Custom_Controls.ToggleButton toggleButton1;
		private System.Windows.Forms.Panel panel1;
	}
}