namespace automatonApp
{
    partial class ndfa
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
			this.tb_results = new System.Windows.Forms.TextBox();
			this.bt_sent_string = new System.Windows.Forms.Button();
			this.lb_string = new System.Windows.Forms.Label();
			this.lb_status_automaton = new System.Windows.Forms.Label();
			this.tb_string = new System.Windows.Forms.TextBox();
			this.lb_select_file = new System.Windows.Forms.Label();
			this.bt_open_file = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(141, 405);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 28);
			this.button1.TabIndex = 16;
			this.button1.Text = "Exit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tb_results
			// 
			this.tb_results.Location = new System.Drawing.Point(19, 185);
			this.tb_results.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_results.Multiline = true;
			this.tb_results.Name = "tb_results";
			this.tb_results.ReadOnly = true;
			this.tb_results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_results.Size = new System.Drawing.Size(345, 208);
			this.tb_results.TabIndex = 15;
			// 
			// bt_sent_string
			// 
			this.bt_sent_string.Enabled = false;
			this.bt_sent_string.Location = new System.Drawing.Point(271, 113);
			this.bt_sent_string.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.bt_sent_string.Name = "bt_sent_string";
			this.bt_sent_string.Size = new System.Drawing.Size(93, 36);
			this.bt_sent_string.TabIndex = 14;
			this.bt_sent_string.Text = "Check";
			this.bt_sent_string.UseVisualStyleBackColor = true;
			this.bt_sent_string.Click += new System.EventHandler(this.bt_sent_string_Click);
			// 
			// lb_string
			// 
			this.lb_string.AutoSize = true;
			this.lb_string.Location = new System.Drawing.Point(85, 148);
			this.lb_string.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lb_string.Name = "lb_string";
			this.lb_string.Size = new System.Drawing.Size(103, 16);
			this.lb_string.TabIndex = 13;
			this.lb_string.Text = "Insert your string";
			// 
			// lb_status_automaton
			// 
			this.lb_status_automaton.AutoSize = true;
			this.lb_status_automaton.Location = new System.Drawing.Point(99, 80);
			this.lb_status_automaton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lb_status_automaton.Name = "lb_status_automaton";
			this.lb_status_automaton.Size = new System.Drawing.Size(166, 16);
			this.lb_status_automaton.TabIndex = 12;
			this.lb_status_automaton.Text = "Waiting for the automaton...";
			// 
			// tb_string
			// 
			this.tb_string.Location = new System.Drawing.Point(19, 119);
			this.tb_string.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tb_string.Name = "tb_string";
			this.tb_string.ReadOnly = true;
			this.tb_string.Size = new System.Drawing.Size(243, 22);
			this.tb_string.TabIndex = 11;
			// 
			// lb_select_file
			// 
			this.lb_select_file.AutoSize = true;
			this.lb_select_file.Location = new System.Drawing.Point(15, 11);
			this.lb_select_file.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lb_select_file.Name = "lb_select_file";
			this.lb_select_file.Size = new System.Drawing.Size(144, 16);
			this.lb_select_file.TabIndex = 10;
			this.lb_select_file.Text = "Upload Automaton File";
			// 
			// bt_open_file
			// 
			this.bt_open_file.Location = new System.Drawing.Point(17, 39);
			this.bt_open_file.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.bt_open_file.Name = "bt_open_file";
			this.bt_open_file.Size = new System.Drawing.Size(347, 37);
			this.bt_open_file.TabIndex = 9;
			this.bt_open_file.Text = "Select file";
			this.bt_open_file.UseVisualStyleBackColor = true;
			this.bt_open_file.Click += new System.EventHandler(this.bt_open_file_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// ndfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 444);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tb_results);
			this.Controls.Add(this.bt_sent_string);
			this.Controls.Add(this.lb_string);
			this.Controls.Add(this.lb_status_automaton);
			this.Controls.Add(this.tb_string);
			this.Controls.Add(this.lb_select_file);
			this.Controls.Add(this.bt_open_file);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "ndfa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ndfa";
			this.Load += new System.EventHandler(this.ndfa_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_results;
        private System.Windows.Forms.Button bt_sent_string;
        private System.Windows.Forms.Label lb_string;
        private System.Windows.Forms.Label lb_status_automaton;
        private System.Windows.Forms.TextBox tb_string;
        private System.Windows.Forms.Label lb_select_file;
        private System.Windows.Forms.Button bt_open_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}