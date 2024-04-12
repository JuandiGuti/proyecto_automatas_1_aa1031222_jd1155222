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
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bt_open_file
			// 
			this.bt_open_file.Location = new System.Drawing.Point(12, 33);
			this.bt_open_file.Name = "bt_open_file";
			this.bt_open_file.Size = new System.Drawing.Size(260, 30);
			this.bt_open_file.TabIndex = 1;
			this.bt_open_file.Text = "Select file";
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
			this.lb_select_file.Location = new System.Drawing.Point(10, 10);
			this.lb_select_file.Name = "lb_select_file";
			this.lb_select_file.Size = new System.Drawing.Size(114, 13);
			this.lb_select_file.TabIndex = 2;
			this.lb_select_file.Text = "Upload Automaton File";
			// 
			// tb_string
			// 
			this.tb_string.Location = new System.Drawing.Point(13, 98);
			this.tb_string.Name = "tb_string";
			this.tb_string.ReadOnly = true;
			this.tb_string.Size = new System.Drawing.Size(183, 20);
			this.tb_string.TabIndex = 3;
			this.tb_string.TextChanged += new System.EventHandler(this.tb_string_TextChanged);
			// 
			// lb_status_automaton
			// 
			this.lb_status_automaton.AutoSize = true;
			this.lb_status_automaton.Location = new System.Drawing.Point(73, 66);
			this.lb_status_automaton.Name = "lb_status_automaton";
			this.lb_status_automaton.Size = new System.Drawing.Size(138, 13);
			this.lb_status_automaton.TabIndex = 4;
			this.lb_status_automaton.Text = "Waiting for the automaton...";
			// 
			// lb_string
			// 
			this.lb_string.AutoSize = true;
			this.lb_string.Location = new System.Drawing.Point(63, 121);
			this.lb_string.Name = "lb_string";
			this.lb_string.Size = new System.Drawing.Size(84, 13);
			this.lb_string.TabIndex = 5;
			this.lb_string.Text = "Insert your string";
			// 
			// bt_sent_string
			// 
			this.bt_sent_string.Enabled = false;
			this.bt_sent_string.Location = new System.Drawing.Point(202, 93);
			this.bt_sent_string.Name = "bt_sent_string";
			this.bt_sent_string.Size = new System.Drawing.Size(70, 29);
			this.bt_sent_string.TabIndex = 6;
			this.bt_sent_string.Text = "Check";
			this.bt_sent_string.UseVisualStyleBackColor = true;
			this.bt_sent_string.Click += new System.EventHandler(this.bt_sent_string_Click);
			// 
			// tb_results
			// 
			this.tb_results.Location = new System.Drawing.Point(13, 151);
			this.tb_results.Margin = new System.Windows.Forms.Padding(2);
			this.tb_results.Multiline = true;
			this.tb_results.Name = "tb_results";
			this.tb_results.ReadOnly = true;
			this.tb_results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_results.Size = new System.Drawing.Size(260, 170);
			this.tb_results.TabIndex = 7;
			this.tb_results.TextChanged += new System.EventHandler(this.tb_results_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(105, 330);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Exit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 361);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tb_results);
			this.Controls.Add(this.bt_sent_string);
			this.Controls.Add(this.lb_string);
			this.Controls.Add(this.lb_status_automaton);
			this.Controls.Add(this.tb_string);
			this.Controls.Add(this.lb_select_file);
			this.Controls.Add(this.bt_open_file);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "dfa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
		private System.Windows.Forms.Button button1;
	}
}