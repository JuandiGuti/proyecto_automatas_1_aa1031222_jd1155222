namespace automatonApp
{
	partial class dfa
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
			this.bt_open_file = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.lb_select_file = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bt_open_file
			// 
			this.bt_open_file.Location = new System.Drawing.Point(15, 25);
			this.bt_open_file.Name = "bt_open_file";
			this.bt_open_file.Size = new System.Drawing.Size(75, 23);
			this.bt_open_file.TabIndex = 1;
			this.bt_open_file.Text = "select file";
			this.bt_open_file.UseVisualStyleBackColor = true;
			this.bt_open_file.Click += new System.EventHandler(this.bt_open_file_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "get your file...";
			this.openFileDialog1.Filter = "Text files (*.txt)|*.txt";
			this.openFileDialog1.InitialDirectory = "Home";
			// 
			// lb_select_file
			// 
			this.lb_select_file.AutoSize = true;
			this.lb_select_file.Location = new System.Drawing.Point(12, 9);
			this.lb_select_file.Name = "lb_select_file";
			this.lb_select_file.Size = new System.Drawing.Size(114, 13);
			this.lb_select_file.TabIndex = 2;
			this.lb_select_file.Text = "Upload Automaton File";
			// 
			// dfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 339);
			this.Controls.Add(this.lb_select_file);
			this.Controls.Add(this.bt_open_file);
			this.Name = "dfa";
			this.Text = "dfa";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button bt_open_file;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label lb_select_file;
	}
}