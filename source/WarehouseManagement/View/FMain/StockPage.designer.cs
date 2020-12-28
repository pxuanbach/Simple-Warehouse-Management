namespace WarehouseManagement
{
    partial class StockPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockPage));
            this.cBSearch = new System.Windows.Forms.ComboBox();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.dGVStock = new System.Windows.Forms.DataGridView();
            this.MAHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_NGTHEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMSWarehouse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButton = new System.Windows.Forms.Panel();
            this.BtRefresh = new FontAwesome.Sharp.IconButton();
            this.BtPrint = new FontAwesome.Sharp.IconButton();
            this.BtBin = new System.Windows.Forms.Button();
            this.BtHistory = new FontAwesome.Sharp.IconButton();
            this.BtDel = new FontAwesome.Sharp.IconButton();
            this.BtEdit = new FontAwesome.Sharp.IconButton();
            this.BtAdd = new FontAwesome.Sharp.IconButton();
            this.paneltBSearch = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtSearch = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStock)).BeginInit();
            this.cMSWarehouse.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBSearch
            // 
            this.cBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSearch.FormattingEnabled = true;
            this.cBSearch.ItemHeight = 29;
            this.cBSearch.Items.AddRange(new object[] {
            "Mã Hàng",
            "Tên Hàng",
            "Ngày Nhập"});
            this.cBSearch.Location = new System.Drawing.Point(63, 595);
            this.cBSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBSearch.Name = "cBSearch";
            this.cBSearch.Size = new System.Drawing.Size(184, 37);
            this.cBSearch.TabIndex = 6;
            // 
            // tBSearch
            // 
            this.tBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tBSearch.Location = new System.Drawing.Point(254, 598);
            this.tBSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tBSearch.MaxLength = 100;
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(754, 31);
            this.tBSearch.TabIndex = 7;
            this.tBSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // dGVStock
            // 
            this.dGVStock.AllowUserToAddRows = false;
            this.dGVStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHANG,
            this.TENHANG,
            this.DVT,
            this.SOLUONG,
            this.DONGIA,
            this.NGNHAP,
            this.NSX,
            this.HSD,
            this.MA_NGTHEM});
            this.dGVStock.ContextMenuStrip = this.cMSWarehouse;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVStock.Location = new System.Drawing.Point(13, 6);
            this.dGVStock.Margin = new System.Windows.Forms.Padding(4);
            this.dGVStock.Name = "dGVStock";
            this.dGVStock.RowHeadersVisible = false;
            this.dGVStock.RowHeadersWidth = 51;
            this.dGVStock.Size = new System.Drawing.Size(1197, 556);
            this.dGVStock.TabIndex = 100;
            // 
            // MAHANG
            // 
            this.MAHANG.DataPropertyName = "MAHANG";
            this.MAHANG.HeaderText = "Mã Hàng";
            this.MAHANG.MinimumWidth = 6;
            this.MAHANG.Name = "MAHANG";
            // 
            // TENHANG
            // 
            this.TENHANG.DataPropertyName = "TENHANG";
            this.TENHANG.HeaderText = "Tên Hàng";
            this.TENHANG.MinimumWidth = 6;
            this.TENHANG.Name = "TENHANG";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            // 
            // NGNHAP
            // 
            this.NGNHAP.DataPropertyName = "NGNHAP";
            this.NGNHAP.HeaderText = "Ngày Nhập";
            this.NGNHAP.MinimumWidth = 6;
            this.NGNHAP.Name = "NGNHAP";
            // 
            // NSX
            // 
            this.NSX.DataPropertyName = "NGSANXUAT";
            this.NSX.HeaderText = "Ngày Sản Xuất";
            this.NSX.MinimumWidth = 6;
            this.NSX.Name = "NSX";
            // 
            // HSD
            // 
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "Hạn Sử Dụng";
            this.HSD.MinimumWidth = 6;
            this.HSD.Name = "HSD";
            // 
            // MA_NGTHEM
            // 
            this.MA_NGTHEM.DataPropertyName = "UKEY";
            this.MA_NGTHEM.HeaderText = "Mã Người Thêm";
            this.MA_NGTHEM.MinimumWidth = 6;
            this.MA_NGTHEM.Name = "MA_NGTHEM";
            // 
            // cMSWarehouse
            // 
            this.cMSWarehouse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMSWarehouse.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMSWarehouse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.inToolStripMenuItem,
            this.lịchSửToolStripMenuItem,
            this.làmMớiToolStripMenuItem});
            this.cMSWarehouse.Name = "cMSWarehouse";
            this.cMSWarehouse.Size = new System.Drawing.Size(151, 172);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Image = global::WarehouseManagement.Properties.Resources.add;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Image = global::WarehouseManagement.Properties.Resources.edit_button;
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::WarehouseManagement.Properties.Resources.minus;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.AutoSize = false;
            this.inToolStripMenuItem.Image = global::WarehouseManagement.Properties.Resources.printing_tool;
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.inToolStripMenuItem.Text = "In";
            this.inToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // lịchSửToolStripMenuItem
            // 
            this.lịchSửToolStripMenuItem.Image = global::WarehouseManagement.Properties.Resources.clock;
            this.lịchSửToolStripMenuItem.Name = "lịchSửToolStripMenuItem";
            this.lịchSửToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.lịchSửToolStripMenuItem.Text = "Lịch Sử";
            this.lịchSửToolStripMenuItem.Click += new System.EventHandler(this.HistoryToolStripMenuItem_Click);
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.Image = global::WarehouseManagement.Properties.Resources.refresh_page_option;
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(150, 28);
            this.làmMớiToolStripMenuItem.Text = "Làm Mới";
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.BtRefresh);
            this.panelButton.Controls.Add(this.BtPrint);
            this.panelButton.Controls.Add(this.BtBin);
            this.panelButton.Controls.Add(this.BtHistory);
            this.panelButton.Controls.Add(this.BtDel);
            this.panelButton.Controls.Add(this.BtEdit);
            this.panelButton.Controls.Add(this.BtAdd);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 650);
            this.panelButton.Margin = new System.Windows.Forms.Padding(4);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1225, 140);
            this.panelButton.TabIndex = 9;
            // 
            // BtRefresh
            // 
            this.BtRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtRefresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtRefresh.FlatAppearance.BorderSize = 0;
            this.BtRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtRefresh.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRefresh.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.BtRefresh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.BtRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtRefresh.Location = new System.Drawing.Point(831, 36);
            this.BtRefresh.Name = "BtRefresh";
            this.BtRefresh.Size = new System.Drawing.Size(167, 66);
            this.BtRefresh.TabIndex = 5;
            this.BtRefresh.Text = "Làm Mới";
            this.BtRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtRefresh.UseVisualStyleBackColor = false;
            this.BtRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // BtPrint
            // 
            this.BtPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtPrint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtPrint.FlatAppearance.BorderSize = 0;
            this.BtPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPrint.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtPrint.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.BtPrint.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtPrint.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtPrint.Location = new System.Drawing.Point(504, 35);
            this.BtPrint.Name = "BtPrint";
            this.BtPrint.Size = new System.Drawing.Size(138, 66);
            this.BtPrint.TabIndex = 3;
            this.BtPrint.Text = "In   ";
            this.BtPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtPrint.UseVisualStyleBackColor = false;
            this.BtPrint.Click += new System.EventHandler(this.BtPrint_Click);
            // 
            // BtBin
            // 
            this.BtBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtBin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtBin.FlatAppearance.BorderSize = 0;
            this.BtBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.BtBin.Image = ((System.Drawing.Image)(resources.GetObject("BtBin.Image")));
            this.BtBin.Location = new System.Drawing.Point(1009, 35);
            this.BtBin.Name = "BtBin";
            this.BtBin.Size = new System.Drawing.Size(72, 66);
            this.BtBin.TabIndex = 6;
            this.BtBin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBin.UseVisualStyleBackColor = false;
            this.BtBin.Click += new System.EventHandler(this.BtBin_Click);
            // 
            // BtHistory
            // 
            this.BtHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtHistory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtHistory.FlatAppearance.BorderSize = 0;
            this.BtHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtHistory.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtHistory.IconChar = FontAwesome.Sharp.IconChar.History;
            this.BtHistory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.BtHistory.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtHistory.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtHistory.Location = new System.Drawing.Point(653, 36);
            this.BtHistory.Name = "BtHistory";
            this.BtHistory.Size = new System.Drawing.Size(167, 66);
            this.BtHistory.TabIndex = 4;
            this.BtHistory.Text = "Lịch Sử";
            this.BtHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtHistory.UseVisualStyleBackColor = false;
            this.BtHistory.Click += new System.EventHandler(this.BtHistory_Click);
            // 
            // BtDel
            // 
            this.BtDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtDel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtDel.FlatAppearance.BorderSize = 0;
            this.BtDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDel.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.BtDel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.BtDel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtDel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtDel.Location = new System.Drawing.Point(355, 35);
            this.BtDel.Name = "BtDel";
            this.BtDel.Size = new System.Drawing.Size(138, 66);
            this.BtDel.TabIndex = 2;
            this.BtDel.Text = "Xóa ";
            this.BtDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtDel.UseVisualStyleBackColor = false;
            this.BtDel.Click += new System.EventHandler(this.BtDel_Click);
            // 
            // BtEdit
            // 
            this.BtEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtEdit.FlatAppearance.BorderSize = 0;
            this.BtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEdit.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.BtEdit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtEdit.IconSize = 50;
            this.BtEdit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtEdit.Location = new System.Drawing.Point(206, 35);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(138, 66);
            this.BtEdit.TabIndex = 1;
            this.BtEdit.Text = "Sửa ";
            this.BtEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtEdit.UseVisualStyleBackColor = false;
            this.BtEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtAdd.FlatAppearance.BorderSize = 0;
            this.BtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAdd.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.BtAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtAdd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtAdd.Location = new System.Drawing.Point(54, 35);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(141, 66);
            this.BtAdd.TabIndex = 0;
            this.BtAdd.Text = "Thêm";
            this.BtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // paneltBSearch
            // 
            this.paneltBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneltBSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paneltBSearch.Location = new System.Drawing.Point(63, 626);
            this.paneltBSearch.Margin = new System.Windows.Forms.Padding(4);
            this.paneltBSearch.Name = "paneltBSearch";
            this.paneltBSearch.Size = new System.Drawing.Size(945, 1);
            this.paneltBSearch.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.BtSearch);
            this.panel2.Controls.Add(this.paneltBSearch);
            this.panel2.Controls.Add(this.cBSearch);
            this.panel2.Controls.Add(this.tBSearch);
            this.panel2.Controls.Add(this.dGVStock);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 650);
            this.panel2.TabIndex = 101;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtSearch
            // 
            this.BtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSearch.AutoSize = true;
            this.BtSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtSearch.BorderColor = System.Drawing.Color.Silver;
            this.BtSearch.ButtonColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtSearch.FlatAppearance.BorderSize = 0;
            this.BtSearch.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtSearch.Location = new System.Drawing.Point(1015, 597);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.BtSearch.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtSearch.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtSearch.Size = new System.Drawing.Size(135, 30);
            this.BtSearch.TabIndex = 8;
            this.BtSearch.Text = "Search";
            this.BtSearch.TextColor = System.Drawing.Color.DimGray;
            this.BtSearch.UseVisualStyleBackColor = false;
            this.BtSearch.Click += new System.EventHandler(this.BtSearch_Click);
            this.BtSearch.Enter += new System.EventHandler(this.BtSearch_Enter);
            this.BtSearch.Leave += new System.EventHandler(this.BtSearch_Leave);
            // 
            // StockPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockPage";
            this.Size = new System.Drawing.Size(1225, 790);
            this.Load += new System.EventHandler(this.StockUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVStock)).EndInit();
            this.cMSWarehouse.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cBSearch;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.DataGridView dGVStock;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel paneltBSearch;
        private FontAwesome.Sharp.IconButton BtDel;
        private FontAwesome.Sharp.IconButton BtEdit;
        private FontAwesome.Sharp.IconButton BtAdd;
        private ePOSOne.btnProduct.Button_WOC BtSearch;
        private FontAwesome.Sharp.IconButton BtHistory;
        private System.Windows.Forms.Button BtBin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NGTHEM;
        private System.Windows.Forms.ContextMenuStrip cMSWarehouse;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
        private FontAwesome.Sharp.IconButton BtPrint;
        private FontAwesome.Sharp.IconButton BtRefresh;
    }
}
