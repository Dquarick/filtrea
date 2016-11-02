namespace Filtrea
{
    partial class outputPreferenceForm
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
            this.btnLedgerFile = new System.Windows.Forms.Button();
            this.lblInUse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLedgerFile
            // 
            this.btnLedgerFile.Location = new System.Drawing.Point(12, 40);
            this.btnLedgerFile.Name = "btnLedgerFile";
            this.btnLedgerFile.Size = new System.Drawing.Size(144, 23);
            this.btnLedgerFile.TabIndex = 1;
            this.btnLedgerFile.Text = "Select Ledger Output File";
            this.btnLedgerFile.UseVisualStyleBackColor = true;
            // 
            // lblInUse
            // 
            this.lblInUse.AutoSize = true;
            this.lblInUse.Location = new System.Drawing.Point(162, 45);
            this.lblInUse.Name = "lblInUse";
            this.lblInUse.Size = new System.Drawing.Size(63, 13);
            this.lblInUse.TabIndex = 2;
            this.lblInUse.Text = "File In Use: ";
            // 
            // outputPreferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 101);
            this.Controls.Add(this.lblInUse);
            this.Controls.Add(this.btnLedgerFile);
            this.Name = "outputPreferenceForm";
            this.Text = "Filtrea Output Preferences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLedgerFile;
        private System.Windows.Forms.Label lblInUse;
    }
}