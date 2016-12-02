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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFilePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputFilePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblItemDim = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblCurOrder = new System.Windows.Forms.Label();
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
            this.lblItemQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblHwQty = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSideSelection = new System.Windows.Forms.Label();
            this.panTs = new System.Windows.Forms.Panel();
            this.cbTsLs = new System.Windows.Forms.CheckBox();
            this.cbTsSs = new System.Windows.Forms.CheckBox();
            this.rbTsOther = new System.Windows.Forms.RadioButton();
            this.rbTsCen = new System.Windows.Forms.RadioButton();
            this.txtTsQty = new System.Windows.Forms.TextBox();
            this.panHardLbl = new System.Windows.Forms.Panel();
            this.panPt = new System.Windows.Forms.Panel();
            this.cbPtLs = new System.Windows.Forms.CheckBox();
            this.cbPtSs = new System.Windows.Forms.CheckBox();
            this.rbPtOther = new System.Windows.Forms.RadioButton();
            this.rbPtCen = new System.Windows.Forms.RadioButton();
            this.txtPtQty = new System.Windows.Forms.TextBox();
            this.panMb = new System.Windows.Forms.Panel();
            this.cbMbLs = new System.Windows.Forms.CheckBox();
            this.cbMbSs = new System.Windows.Forms.CheckBox();
            this.rbMbOther = new System.Windows.Forms.RadioButton();
            this.rbMbCen = new System.Windows.Forms.RadioButton();
            this.txtMbQty = new System.Windows.Forms.TextBox();
            this.panGrom = new System.Windows.Forms.Panel();
            this.cbGromLs = new System.Windows.Forms.CheckBox();
            this.cbGromSs = new System.Windows.Forms.CheckBox();
            this.rbGromOther = new System.Windows.Forms.RadioButton();
            this.rbGromCen = new System.Windows.Forms.RadioButton();
            this.txtGromQty = new System.Windows.Forms.TextBox();
            this.cboxMargins = new System.Windows.Forms.ComboBox();
            this.lblMargin = new System.Windows.Forms.Label();
            this.formMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.panTs.SuspendLayout();
            this.panHardLbl.SuspendLayout();
            this.panPt.SuspendLayout();
            this.panMb.SuspendLayout();
            this.panGrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(177, 91);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(80, 13);
            this.lblChannel.TabIndex = 7;
            this.lblChannel.Text = "Channel Width:";
            this.lblChannel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(9, 91);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(101, 13);
            this.lblMedia.TabIndex = 8;
            this.lblMedia.Text = "Media / Dimensions";
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
            this.cboxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxChannel.FormattingEnabled = true;
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
            this.cbTS.Location = new System.Drawing.Point(11, 266);
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
            this.cbMB.Location = new System.Drawing.Point(11, 299);
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
            this.cbGrom.Location = new System.Drawing.Point(11, 331);
            this.cbGrom.Name = "cbGrom";
            this.cbGrom.Size = new System.Drawing.Size(68, 17);
            this.cbGrom.TabIndex = 18;
            this.cbGrom.Text = "Grommet";
            this.cbGrom.UseVisualStyleBackColor = true;
            this.cbGrom.CheckedChanged += new System.EventHandler(this.cbGrom_CheckedChanged);
            // 
            // lblItemDim
            // 
            this.lblItemDim.AutoSize = true;
            this.lblItemDim.Location = new System.Drawing.Point(177, 146);
            this.lblItemDim.Name = "lblItemDim";
            this.lblItemDim.Size = new System.Drawing.Size(87, 13);
            this.lblItemDim.TabIndex = 19;
            this.lblItemDim.Text = "Item Dimensions:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(180, 163);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(51, 20);
            this.txtWidth.TabIndex = 20;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(262, 163);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(51, 20);
            this.txtHeight.TabIndex = 21;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(240, 165);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 22;
            this.lblX.Text = "X";
            // 
            // lblCurOrder
            // 
            this.lblCurOrder.AutoSize = true;
            this.lblCurOrder.Location = new System.Drawing.Point(259, 423);
            this.lblCurOrder.Name = "lblCurOrder";
            this.lblCurOrder.Size = new System.Drawing.Size(70, 13);
            this.lblCurOrder.TabIndex = 23;
            this.lblCurOrder.Text = "Current Order";
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
            this.cboxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.btnAdd2Order.Location = new System.Drawing.Point(12, 379);
            this.btnAdd2Order.Name = "btnAdd2Order";
            this.btnAdd2Order.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2Order.TabIndex = 30;
            this.btnAdd2Order.Text = "Add to Order";
            this.btnAdd2Order.UseVisualStyleBackColor = true;
            this.btnAdd2Order.Click += new System.EventHandler(this.btnAdd2Order_Click);
            // 
            // lblItemQty
            // 
            this.lblItemQty.AutoSize = true;
            this.lblItemQty.Location = new System.Drawing.Point(383, 91);
            this.lblItemQty.Name = "lblItemQty";
            this.lblItemQty.Size = new System.Drawing.Size(72, 13);
            this.lblItemQty.TabIndex = 31;
            this.lblItemQty.Text = "Item Quantity:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(386, 116);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(71, 20);
            this.txtQty.TabIndex = 32;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(184, 379);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(75, 23);
            this.btnClearFields.TabIndex = 33;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 379);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 23);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "Edit Entry";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblHwQty
            // 
            this.lblHwQty.AutoSize = true;
            this.lblHwQty.Location = new System.Drawing.Point(-3, 2);
            this.lblHwQty.Name = "lblHwQty";
            this.lblHwQty.Size = new System.Drawing.Size(71, 13);
            this.lblHwQty.TabIndex = 39;
            this.lblHwQty.Text = "Part Quantity:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(136, 2);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(69, 13);
            this.lblPosition.TabIndex = 40;
            this.lblPosition.Text = "Part Position:";
            // 
            // lblSideSelection
            // 
            this.lblSideSelection.AutoSize = true;
            this.lblSideSelection.Location = new System.Drawing.Point(278, 2);
            this.lblSideSelection.Name = "lblSideSelection";
            this.lblSideSelection.Size = new System.Drawing.Size(78, 13);
            this.lblSideSelection.TabIndex = 48;
            this.lblSideSelection.Text = "Side Selection:";
            // 
            // panTs
            // 
            this.panTs.Controls.Add(this.cbTsLs);
            this.panTs.Controls.Add(this.cbTsSs);
            this.panTs.Controls.Add(this.rbTsOther);
            this.panTs.Controls.Add(this.rbTsCen);
            this.panTs.Controls.Add(this.txtTsQty);
            this.panTs.Location = new System.Drawing.Point(180, 258);
            this.panTs.Name = "panTs";
            this.panTs.Size = new System.Drawing.Size(357, 25);
            this.panTs.TabIndex = 51;
            // 
            // cbTsLs
            // 
            this.cbTsLs.AutoSize = true;
            this.cbTsLs.Location = new System.Drawing.Point(318, 6);
            this.cbTsLs.Name = "cbTsLs";
            this.cbTsLs.Size = new System.Drawing.Size(39, 17);
            this.cbTsLs.TabIndex = 50;
            this.cbTsLs.Text = "LS";
            this.cbTsLs.UseVisualStyleBackColor = true;
            // 
            // cbTsSs
            // 
            this.cbTsSs.AutoSize = true;
            this.cbTsSs.Location = new System.Drawing.Point(281, 6);
            this.cbTsSs.Name = "cbTsSs";
            this.cbTsSs.Size = new System.Drawing.Size(40, 17);
            this.cbTsSs.TabIndex = 3;
            this.cbTsSs.Text = "SS";
            this.cbTsSs.UseVisualStyleBackColor = true;
            // 
            // rbTsOther
            // 
            this.rbTsOther.AutoSize = true;
            this.rbTsOther.Location = new System.Drawing.Point(171, 5);
            this.rbTsOther.Name = "rbTsOther";
            this.rbTsOther.Size = new System.Drawing.Size(51, 17);
            this.rbTsOther.TabIndex = 2;
            this.rbTsOther.TabStop = true;
            this.rbTsOther.Text = "Other";
            this.rbTsOther.UseVisualStyleBackColor = true;
            // 
            // rbTsCen
            // 
            this.rbTsCen.AutoSize = true;
            this.rbTsCen.Location = new System.Drawing.Point(118, 5);
            this.rbTsCen.Name = "rbTsCen";
            this.rbTsCen.Size = new System.Drawing.Size(56, 17);
            this.rbTsCen.TabIndex = 1;
            this.rbTsCen.TabStop = true;
            this.rbTsCen.Text = "Center";
            this.rbTsCen.UseVisualStyleBackColor = true;
            // 
            // txtTsQty
            // 
            this.txtTsQty.Location = new System.Drawing.Point(0, 2);
            this.txtTsQty.Name = "txtTsQty";
            this.txtTsQty.Size = new System.Drawing.Size(51, 20);
            this.txtTsQty.TabIndex = 0;
            // 
            // panHardLbl
            // 
            this.panHardLbl.Controls.Add(this.lblHwQty);
            this.panHardLbl.Controls.Add(this.lblPosition);
            this.panHardLbl.Controls.Add(this.lblSideSelection);
            this.panHardLbl.Location = new System.Drawing.Point(180, 198);
            this.panHardLbl.Name = "panHardLbl";
            this.panHardLbl.Size = new System.Drawing.Size(357, 15);
            this.panHardLbl.TabIndex = 53;
            // 
            // panPt
            // 
            this.panPt.Controls.Add(this.cbPtLs);
            this.panPt.Controls.Add(this.cbPtSs);
            this.panPt.Controls.Add(this.rbPtOther);
            this.panPt.Controls.Add(this.rbPtCen);
            this.panPt.Controls.Add(this.txtPtQty);
            this.panPt.Location = new System.Drawing.Point(180, 225);
            this.panPt.Name = "panPt";
            this.panPt.Size = new System.Drawing.Size(357, 25);
            this.panPt.TabIndex = 54;
            // 
            // cbPtLs
            // 
            this.cbPtLs.AutoSize = true;
            this.cbPtLs.Location = new System.Drawing.Point(318, 6);
            this.cbPtLs.Name = "cbPtLs";
            this.cbPtLs.Size = new System.Drawing.Size(39, 17);
            this.cbPtLs.TabIndex = 50;
            this.cbPtLs.Text = "LS";
            this.cbPtLs.UseVisualStyleBackColor = true;
            // 
            // cbPtSs
            // 
            this.cbPtSs.AutoSize = true;
            this.cbPtSs.Location = new System.Drawing.Point(281, 6);
            this.cbPtSs.Name = "cbPtSs";
            this.cbPtSs.Size = new System.Drawing.Size(40, 17);
            this.cbPtSs.TabIndex = 3;
            this.cbPtSs.Text = "SS";
            this.cbPtSs.UseVisualStyleBackColor = true;
            // 
            // rbPtOther
            // 
            this.rbPtOther.AutoSize = true;
            this.rbPtOther.Location = new System.Drawing.Point(171, 5);
            this.rbPtOther.Name = "rbPtOther";
            this.rbPtOther.Size = new System.Drawing.Size(51, 17);
            this.rbPtOther.TabIndex = 2;
            this.rbPtOther.TabStop = true;
            this.rbPtOther.Text = "Other";
            this.rbPtOther.UseVisualStyleBackColor = true;
            // 
            // rbPtCen
            // 
            this.rbPtCen.AutoSize = true;
            this.rbPtCen.Location = new System.Drawing.Point(118, 5);
            this.rbPtCen.Name = "rbPtCen";
            this.rbPtCen.Size = new System.Drawing.Size(56, 17);
            this.rbPtCen.TabIndex = 1;
            this.rbPtCen.TabStop = true;
            this.rbPtCen.Text = "Center";
            this.rbPtCen.UseVisualStyleBackColor = true;
            // 
            // txtPtQty
            // 
            this.txtPtQty.Location = new System.Drawing.Point(0, 2);
            this.txtPtQty.Name = "txtPtQty";
            this.txtPtQty.Size = new System.Drawing.Size(51, 20);
            this.txtPtQty.TabIndex = 0;
            // 
            // panMb
            // 
            this.panMb.Controls.Add(this.cbMbLs);
            this.panMb.Controls.Add(this.cbMbSs);
            this.panMb.Controls.Add(this.rbMbOther);
            this.panMb.Controls.Add(this.rbMbCen);
            this.panMb.Controls.Add(this.txtMbQty);
            this.panMb.Location = new System.Drawing.Point(180, 291);
            this.panMb.Name = "panMb";
            this.panMb.Size = new System.Drawing.Size(357, 25);
            this.panMb.TabIndex = 55;
            // 
            // cbMbLs
            // 
            this.cbMbLs.AutoSize = true;
            this.cbMbLs.Location = new System.Drawing.Point(318, 6);
            this.cbMbLs.Name = "cbMbLs";
            this.cbMbLs.Size = new System.Drawing.Size(39, 17);
            this.cbMbLs.TabIndex = 50;
            this.cbMbLs.Text = "LS";
            this.cbMbLs.UseVisualStyleBackColor = true;
            // 
            // cbMbSs
            // 
            this.cbMbSs.AutoSize = true;
            this.cbMbSs.Location = new System.Drawing.Point(281, 6);
            this.cbMbSs.Name = "cbMbSs";
            this.cbMbSs.Size = new System.Drawing.Size(40, 17);
            this.cbMbSs.TabIndex = 3;
            this.cbMbSs.Text = "SS";
            this.cbMbSs.UseVisualStyleBackColor = true;
            // 
            // rbMbOther
            // 
            this.rbMbOther.AutoSize = true;
            this.rbMbOther.Location = new System.Drawing.Point(171, 5);
            this.rbMbOther.Name = "rbMbOther";
            this.rbMbOther.Size = new System.Drawing.Size(51, 17);
            this.rbMbOther.TabIndex = 2;
            this.rbMbOther.TabStop = true;
            this.rbMbOther.Text = "Other";
            this.rbMbOther.UseVisualStyleBackColor = true;
            // 
            // rbMbCen
            // 
            this.rbMbCen.AutoSize = true;
            this.rbMbCen.Location = new System.Drawing.Point(118, 5);
            this.rbMbCen.Name = "rbMbCen";
            this.rbMbCen.Size = new System.Drawing.Size(56, 17);
            this.rbMbCen.TabIndex = 1;
            this.rbMbCen.TabStop = true;
            this.rbMbCen.Text = "Center";
            this.rbMbCen.UseVisualStyleBackColor = true;
            // 
            // txtMbQty
            // 
            this.txtMbQty.Location = new System.Drawing.Point(0, 2);
            this.txtMbQty.Name = "txtMbQty";
            this.txtMbQty.Size = new System.Drawing.Size(51, 20);
            this.txtMbQty.TabIndex = 0;
            // 
            // panGrom
            // 
            this.panGrom.Controls.Add(this.cbGromLs);
            this.panGrom.Controls.Add(this.cbGromSs);
            this.panGrom.Controls.Add(this.rbGromOther);
            this.panGrom.Controls.Add(this.rbGromCen);
            this.panGrom.Controls.Add(this.txtGromQty);
            this.panGrom.Location = new System.Drawing.Point(180, 323);
            this.panGrom.Name = "panGrom";
            this.panGrom.Size = new System.Drawing.Size(357, 25);
            this.panGrom.TabIndex = 56;
            // 
            // cbGromLs
            // 
            this.cbGromLs.AutoSize = true;
            this.cbGromLs.Location = new System.Drawing.Point(318, 6);
            this.cbGromLs.Name = "cbGromLs";
            this.cbGromLs.Size = new System.Drawing.Size(39, 17);
            this.cbGromLs.TabIndex = 50;
            this.cbGromLs.Text = "LS";
            this.cbGromLs.UseVisualStyleBackColor = true;
            // 
            // cbGromSs
            // 
            this.cbGromSs.AutoSize = true;
            this.cbGromSs.Location = new System.Drawing.Point(281, 6);
            this.cbGromSs.Name = "cbGromSs";
            this.cbGromSs.Size = new System.Drawing.Size(40, 17);
            this.cbGromSs.TabIndex = 3;
            this.cbGromSs.Text = "SS";
            this.cbGromSs.UseVisualStyleBackColor = true;
            // 
            // rbGromOther
            // 
            this.rbGromOther.AutoSize = true;
            this.rbGromOther.Location = new System.Drawing.Point(171, 5);
            this.rbGromOther.Name = "rbGromOther";
            this.rbGromOther.Size = new System.Drawing.Size(51, 17);
            this.rbGromOther.TabIndex = 2;
            this.rbGromOther.TabStop = true;
            this.rbGromOther.Text = "Other";
            this.rbGromOther.UseVisualStyleBackColor = true;
            // 
            // rbGromCen
            // 
            this.rbGromCen.AutoSize = true;
            this.rbGromCen.Location = new System.Drawing.Point(118, 5);
            this.rbGromCen.Name = "rbGromCen";
            this.rbGromCen.Size = new System.Drawing.Size(56, 17);
            this.rbGromCen.TabIndex = 1;
            this.rbGromCen.TabStop = true;
            this.rbGromCen.Text = "Center";
            this.rbGromCen.UseVisualStyleBackColor = true;
            // 
            // txtGromQty
            // 
            this.txtGromQty.Location = new System.Drawing.Point(0, 2);
            this.txtGromQty.Name = "txtGromQty";
            this.txtGromQty.Size = new System.Drawing.Size(51, 20);
            this.txtGromQty.TabIndex = 0;
            // 
            // cboxMargins
            // 
            this.cboxMargins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMargins.FormattingEnabled = true;
            this.cboxMargins.Location = new System.Drawing.Point(180, 56);
            this.cboxMargins.Name = "cboxMargins";
            this.cboxMargins.Size = new System.Drawing.Size(133, 21);
            this.cboxMargins.TabIndex = 57;
            // 
            // lblMargin
            // 
            this.lblMargin.AutoSize = true;
            this.lblMargin.Location = new System.Drawing.Point(177, 40);
            this.lblMargin.Name = "lblMargin";
            this.lblMargin.Size = new System.Drawing.Size(39, 13);
            this.lblMargin.TabIndex = 58;
            this.lblMargin.Text = "Margin";
            // 
            // formMainBindingSource
            // 
            this.formMainBindingSource.DataSource = typeof(Filtrea.formMain);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 664);
            this.Controls.Add(this.lblMargin);
            this.Controls.Add(this.cboxMargins);
            this.Controls.Add(this.panGrom);
            this.Controls.Add(this.panMb);
            this.Controls.Add(this.panPt);
            this.Controls.Add(this.panHardLbl);
            this.Controls.Add(this.panTs);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblItemQty);
            this.Controls.Add(this.btnAdd2Order);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.lvCurOrder);
            this.Controls.Add(this.cboxCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblCurOrder);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblItemDim);
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
            this.MaximumSize = new System.Drawing.Size(608, 703);
            this.MinimumSize = new System.Drawing.Size(608, 703);
            this.Name = "formMain";
            this.Text = "Filtrea 1.0 Beta";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panTs.ResumeLayout(false);
            this.panTs.PerformLayout();
            this.panHardLbl.ResumeLayout(false);
            this.panHardLbl.PerformLayout();
            this.panPt.ResumeLayout(false);
            this.panPt.PerformLayout();
            this.panMb.ResumeLayout(false);
            this.panMb.PerformLayout();
            this.panGrom.ResumeLayout(false);
            this.panGrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblItemDim;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblCurOrder;
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
        private System.Windows.Forms.Label lblItemQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblHwQty;
        private System.Windows.Forms.ToolStripMenuItem inputFilePathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputFilePathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSideSelection;
        private System.Windows.Forms.Panel panTs;
        private System.Windows.Forms.CheckBox cbTsLs;
        private System.Windows.Forms.CheckBox cbTsSs;
        private System.Windows.Forms.RadioButton rbTsOther;
        private System.Windows.Forms.RadioButton rbTsCen;
        private System.Windows.Forms.TextBox txtTsQty;
        private System.Windows.Forms.Panel panHardLbl;
        private System.Windows.Forms.Panel panPt;
        private System.Windows.Forms.CheckBox cbPtLs;
        private System.Windows.Forms.CheckBox cbPtSs;
        private System.Windows.Forms.RadioButton rbPtOther;
        private System.Windows.Forms.RadioButton rbPtCen;
        private System.Windows.Forms.TextBox txtPtQty;
        private System.Windows.Forms.Panel panMb;
        private System.Windows.Forms.CheckBox cbMbLs;
        private System.Windows.Forms.CheckBox cbMbSs;
        private System.Windows.Forms.RadioButton rbMbOther;
        private System.Windows.Forms.RadioButton rbMbCen;
        private System.Windows.Forms.TextBox txtMbQty;
        private System.Windows.Forms.Panel panGrom;
        private System.Windows.Forms.CheckBox cbGromLs;
        private System.Windows.Forms.CheckBox cbGromSs;
        private System.Windows.Forms.RadioButton rbGromOther;
        private System.Windows.Forms.RadioButton rbGromCen;
        private System.Windows.Forms.TextBox txtGromQty;
        private System.Windows.Forms.ComboBox cboxMargins;
        private System.Windows.Forms.Label lblMargin;
        private System.Windows.Forms.BindingSource formMainBindingSource;
    }
}

