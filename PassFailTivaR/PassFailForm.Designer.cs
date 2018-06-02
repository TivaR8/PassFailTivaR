namespace PassFailTivaR
{
    partial class frmPassFail
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblComplete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(46, 20);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(274, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Press Start to see how many students passed each year.";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(147, 55);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Location = new System.Drawing.Point(92, 90);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(185, 13);
            this.lblComplete.TabIndex = 2;
            this.lblComplete.Text = "Output has been generated to text file";
            // 
            // frmPassFail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 112);
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmPassFail";
            this.Text = "Pass Fail By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblComplete;
    }
}

