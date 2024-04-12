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
			this.tb_string = new System.Windows.Forms.TextBox();
			this.lb_status_automaton = new System.Windows.Forms.Label();
			this.lb_string = new System.Windows.Forms.Label();
			this.bt_sent_string = new System.Windows.Forms.Button();
			this.tb_results = new System.Windows.Forms.TextBox();
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
			// tb_string
			// 
			this.tb_string.Location = new System.Drawing.Point(15, 100);
			this.tb_string.Name = "tb_string";
			this.tb_string.ReadOnly = true;
			this.tb_string.Size = new System.Drawing.Size(192, 20);
			this.tb_string.TabIndex = 3;
			this.tb_string.TextChanged += new System.EventHandler(this.tb_string_TextChanged);
			// 
			// lb_status_automaton
			// 
			this.lb_status_automaton.AutoSize = true;
			this.lb_status_automaton.Location = new System.Drawing.Point(130, 35);
			this.lb_status_automaton.Name = "lb_status_automaton";
			this.lb_status_automaton.Size = new System.Drawing.Size(138, 13);
			this.lb_status_automaton.TabIndex = 4;
			this.lb_status_automaton.Text = "Waiting for the automaton...";
			// 
			// lb_string
			// 
			this.lb_string.AutoSize = true;
			this.lb_string.Location = new System.Drawing.Point(14, 84);
			this.lb_string.Name = "lb_string";
			this.lb_string.Size = new System.Drawing.Size(101, 13);
			this.lb_string.TabIndex = 5;
			this.lb_string.Text = "insert your the string";
			// 
			// bt_sent_string
			// 
			this.bt_sent_string.Enabled = false;
			this.bt_sent_string.Location = new System.Drawing.Point(213, 98);
			this.bt_sent_string.Name = "bt_sent_string";
			this.bt_sent_string.Size = new System.Drawing.Size(75, 23);
			this.bt_sent_string.TabIndex = 6;
			this.bt_sent_string.Text = "Check";
			this.bt_sent_string.UseVisualStyleBackColor = true;
			this.bt_sent_string.Click += new System.EventHandler(this.bt_sent_string_Click);
			// 
			// tb_results
			// 
			this.tb_results.Location = new System.Drawing.Point(15, 127);
			this.tb_results.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tb_results.Multiline = true;
			this.tb_results.Name = "tb_results";
			this.tb_results.ReadOnly = true;
			this.tb_results.Size = new System.Drawing.Size(316, 203);
			this.tb_results.TabIndex = 7;
			this.tb_results.TextChanged += new System.EventHandler(this.tb_results_TextChanged);
			// 
			// dfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 339);
			this.Controls.Add(this.tb_results);
			this.Controls.Add(this.bt_sent_string);
			this.Controls.Add(this.lb_string);
			this.Controls.Add(this.lb_status_automaton);
			this.Controls.Add(this.tb_string);
			this.Controls.Add(this.lb_select_file);
			this.Controls.Add(this.bt_open_file);
			this.Name = "dfa";
			this.Text = "dfa";
			this.Load += new System.EventHandler(this.dfa_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button bt_open_file;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label lb_select_file;
		private System.Windows.Forms.TextBox tb_string;
		private System.Windows.Forms.Label lb_status_automaton;
		private System.Windows.Forms.Label lb_string;
		private System.Windows.Forms.Button bt_sent_string;
		private System.Windows.Forms.TextBox tb_results;
	}
}