
namespace MADProject
{
    partial class GenerateForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.NumOfNodesTextBox = new System.Windows.Forms.TextBox();
            this.MTextBox = new System.Windows.Forms.TextBox();
            this.ChangePathButt = new System.Windows.Forms.Button();
            this.RunButt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FileRadioButt = new System.Windows.Forms.RadioButton();
            this.ConsoleRadioButt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num of Nodes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num of edges for new node";
            // 
            // NumOfNodesTextBox
            // 
            this.NumOfNodesTextBox.Location = new System.Drawing.Point(156, 9);
            this.NumOfNodesTextBox.Name = "NumOfNodesTextBox";
            this.NumOfNodesTextBox.Size = new System.Drawing.Size(116, 20);
            this.NumOfNodesTextBox.TabIndex = 2;
            this.NumOfNodesTextBox.Text = "1000";
            // 
            // MTextBox
            // 
            this.MTextBox.Location = new System.Drawing.Point(156, 35);
            this.MTextBox.Name = "MTextBox";
            this.MTextBox.Size = new System.Drawing.Size(116, 20);
            this.MTextBox.TabIndex = 3;
            this.MTextBox.Text = "4";
            // 
            // ChangePathButt
            // 
            this.ChangePathButt.Location = new System.Drawing.Point(177, 115);
            this.ChangePathButt.Name = "ChangePathButt";
            this.ChangePathButt.Size = new System.Drawing.Size(95, 23);
            this.ChangePathButt.TabIndex = 4;
            this.ChangePathButt.Text = "Change Path";
            this.ChangePathButt.UseVisualStyleBackColor = true;
            this.ChangePathButt.Click += new System.EventHandler(this.ChangePathButt_Click);
            // 
            // RunButt
            // 
            this.RunButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RunButt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RunButt.Location = new System.Drawing.Point(197, 144);
            this.RunButt.Name = "RunButt";
            this.RunButt.Size = new System.Drawing.Size(75, 39);
            this.RunButt.TabIndex = 5;
            this.RunButt.Text = "Run";
            this.RunButt.UseVisualStyleBackColor = true;
            this.RunButt.Click += new System.EventHandler(this.RunButt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Network type";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Random graph",
            "Small-world graph",
            "Scale-free graph (Barabasi-Albert)"});
            this.TypeComboBox.Location = new System.Drawing.Point(88, 61);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(184, 21);
            this.TypeComboBox.TabIndex = 7;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(88, 89);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(184, 20);
            this.PathTextBox.TabIndex = 8;
            this.PathTextBox.Text = "network.csv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Path";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 170);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(171, 13);
            this.ErrorLabel.TabIndex = 10;
            this.ErrorLabel.Text = "This type is currently not supported";
            this.ErrorLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Output type";
            // 
            // FileRadioButt
            // 
            this.FileRadioButt.AutoSize = true;
            this.FileRadioButt.Checked = true;
            this.FileRadioButt.Location = new System.Drawing.Point(88, 120);
            this.FileRadioButt.Name = "FileRadioButt";
            this.FileRadioButt.Size = new System.Drawing.Size(41, 17);
            this.FileRadioButt.TabIndex = 12;
            this.FileRadioButt.TabStop = true;
            this.FileRadioButt.Text = "File";
            this.FileRadioButt.UseVisualStyleBackColor = true;
            this.FileRadioButt.CheckedChanged += new System.EventHandler(this.FileRadioButt_CheckedChanged);
            // 
            // ConsoleRadioButt
            // 
            this.ConsoleRadioButt.AutoSize = true;
            this.ConsoleRadioButt.Location = new System.Drawing.Point(88, 143);
            this.ConsoleRadioButt.Name = "ConsoleRadioButt";
            this.ConsoleRadioButt.Size = new System.Drawing.Size(63, 17);
            this.ConsoleRadioButt.TabIndex = 13;
            this.ConsoleRadioButt.Text = "Console";
            this.ConsoleRadioButt.UseVisualStyleBackColor = true;
            this.ConsoleRadioButt.CheckedChanged += new System.EventHandler(this.ConsoleRadioButt_CheckedChanged);
            // 
            // GenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.ConsoleRadioButt);
            this.Controls.Add(this.FileRadioButt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RunButt);
            this.Controls.Add(this.ChangePathButt);
            this.Controls.Add(this.MTextBox);
            this.Controls.Add(this.NumOfNodesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GenerateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GenerateForm_FormClosed);
            this.Load += new System.EventHandler(this.GenerateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumOfNodesTextBox;
        private System.Windows.Forms.TextBox MTextBox;
        private System.Windows.Forms.Button ChangePathButt;
        private System.Windows.Forms.Button RunButt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton FileRadioButt;
        private System.Windows.Forms.RadioButton ConsoleRadioButt;
    }
}