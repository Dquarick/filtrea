namespace Filtrea
{
    partial class inputPreferenceForm
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
            this.btnCustomerFile = new System.Windows.Forms.Button();
            this.btnCostFile = new System.Windows.Forms.Button();
            this.inputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblCustPath = new System.Windows.Forms.Label();
            this.lblCostPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomerFile
            // 
            this.btnCustomerFile.Location = new System.Drawing.Point(12, 26);
            this.btnCustomerFile.Name = "btnCustomerFile";
            this.btnCustomerFile.Size = new System.Drawing.Size(144, 23);
            this.btnCustomerFile.TabIndex = 0;
            this.btnCustomerFile.Text = "Select Customer Input File";
            this.btnCustomerFile.UseVisualStyleBackColor = true;
            this.btnCustomerFile.Click += new System.EventHandler(this.btnCustomerFile_Click);
            // 
            // btnCostFile
            // 
            this.btnCostFile.Location = new System.Drawing.Point(12, 55);
            this.btnCostFile.Name = "btnCostFile";
            this.btnCostFile.Size = new System.Drawing.Size(144, 23);
            this.btnCostFile.TabIndex = 1;
            this.btnCostFile.Text = "Select Cost Input File";
            this.btnCostFile.UseVisualStyleBackColor = true;
            this.btnCostFile.Click += new System.EventHandler(this.btnCostFile_Click);
            // 
            // inputFileDialog
            // 
            this.inputFileDialog.FileName = "openFileDialog1";
            // 
            // lblCustPath
            // 
            this.lblCustPath.AutoSize = true;
            this.lblCustPath.Location = new System.Drawing.Point(162, 31);
            this.lblCustPath.Name = "lblCustPath";
            this.lblCustPath.Size = new System.Drawing.Size(59, 13);
            this.lblCustPath.TabIndex = 2;
            this.lblCustPath.Text = "File in Use:";
            // 
            // lblCostPath
            // 
            this.lblCostPath.AutoSize = true;
            this.lblCostPath.Location = new System.Drawing.Point(162, 60);
            this.lblCostPath.Name = "lblCostPath";
            this.lblCostPath.Size = new System.Drawing.Size(59, 13);
            this.lblCostPath.TabIndex = 3;
            this.lblCostPath.Text = "File in Use:";
            // 
            // inputPreferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 101);
            this.Controls.Add(this.lblCostPath);
            this.Controls.Add(this.lblCustPath);
            this.Controls.Add(this.btnCostFile);
            this.Controls.Add(this.btnCustomerFile);
            this.Name = "inputPreferenceForm";
            this.Text = "Filtrea Input Preferences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerFile;
        private System.Windows.Forms.Button btnCostFile;
        private System.Windows.Forms.OpenFileDialog inputFileDialog;
        private System.Windows.Forms.Label lblCustPath;
        private System.Windows.Forms.Label lblCostPath;
    }
}