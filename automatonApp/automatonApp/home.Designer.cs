﻿namespace automatonApp
{
	partial class home
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.lb_title = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(24, 67);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(275, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "START";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(90, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "deterministic finite automaton";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(81, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "nondeterministic finite automaton";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(22, 119);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(278, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "COMMING SOON";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// lb_title
			// 
			this.lb_title.AutoSize = true;
			this.lb_title.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_title.Location = new System.Drawing.Point(12, 9);
			this.lb_title.Name = "lb_title";
			this.lb_title.Size = new System.Drawing.Size(299, 41);
			this.lb_title.TabIndex = 4;
			this.lb_title.Text = " AUTOMATONAPP";
			// 
			// home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 157);
			this.Controls.Add(this.lb_title);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AUTOMATONAPP";
			this.Load += new System.EventHandler(this.home_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lb_title;
	}
}

