
namespace MADProject
{
    partial class AnalyzeForm
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
            this.NetPathTextBox = new System.Windows.Forms.TextBox();
            this.AnalysisPathTextBox = new System.Windows.Forms.TextBox();
            this.AnalyzeButt = new System.Windows.Forms.Button();
            this.NetPathButt = new System.Windows.Forms.Button();
            this.AnalysisPathButt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PercentageRadioButt = new System.Windows.Forms.RadioButton();
            this.NodesRadioButt = new System.Windows.Forms.RadioButton();
            this.BothRadioButt = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to network";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Analysis output";
            // 
            // NetPathTextBox
            // 
            this.NetPathTextBox.Location = new System.Drawing.Point(100, 6);
            this.NetPathTextBox.Name = "NetPathTextBox";
            this.NetPathTextBox.ReadOnly = true;
            this.NetPathTextBox.Size = new System.Drawing.Size(172, 20);
            this.NetPathTextBox.TabIndex = 2;
            this.NetPathTextBox.Text = "network.csv";
            // 
            // AnalysisPathTextBox
            // 
            this.AnalysisPathTextBox.Location = new System.Drawing.Point(100, 71);
            this.AnalysisPathTextBox.Name = "AnalysisPathTextBox";
            this.AnalysisPathTextBox.ReadOnly = true;
            this.AnalysisPathTextBox.Size = new System.Drawing.Size(172, 20);
            this.AnalysisPathTextBox.TabIndex = 3;
            this.AnalysisPathTextBox.Text = "analysis.txt";
            // 
            // AnalyzeButt
            // 
            this.AnalyzeButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AnalyzeButt.ForeColor = System.Drawing.Color.Red;
            this.AnalyzeButt.Location = new System.Drawing.Point(100, 219);
            this.AnalyzeButt.Name = "AnalyzeButt";
            this.AnalyzeButt.Size = new System.Drawing.Size(173, 27);
            this.AnalyzeButt.TabIndex = 4;
            this.AnalyzeButt.Text = "Analyze network";
            this.AnalyzeButt.UseVisualStyleBackColor = true;
            this.AnalyzeButt.Click += new System.EventHandler(this.AnalyzeButt_Click);
            // 
            // NetPathButt
            // 
            this.NetPathButt.Location = new System.Drawing.Point(194, 32);
            this.NetPathButt.Name = "NetPathButt";
            this.NetPathButt.Size = new System.Drawing.Size(78, 26);
            this.NetPathButt.TabIndex = 5;
            this.NetPathButt.Text = "Change path";
            this.NetPathButt.UseVisualStyleBackColor = true;
            this.NetPathButt.Click += new System.EventHandler(this.NetPathButt_Click);
            // 
            // AnalysisPathButt
            // 
            this.AnalysisPathButt.Location = new System.Drawing.Point(194, 97);
            this.AnalysisPathButt.Name = "AnalysisPathButt";
            this.AnalysisPathButt.Size = new System.Drawing.Size(78, 26);
            this.AnalysisPathButt.TabIndex = 6;
            this.AnalysisPathButt.Text = "Change path";
            this.AnalysisPathButt.UseVisualStyleBackColor = true;
            this.AnalysisPathButt.Click += new System.EventHandler(this.AnalysisPathButt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Degree distribution unit";
            // 
            // PercentageRadioButt
            // 
            this.PercentageRadioButt.AutoSize = true;
            this.PercentageRadioButt.Checked = true;
            this.PercentageRadioButt.Location = new System.Drawing.Point(133, 142);
            this.PercentageRadioButt.Name = "PercentageRadioButt";
            this.PercentageRadioButt.Size = new System.Drawing.Size(80, 17);
            this.PercentageRadioButt.TabIndex = 8;
            this.PercentageRadioButt.TabStop = true;
            this.PercentageRadioButt.Text = "Percentage";
            this.PercentageRadioButt.UseVisualStyleBackColor = true;
            // 
            // NodesRadioButt
            // 
            this.NodesRadioButt.AutoSize = true;
            this.NodesRadioButt.Location = new System.Drawing.Point(133, 165);
            this.NodesRadioButt.Name = "NodesRadioButt";
            this.NodesRadioButt.Size = new System.Drawing.Size(108, 17);
            this.NodesRadioButt.TabIndex = 9;
            this.NodesRadioButt.Text = "Number of Nodes";
            this.NodesRadioButt.UseVisualStyleBackColor = true;
            // 
            // BothRadioButt
            // 
            this.BothRadioButt.AutoSize = true;
            this.BothRadioButt.Location = new System.Drawing.Point(133, 188);
            this.BothRadioButt.Name = "BothRadioButt";
            this.BothRadioButt.Size = new System.Drawing.Size(47, 17);
            this.BothRadioButt.TabIndex = 10;
            this.BothRadioButt.Text = "Both";
            this.BothRadioButt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(-13, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 3);
            this.label4.TabIndex = 11;
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 258);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BothRadioButt);
            this.Controls.Add(this.NodesRadioButt);
            this.Controls.Add(this.PercentageRadioButt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnalysisPathButt);
            this.Controls.Add(this.NetPathButt);
            this.Controls.Add(this.AnalyzeButt);
            this.Controls.Add(this.AnalysisPathTextBox);
            this.Controls.Add(this.NetPathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnalyzeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Analyzer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnalyzeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NetPathTextBox;
        private System.Windows.Forms.TextBox AnalysisPathTextBox;
        private System.Windows.Forms.Button AnalyzeButt;
        private System.Windows.Forms.Button NetPathButt;
        private System.Windows.Forms.Button AnalysisPathButt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton PercentageRadioButt;
        private System.Windows.Forms.RadioButton NodesRadioButt;
        private System.Windows.Forms.RadioButton BothRadioButt;
        private System.Windows.Forms.Label label4;
    }
}