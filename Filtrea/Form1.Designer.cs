namespace Filtrea
{
    partial class formMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblChannel = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.cbAlum = new System.Windows.Forms.CheckBox();
            this.cbCarb = new System.Windows.Forms.CheckBox();
            this.cbLens = new System.Windows.Forms.CheckBox();
            this.lblHardware = new System.Windows.Forms.Label();
            this.cboxChannel = new System.Windows.Forms.ComboBox();
            this.cbPT = new System.Windows.Forms.CheckBox();
            this.cbTS = new System.Windows.Forms.CheckBox();
            this.cbMB = new System.Windows.Forms.CheckBox();
            this.cbGrom = new System.Windows.Forms.CheckBox();
            this.lblFrame = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cboxCustomer = new System.Windows.Forms.ComboBox();
            this.lvCurOrder = new System.Windows.Forms.ListView();
            this.colSpecifications = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnAdd2Order = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtPtQty = new System.Windows.Forms.TextBox();
            this.txtTsQty = new System.Windows.Forms.TextBox();
            this.txtMbQty = new System.Windows.Forms.TextBox();
            this.txtGromQty = new System.Windows.Forms.TextBox();
            this.lblHwQty = new System.Windows.Forms.Label();
            this.inputFilePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputFilePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputFilePathsToolStripMenuItem,
            this.outputFilePathsToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(177, 91);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(77, 13);
            this.lblChannel.TabIndex = 7;
            this.lblChannel.Text = "Channel Width";
            this.lblChannel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(9, 91);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(36, 13);
            this.lblMedia.TabIndex = 8;
            this.lblMedia.Text = "Media";
            // 
            // cbAlum
            // 
            this.cbAlum.AutoSize = true;
            this.cbAlum.Location = new System.Drawing.Point(12, 118);
            this.cbAlum.Name = "cbAlum";
            this.cbAlum.Size = new System.Drawing.Size(73, 17);
            this.cbAlum.TabIndex = 9;
            this.cbAlum.Text = "Aluminium";
            this.cbAlum.UseVisualStyleBackColor = true;
            this.cbAlum.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbCarb
            // 
            this.cbCarb.AutoSize = true;
            this.cbCarb.Location = new System.Drawing.Point(12, 142);
            this.cbCarb.Name = "cbCarb";
            this.cbCarb.Size = new System.Drawing.Size(60, 17);
            this.cbCarb.TabIndex = 10;
            this.cbCarb.Text = "Carbon";
            this.cbCarb.UseVisualStyleBackColor = true;
            // 
            // cbLens
            // 
            this.cbLens.AutoSize = true;
            this.cbLens.Location = new System.Drawing.Point(12, 165);
            this.cbLens.Name = "cbLens";
            this.cbLens.Size = new System.Drawing.Size(49, 17);
            this.cbLens.TabIndex = 11;
            this.cbLens.Text = "Lens";
            this.cbLens.UseVisualStyleBackColor = true;
            // 
            // lblHardware
            // 
            this.lblHardware.AutoSize = true;
            this.lblHardware.Location = new System.Drawing.Point(8, 200);
            this.lblHardware.Name = "lblHardware";
            this.lblHardware.Size = new System.Drawing.Size(53, 13);
            this.lblHardware.TabIndex = 12;
            this.lblHardware.Text = "Hardware";
            // 
            // cboxChannel
            // 
            this.cboxChannel.FormattingEnabled = true;
            this.cboxChannel.Items.AddRange(new object[] {
            "1/32\"",
            "1/4\"",
            "3/8\"",
            "1/2\"",
            "1\"",
            "2\""});
            this.cboxChannel.Location = new System.Drawing.Point(180, 114);
            this.cboxChannel.Name = "cboxChannel";
            this.cboxChannel.Size = new System.Drawing.Size(133, 21);
            this.cboxChannel.TabIndex = 14;
            // 
            // cbPT
            // 
            this.cbPT.AutoSize = true;
            this.cbPT.Location = new System.Drawing.Point(11, 233);
            this.cbPT.Name = "cbPT";
            this.cbPT.Size = new System.Drawing.Size(65, 17);
            this.cbPT.TabIndex = 15;
            this.cbPT.Text = "Pull Tab";
            this.cbPT.UseVisualStyleBackColor = true;
            this.cbPT.CheckedChanged += new System.EventHandler(this.cbPT_CheckedChanged);
            // 
            // cbTS
            // 
            this.cbTS.AutoSize = true;
            this.cbTS.Location = new System.Drawing.Point(11, 256);
            this.cbTS.Name = "cbTS";
            this.cbTS.Size = new System.Drawing.Size(97, 17);
            this.cbTS.TabIndex = 16;
            this.cbTS.Text = "Tension Spring";
            this.cbTS.UseVisualStyleBackColor = true;
            this.cbTS.CheckedChanged += new System.EventHandler(this.cbTS_CheckedChanged);
            // 
            // cbMB
            // 
            this.cbMB.AutoSize = true;
            this.cbMB.Location = new System.Drawing.Point(11, 279);
            this.cbMB.Name = "cbMB";
            this.cbMB.Size = new System.Drawing.Size(110, 17);
            this.cbMB.TabIndex = 17;
            this.cbMB.Text = "Mounting Bracket";
            this.cbMB.UseVisualStyleBackColor = true;
            this.cbMB.CheckedChanged += new System.EventHandler(this.cbMB_CheckedChanged);
            // 
            // cbGrom
            // 
            this.cbGrom.AutoSize = true;
            this.cbGrom.Location = new System.Drawing.Point(11, 302);
            this.cbGrom.Name = "cbGrom";
            this.cbGrom.Size = new System.Drawing.Size(68, 17);
            this.cbGrom.TabIndex = 18;
            this.cbGrom.Text = "Grommet";
            this.cbGrom.UseVisualStyleBackColor = true;
            this.cbGrom.CheckedChanged += new System.EventHandler(this.cbGrom_CheckedChanged);
            // 
            // lblFrame
            // 
            this.lblFrame.AutoSize = true;
            this.lblFrame.Location = new System.Drawing.Point(11, 339);
            this.lblFrame.Name = "lblFrame";
            this.lblFrame.Size = new System.Drawing.Size(96, 13);
            this.lblFrame.TabIndex = 19;
            this.lblFrame.Text = "Frame Dimensions:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(14, 355);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(34, 20);
            this.txtWidth.TabIndex = 20;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(74, 355);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(34, 20);
            this.txtHeight.TabIndex = 21;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(54, 358);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 22;
            this.lblX.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Current Order";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(14, 629);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "Print Order";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(262, 629);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Entry";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(9, 40);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 26;
            this.lblCustomer.Text = "Customer";
            // 
            // cboxCustomer
            // 
            this.cboxCustomer.FormattingEnabled = true;
            this.cboxCustomer.Location = new System.Drawing.Point(11, 56);
            this.cboxCustomer.Name = "cboxCustomer";
            this.cboxCustomer.Size = new System.Drawing.Size(110, 21);
            this.cboxCustomer.TabIndex = 27;
            // 
            // lvCurOrder
            // 
            this.lvCurOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSpecifications,
            this.colQty,
            this.colPrice});
            this.lvCurOrder.GridLines = true;
            this.lvCurOrder.Location = new System.Drawing.Point(12, 439);
            this.lvCurOrder.Name = "lvCurOrder";
            this.lvCurOrder.Size = new System.Drawing.Size(568, 184);
            this.lvCurOrder.TabIndex = 28;
            this.lvCurOrder.UseCompatibleStateImageBehavior = false;
            this.lvCurOrder.View = System.Windows.Forms.View.Details;
            // 
            // colSpecifications
            // 
            this.colSpecifications.Text = "Specifications";
            this.colSpecifications.Width = 446;
            // 
            // colQty
            // 
            this.colQty.Text = "Quantity";
            this.colQty.Width = 55;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.Width = 62;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(505, 629);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrder.TabIndex = 29;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnAdd2Order
            // 
            this.btnAdd2Order.Location = new System.Drawing.Point(12, 410);
            this.btnAdd2Order.Name = "btnAdd2Order";
            this.btnAdd2Order.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2Order.TabIndex = 30;
            this.btnAdd2Order.Text = "Add to Order";
            this.btnAdd2Order.UseVisualStyleBackColor = true;
            this.btnAdd2Order.Click += new System.EventHandler(this.btnAdd2Order_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Filter Quantity:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(180, 358);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(34, 20);
            this.txtQty.TabIndex = 32;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(178, 410);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(75, 23);
            this.btnClearFields.TabIndex = 33;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 410);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "Edit Entry";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtPtQty
            // 
            this.txtPtQty.Location = new System.Drawing.Point(180, 233);
            this.txtPtQty.Name = "txtPtQty";
            this.txtPtQty.Size = new System.Drawing.Size(34, 20);
            this.txtPtQty.TabIndex = 35;
            // 
            // txtTsQty
            // 
            this.txtTsQty.Location = new System.Drawing.Point(180, 253);
            this.txtTsQty.Name = "txtTsQty";
            this.txtTsQty.Size = new System.Drawing.Size(34, 20);
            this.txtTsQty.TabIndex = 36;
            // 
            // txtMbQty
            // 
            this.txtMbQty.Location = new System.Drawing.Point(180, 279);
            this.txtMbQty.Name = "txtMbQty";
            this.txtMbQty.Size = new System.Drawing.Size(34, 20);
            this.txtMbQty.TabIndex = 37;
            // 
            // txtGromQty
            // 
            this.txtGromQty.Location = new System.Drawing.Point(180, 299);
            this.txtGromQty.Name = "txtGromQty";
            this.txtGromQty.Size = new System.Drawing.Size(34, 20);
            this.txtGromQty.TabIndex = 38;
            // 
            // lblHwQty
            // 
            this.lblHwQty.AutoSize = true;
            this.lblHwQty.Location = new System.Drawing.Point(177, 200);
            this.lblHwQty.Name = "lblHwQty";
            this.lblHwQty.Size = new System.Drawing.Size(49, 13);
            this.lblHwQty.TabIndex = 39;
            this.lblHwQty.Text = "Quantity:";
            // 
            // inputFilePathsToolStripMenuItem
            // 
            this.inputFilePathsToolStripMenuItem.Name = "inputFilePathsToolStripMenuItem";
            this.inputFilePathsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.inputFilePathsToolStripMenuItem.Text = "Input File Paths";
            this.inputFilePathsToolStripMenuItem.Click += new System.EventHandler(this.inputFilePathsToolStripMenuItem_Click);
            // 
            // outputFilePathsToolStripMenuItem
            // 
            this.outputFilePathsToolStripMenuItem.Name = "outputFilePathsToolStripMenuItem";
            this.outputFilePathsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.outputFilePathsToolStripMenuItem.Text = "Output File Paths";
            this.outputFilePathsToolStripMenuItem.Click += new System.EventHandler(this.outputFilePathsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // outputFileDialog
            // 
            this.outputFileDialog.FileName = "openFileDialog1";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 664);
            this.Controls.Add(this.lblHwQty);
            this.Controls.Add(this.txtGromQty);
            this.Controls.Add(this.txtMbQty);
            this.Controls.Add(this.txtTsQty);
            this.Controls.Add(this.txtPtQty);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd2Order);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.lvCurOrder);
            this.Controls.Add(this.cboxCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblFrame);
            this.Controls.Add(this.cbGrom);
            this.Controls.Add(this.cbMB);
            this.Controls.Add(this.cbTS);
            this.Controls.Add(this.cbPT);
            this.Controls.Add(this.cboxChannel);
            this.Controls.Add(this.lblHardware);
            this.Controls.Add(this.cbLens);
            this.Controls.Add(this.cbCarb);
            this.Controls.Add(this.cbAlum);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "Filtrea 1.0 Beta";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.CheckBox cbAlum;
        private System.Windows.Forms.CheckBox cbCarb;
        private System.Windows.Forms.CheckBox cbLens;
        private System.Windows.Forms.Label lblHardware;
        private System.Windows.Forms.ComboBox cboxChannel;
        private System.Windows.Forms.CheckBox cbPT;
        private System.Windows.Forms.CheckBox cbTS;
        private System.Windows.Forms.CheckBox cbMB;
        private System.Windows.Forms.CheckBox cbGrom;
        private System.Windows.Forms.Label lblFrame;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cboxCustomer;
        private System.Windows.Forms.ListView lvCurOrder;
        private System.Windows.Forms.ColumnHeader colSpecifications;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnAdd2Order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtPtQty;
        private System.Windows.Forms.TextBox txtTsQty;
        private System.Windows.Forms.TextBox txtMbQty;
        private System.Windows.Forms.TextBox txtGromQty;
        private System.Windows.Forms.Label lblHwQty;
        private System.Windows.Forms.ToolStripMenuItem inputFilePathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputFilePathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog inputFileDialog;
        private System.Windows.Forms.OpenFileDialog outputFileDialog;
    }
}

