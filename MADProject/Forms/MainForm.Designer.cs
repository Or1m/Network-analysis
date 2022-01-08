
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
            this.GenerateButt = new System.Windows.Forms.Button();
            this.AnalyzeButt = new System.Windows.Forms.Button();
            this.ClearButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateButt
            // 
            this.GenerateButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GenerateButt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GenerateButt.Location = new System.Drawing.Point(12, 12);
            this.GenerateButt.Name = "GenerateButt";
            this.GenerateButt.Size = new System.Drawing.Size(193, 176);
            this.GenerateButt.TabIndex = 0;
            this.GenerateButt.Text = "Generate";
            this.GenerateButt.UseVisualStyleBackColor = true;
            this.GenerateButt.Click += new System.EventHandler(this.GenerateButt_Click);
            // 
            // AnalyzeButt
            // 
            this.AnalyzeButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnalyzeButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AnalyzeButt.ForeColor = System.Drawing.Color.Red;
            this.AnalyzeButt.Location = new System.Drawing.Point(229, 12);
            this.AnalyzeButt.Name = "AnalyzeButt";
            this.AnalyzeButt.Size = new System.Drawing.Size(193, 176);
            this.AnalyzeButt.TabIndex = 1;
            this.AnalyzeButt.Text = "Analyze";
            this.AnalyzeButt.UseVisualStyleBackColor = true;
            this.AnalyzeButt.Click += new System.EventHandler(this.AnalyzeButt_Click);
            // 
            // ClearButt
            // 
            this.ClearButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearButt.ForeColor = System.Drawing.Color.Black;
            this.ClearButt.Location = new System.Drawing.Point(12, 200);
            this.ClearButt.Name = "ClearButt";
            this.ClearButt.Size = new System.Drawing.Size(410, 41);
            this.ClearButt.TabIndex = 2;
            this.ClearButt.Text = "Clear console";
            this.ClearButt.UseVisualStyleBackColor = true;
            this.ClearButt.Click += new System.EventHandler(this.ClearButt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(434, 253);
            this.Controls.Add(this.ClearButt);
            this.Controls.Add(this.AnalyzeButt);
            this.Controls.Add(this.GenerateButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAD Project Entry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateButt;
        private System.Windows.Forms.Button AnalyzeButt;
        private System.Windows.Forms.Button ClearButt;
    }
}

