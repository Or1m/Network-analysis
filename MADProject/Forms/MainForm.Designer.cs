
namespace MADProject
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConsoleRadioButt = new System.Windows.Forms.RadioButton();
            this.FileRadioButt = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StatsPathButt = new System.Windows.Forms.Button();
            this.NetPathButt = new System.Windows.Forms.Button();
            this.SampleButt = new System.Windows.Forms.Button();
            this.StatsPathTextBox = new System.Windows.Forms.TextBox();
            this.NetPathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PrintStatsButt = new System.Windows.Forms.Button();
            this.PrintSampleButt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MethodComboBox = new System.Windows.Forms.ComboBox();
            this.SizeBox = new System.Windows.Forms.TextBox();
            this.MaxIterBox = new System.Windows.Forms.TextBox();
            this.StartBox = new System.Windows.Forms.TextBox();
            this.RNDBox = new System.Windows.Forms.CheckBox();
            this.SamplePathButt = new System.Windows.Forms.Button();
            this.SamplePathTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DelimTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConsoleRadioButt);
            this.groupBox1.Controls.Add(this.FileRadioButt);
            this.groupBox1.Location = new System.Drawing.Point(428, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 68);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // ConsoleRadioButt
            // 
            this.ConsoleRadioButt.AutoSize = true;
            this.ConsoleRadioButt.Checked = true;
            this.ConsoleRadioButt.Location = new System.Drawing.Point(6, 11);
            this.ConsoleRadioButt.Name = "ConsoleRadioButt";
            this.ConsoleRadioButt.Size = new System.Drawing.Size(63, 17);
            this.ConsoleRadioButt.TabIndex = 13;
            this.ConsoleRadioButt.TabStop = true;
            this.ConsoleRadioButt.Text = "Console";
            this.ConsoleRadioButt.UseVisualStyleBackColor = true;
            // 
            // FileRadioButt
            // 
            this.FileRadioButt.AutoSize = true;
            this.FileRadioButt.Location = new System.Drawing.Point(6, 34);
            this.FileRadioButt.Name = "FileRadioButt";
            this.FileRadioButt.Size = new System.Drawing.Size(41, 17);
            this.FileRadioButt.TabIndex = 14;
            this.FileRadioButt.Text = "File";
            this.FileRadioButt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Output type";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(-2, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(620, 3);
            this.label4.TabIndex = 27;
            // 
            // StatsPathButt
            // 
            this.StatsPathButt.Location = new System.Drawing.Point(522, 38);
            this.StatsPathButt.Name = "StatsPathButt";
            this.StatsPathButt.Size = new System.Drawing.Size(78, 26);
            this.StatsPathButt.TabIndex = 25;
            this.StatsPathButt.Text = "Change path";
            this.StatsPathButt.UseVisualStyleBackColor = true;
            this.StatsPathButt.Click += new System.EventHandler(this.StatsPathButt_Click);
            // 
            // NetPathButt
            // 
            this.NetPathButt.Location = new System.Drawing.Point(203, 38);
            this.NetPathButt.Name = "NetPathButt";
            this.NetPathButt.Size = new System.Drawing.Size(78, 26);
            this.NetPathButt.TabIndex = 24;
            this.NetPathButt.Text = "Change path";
            this.NetPathButt.UseVisualStyleBackColor = true;
            this.NetPathButt.Click += new System.EventHandler(this.NetPathButt_Click);
            // 
            // SampleButt
            // 
            this.SampleButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SampleButt.ForeColor = System.Drawing.Color.Red;
            this.SampleButt.Location = new System.Drawing.Point(14, 272);
            this.SampleButt.Name = "SampleButt";
            this.SampleButt.Size = new System.Drawing.Size(172, 27);
            this.SampleButt.TabIndex = 23;
            this.SampleButt.Text = "Create sample";
            this.SampleButt.UseVisualStyleBackColor = true;
            this.SampleButt.Click += new System.EventHandler(this.SampleButt_Click);
            // 
            // StatsPathTextBox
            // 
            this.StatsPathTextBox.Location = new System.Drawing.Point(428, 12);
            this.StatsPathTextBox.Name = "StatsPathTextBox";
            this.StatsPathTextBox.ReadOnly = true;
            this.StatsPathTextBox.Size = new System.Drawing.Size(172, 20);
            this.StatsPathTextBox.TabIndex = 22;
            this.StatsPathTextBox.Text = "stats.txt";
            // 
            // NetPathTextBox
            // 
            this.NetPathTextBox.Location = new System.Drawing.Point(109, 12);
            this.NetPathTextBox.Name = "NetPathTextBox";
            this.NetPathTextBox.ReadOnly = true;
            this.NetPathTextBox.Size = new System.Drawing.Size(172, 20);
            this.NetPathTextBox.TabIndex = 21;
            this.NetPathTextBox.Text = "network.csv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Stats output path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Path to network";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sampling method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sample size";
            // 
            // PrintStatsButt
            // 
            this.PrintStatsButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrintStatsButt.ForeColor = System.Drawing.Color.Black;
            this.PrintStatsButt.Location = new System.Drawing.Point(428, 239);
            this.PrintStatsButt.Name = "PrintStatsButt";
            this.PrintStatsButt.Size = new System.Drawing.Size(172, 27);
            this.PrintStatsButt.TabIndex = 32;
            this.PrintStatsButt.Text = "Print statistics";
            this.PrintStatsButt.UseVisualStyleBackColor = true;
            this.PrintStatsButt.Click += new System.EventHandler(this.PrintStatsButt_Click);
            // 
            // PrintSampleButt
            // 
            this.PrintSampleButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrintSampleButt.ForeColor = System.Drawing.Color.Black;
            this.PrintSampleButt.Location = new System.Drawing.Point(428, 272);
            this.PrintSampleButt.Name = "PrintSampleButt";
            this.PrintSampleButt.Size = new System.Drawing.Size(172, 27);
            this.PrintSampleButt.TabIndex = 33;
            this.PrintSampleButt.Text = "Print sample";
            this.PrintSampleButt.UseVisualStyleBackColor = true;
            this.PrintSampleButt.Click += new System.EventHandler(this.PrintSampleButt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Max iterations";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Start node";
            // 
            // MethodComboBox
            // 
            this.MethodComboBox.FormattingEnabled = true;
            this.MethodComboBox.Items.AddRange(new object[] {
            "asd",
            "asdasd"});
            this.MethodComboBox.Location = new System.Drawing.Point(107, 152);
            this.MethodComboBox.Name = "MethodComboBox";
            this.MethodComboBox.Size = new System.Drawing.Size(172, 21);
            this.MethodComboBox.TabIndex = 36;
            // 
            // SizeBox
            // 
            this.SizeBox.Location = new System.Drawing.Point(107, 175);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(172, 20);
            this.SizeBox.TabIndex = 37;
            this.SizeBox.Text = "1000";
            // 
            // MaxIterBox
            // 
            this.MaxIterBox.Location = new System.Drawing.Point(107, 196);
            this.MaxIterBox.Name = "MaxIterBox";
            this.MaxIterBox.Size = new System.Drawing.Size(172, 20);
            this.MaxIterBox.TabIndex = 38;
            this.MaxIterBox.Text = "1000";
            // 
            // StartBox
            // 
            this.StartBox.Location = new System.Drawing.Point(107, 223);
            this.StartBox.Name = "StartBox";
            this.StartBox.Size = new System.Drawing.Size(172, 20);
            this.StartBox.TabIndex = 39;
            this.StartBox.Text = "0";
            // 
            // RNDBox
            // 
            this.RNDBox.AutoSize = true;
            this.RNDBox.Location = new System.Drawing.Point(178, 249);
            this.RNDBox.Name = "RNDBox";
            this.RNDBox.Size = new System.Drawing.Size(101, 17);
            this.RNDBox.TabIndex = 40;
            this.RNDBox.Text = "Random choice";
            this.RNDBox.UseVisualStyleBackColor = true;
            this.RNDBox.CheckedChanged += new System.EventHandler(this.RNDBox_CheckedChanged);
            // 
            // SamplePathButt
            // 
            this.SamplePathButt.Location = new System.Drawing.Point(522, 96);
            this.SamplePathButt.Name = "SamplePathButt";
            this.SamplePathButt.Size = new System.Drawing.Size(78, 26);
            this.SamplePathButt.TabIndex = 43;
            this.SamplePathButt.Text = "Change path";
            this.SamplePathButt.UseVisualStyleBackColor = true;
            this.SamplePathButt.Click += new System.EventHandler(this.SamplePathButt_Click);
            // 
            // SamplePathTextBox
            // 
            this.SamplePathTextBox.Location = new System.Drawing.Point(428, 70);
            this.SamplePathTextBox.Name = "SamplePathTextBox";
            this.SamplePathTextBox.ReadOnly = true;
            this.SamplePathTextBox.Size = new System.Drawing.Size(172, 20);
            this.SamplePathTextBox.TabIndex = 42;
            this.SamplePathTextBox.Text = "sample.csv";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Sample output path";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Delimiter";
            // 
            // DelimTextBox
            // 
            this.DelimTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DelimTextBox.Location = new System.Drawing.Point(109, 70);
            this.DelimTextBox.Name = "DelimTextBox";
            this.DelimTextBox.Size = new System.Drawing.Size(172, 29);
            this.DelimTextBox.TabIndex = 45;
            this.DelimTextBox.Text = ";";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(612, 310);
            this.Controls.Add(this.DelimTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SamplePathButt);
            this.Controls.Add(this.SamplePathTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RNDBox);
            this.Controls.Add(this.StartBox);
            this.Controls.Add(this.MaxIterBox);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.MethodComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PrintSampleButt);
            this.Controls.Add(this.PrintStatsButt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StatsPathButt);
            this.Controls.Add(this.NetPathButt);
            this.Controls.Add(this.SampleButt);
            this.Controls.Add(this.StatsPathTextBox);
            this.Controls.Add(this.NetPathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAD2 Project";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ConsoleRadioButt;
        private System.Windows.Forms.RadioButton FileRadioButt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StatsPathButt;
        private System.Windows.Forms.Button NetPathButt;
        private System.Windows.Forms.Button SampleButt;
        private System.Windows.Forms.TextBox StatsPathTextBox;
        private System.Windows.Forms.TextBox NetPathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PrintStatsButt;
        private System.Windows.Forms.Button PrintSampleButt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox MethodComboBox;
        private System.Windows.Forms.TextBox SizeBox;
        private System.Windows.Forms.TextBox MaxIterBox;
        private System.Windows.Forms.TextBox StartBox;
        private System.Windows.Forms.CheckBox RNDBox;
        private System.Windows.Forms.Button SamplePathButt;
        private System.Windows.Forms.TextBox SamplePathTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DelimTextBox;
    }
}

