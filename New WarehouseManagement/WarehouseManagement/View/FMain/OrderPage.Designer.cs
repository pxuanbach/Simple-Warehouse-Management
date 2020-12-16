namespace WarehouseManagement
{
    partial class OrderUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGVOrders = new System.Windows.Forms.DataGridView();
            this.MA_HANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DON_GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrAddOrder = new System.Windows.Forms.GroupBox();
            this.tBSoLuong = new System.Windows.Forms.TextBox();
            this.tBDonGia = new System.Windows.Forms.TextBox();
            this.tBTenHang = new System.Windows.Forms.TextBox();
            this.tBMaHang = new System.Windows.Forms.TextBox();
            this.BtSearch = new FontAwesome.Sharp.IconButton();
            this.BtAdd = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelTenHang = new System.Windows.Forms.Label();
            this.labelMaHang = new System.Windows.Forms.Label();
            this.pLe = new System.Windows.Forms.Panel();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.cBSelect = new System.Windows.Forms.ComboBox();
            this.dGVSearch = new System.Windows.Forms.DataGridView();
            this.MAHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBDoiTac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelThanhTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dTPTime = new System.Windows.Forms.DateTimePicker();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.BtHistory = new FontAwesome.Sharp.IconButton();
            this.BtCreateOrder = new FontAwesome.Sharp.IconButton();
            this.BtCancel = new FontAwesome.Sharp.IconButton();
            this.BtPrint = new FontAwesome.Sharp.IconButton();
            this.BtDelete = new FontAwesome.Sharp.IconButton();
            this.BtSave = new FontAwesome.Sharp.IconButton();
            this.BtEdit = new FontAwesome.Sharp.IconButton();
            this.BtMain = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).BeginInit();
            this.GrAddOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSearch)).BeginInit();
            this.panelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVOrders
            // 
            this.dGVOrders.AllowUserToAddRows = false;
            this.dGVOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_HANG,
            this.DON_GIA,
            this.SL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVOrders.Location = new System.Drawing.Point(11, 58);
            this.dGVOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dGVOrders.Name = "dGVOrders";
            this.dGVOrders.RowHeadersVisible = false;
            this.dGVOrders.RowHeadersWidth = 51;
            this.dGVOrders.Size = new System.Drawing.Size(519, 453);
            this.dGVOrders.TabIndex = 11;
            // 
            // MA_HANG
            // 
            this.MA_HANG.DataPropertyName = "MAHANG";
            this.MA_HANG.HeaderText = "Mã Hàng";
            this.MA_HANG.MinimumWidth = 6;
            this.MA_HANG.Name = "MA_HANG";
            // 
            // DON_GIA
            // 
            this.DON_GIA.DataPropertyName = "DONGIA";
            this.DON_GIA.HeaderText = "Đơn Giá";
            this.DON_GIA.MinimumWidth = 6;
            this.DON_GIA.Name = "DON_GIA";
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SOLUONG";
            this.SL.HeaderText = "Số Lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            this.SL.ToolTipText = "Chỉ có thể nhập số.";
            // 
            // GrAddOrder
            // 
            this.GrAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrAddOrder.Controls.Add(this.tBSoLuong);
            this.GrAddOrder.Controls.Add(this.tBDonGia);
            this.GrAddOrder.Controls.Add(this.tBTenHang);
            this.GrAddOrder.Controls.Add(this.tBMaHang);
            this.GrAddOrder.Controls.Add(this.BtSearch);
            this.GrAddOrder.Controls.Add(this.BtAdd);
            this.GrAddOrder.Controls.Add(this.label5);
            this.GrAddOrder.Controls.Add(this.panel5);
            this.GrAddOrder.Controls.Add(this.panel4);
            this.GrAddOrder.Controls.Add(this.panel3);
            this.GrAddOrder.Controls.Add(this.panel2);
            this.GrAddOrder.Controls.Add(this.labelDonGia);
            this.GrAddOrder.Controls.Add(this.labelSoLuong);
            this.GrAddOrder.Controls.Add(this.labelTenHang);
            this.GrAddOrder.Controls.Add(this.labelMaHang);
            this.GrAddOrder.Controls.Add(this.pLe);
            this.GrAddOrder.Controls.Add(this.tBSearch);
            this.GrAddOrder.Controls.Add(this.cBSelect);
            this.GrAddOrder.Controls.Add(this.dGVSearch);
            this.GrAddOrder.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrAddOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GrAddOrder.Location = new System.Drawing.Point(4, 10);
            this.GrAddOrder.Margin = new System.Windows.Forms.Padding(4);
            this.GrAddOrder.Name = "GrAddOrder";
            this.GrAddOrder.Padding = new System.Windows.Forms.Padding(4);
            this.GrAddOrder.Size = new System.Drawing.Size(585, 707);
            this.GrAddOrder.TabIndex = 30;
            this.GrAddOrder.TabStop = false;
            this.GrAddOrder.Text = "Tìm Kiếm Hàng Hóa";
            // 
            // tBSoLuong
            // 
            this.tBSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSoLuong.Location = new System.Drawing.Point(128, 606);
            this.tBSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBSoLuong.Name = "tBSoLuong";
            this.tBSoLuong.Size = new System.Drawing.Size(416, 23);
            this.tBSoLuong.TabIndex = 47;
            // 
            // tBDonGia
            // 
            this.tBDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBDonGia.Location = new System.Drawing.Point(119, 563);
            this.tBDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBDonGia.Name = "tBDonGia";
            this.tBDonGia.Size = new System.Drawing.Size(425, 23);
            this.tBDonGia.TabIndex = 46;
            // 
            // tBTenHang
            // 
            this.tBTenHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBTenHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTenHang.Location = new System.Drawing.Point(125, 523);
            this.tBTenHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBTenHang.Name = "tBTenHang";
            this.tBTenHang.Size = new System.Drawing.Size(419, 23);
            this.tBTenHang.TabIndex = 41;
            // 
            // tBMaHang
            // 
            this.tBMaHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBMaHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBMaHang.Location = new System.Drawing.Point(125, 480);
            this.tBMaHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBMaHang.Name = "tBMaHang";
            this.tBMaHang.Size = new System.Drawing.Size(419, 23);
            this.tBMaHang.TabIndex = 5;
            // 
            // BtSearch
            // 
            this.BtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtSearch.FlatAppearance.BorderSize = 0;
            this.BtSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(201)))), ((int)(((byte)(189)))));
            this.BtSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.BtSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtSearch.IconSize = 27;
            this.BtSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSearch.Location = new System.Drawing.Point(508, 423);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(70, 35);
            this.BtSearch.TabIndex = 70;
            this.BtSearch.UseVisualStyleBackColor = false;
            this.BtSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.BtAdd.FlatAppearance.BorderSize = 0;
            this.BtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAdd.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtAdd.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.BtAdd.IconColor = System.Drawing.Color.White;
            this.BtAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtAdd.IconSize = 37;
            this.BtAdd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtAdd.Location = new System.Drawing.Point(424, 642);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(133, 52);
            this.BtAdd.TabIndex = 68;
            this.BtAdd.Text = "Thêm";
            this.BtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "VND";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(124, 630);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(420, 1);
            this.panel5.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(112, 587);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(432, 1);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(111, 548);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 1);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(119, 505);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 1);
            this.panel2.TabIndex = 5;
            // 
            // labelDonGia
            // 
            this.labelDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonGia.Location = new System.Drawing.Point(17, 561);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(83, 24);
            this.labelDonGia.TabIndex = 44;
            this.labelDonGia.Text = "Đơn Giá:";
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.Location = new System.Drawing.Point(17, 603);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(97, 24);
            this.labelSoLuong.TabIndex = 42;
            this.labelSoLuong.Text = "Số Lượng:";
            // 
            // labelTenHang
            // 
            this.labelTenHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTenHang.AutoSize = true;
            this.labelTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenHang.Location = new System.Drawing.Point(17, 520);
            this.labelTenHang.Name = "labelTenHang";
            this.labelTenHang.Size = new System.Drawing.Size(100, 24);
            this.labelTenHang.TabIndex = 40;
            this.labelTenHang.Text = "Tên Hàng:";
            // 
            // labelMaHang
            // 
            this.labelMaHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaHang.AutoSize = true;
            this.labelMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaHang.Location = new System.Drawing.Point(17, 477);
            this.labelMaHang.Name = "labelMaHang";
            this.labelMaHang.Size = new System.Drawing.Size(92, 24);
            this.labelMaHang.TabIndex = 39;
            this.labelMaHang.Text = "Mã Hàng:";
            // 
            // pLe
            // 
            this.pLe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pLe.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pLe.Location = new System.Drawing.Point(133, 451);
            this.pLe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pLe.Name = "pLe";
            this.pLe.Size = new System.Drawing.Size(372, 1);
            this.pLe.TabIndex = 4;
            // 
            // tBSearch
            // 
            this.tBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.Location = new System.Drawing.Point(138, 426);
            this.tBSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(364, 23);
            this.tBSearch.TabIndex = 2;
            this.tBSearch.TextChanged += new System.EventHandler(this.tBSearch_TextChanged);
            // 
            // cBSelect
            // 
            this.cBSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBSelect.AutoCompleteCustomSource.AddRange(new string[] {
            "Mã Hàng",
            "Tên Hàng",
            "Ngày Nhập"});
            this.cBSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSelect.FormattingEnabled = true;
            this.cBSelect.Items.AddRange(new object[] {
            "Mã Hàng",
            "Tên Hàng",
            "Ngày Nhập"});
            this.cBSelect.Location = new System.Drawing.Point(7, 423);
            this.cBSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBSelect.Name = "cBSelect";
            this.cBSelect.Size = new System.Drawing.Size(125, 33);
            this.cBSelect.TabIndex = 1;
            // 
            // dGVSearch
            // 
            this.dGVSearch.AllowUserToAddRows = false;
            this.dGVSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.dGVSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHANG,
            this.TENHANG,
            this.NGNHAP,
            this.DONGIA,
            this.SoLuong});
            this.dGVSearch.Location = new System.Drawing.Point(7, 29);
            this.dGVSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVSearch.Name = "dGVSearch";
            this.dGVSearch.RowHeadersVisible = false;
            this.dGVSearch.RowHeadersWidth = 51;
            this.dGVSearch.RowTemplate.Height = 24;
            this.dGVSearch.Size = new System.Drawing.Size(571, 388);
            this.dGVSearch.TabIndex = 0;
            this.dGVSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSearch_CellContentClick);
            // 
            // MAHANG
            // 
            this.MAHANG.DataPropertyName = "MAHANG";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAHANG.DefaultCellStyle = dataGridViewCellStyle3;
            this.MAHANG.HeaderText = "Mã Hàng";
            this.MAHANG.MinimumWidth = 6;
            this.MAHANG.Name = "MAHANG";
            this.MAHANG.ReadOnly = true;
            // 
            // TENHANG
            // 
            this.TENHANG.DataPropertyName = "TENHANG";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TENHANG.DefaultCellStyle = dataGridViewCellStyle4;
            this.TENHANG.HeaderText = "Tên Hàng";
            this.TENHANG.MinimumWidth = 6;
            this.TENHANG.Name = "TENHANG";
            this.TENHANG.ReadOnly = true;
            // 
            // NGNHAP
            // 
            this.NGNHAP.DataPropertyName = "NGNHAP";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGNHAP.DefaultCellStyle = dataGridViewCellStyle5;
            this.NGNHAP.HeaderText = "Ngày Nhập";
            this.NGNHAP.MinimumWidth = 6;
            this.NGNHAP.Name = "NGNHAP";
            this.NGNHAP.ReadOnly = true;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONGIA.DefaultCellStyle = dataGridViewCellStyle6;
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SOLUONG";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.DefaultCellStyle = dataGridViewCellStyle7;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // tBDoiTac
            // 
            this.tBDoiTac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBDoiTac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBDoiTac.Location = new System.Drawing.Point(93, 527);
            this.tBDoiTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBDoiTac.Name = "tBDoiTac";
            this.tBDoiTac.Size = new System.Drawing.Size(433, 23);
            this.tBDoiTac.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Đối Tác:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Thời Gian:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Thành Tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 36;
            // 
            // labelThanhTien
            // 
            this.labelThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThanhTien.Location = new System.Drawing.Point(428, 574);
            this.labelThanhTien.Name = "labelThanhTien";
            this.labelThanhTien.Size = new System.Drawing.Size(100, 24);
            this.labelThanhTien.TabIndex = 37;
            this.labelThanhTien.Text = "00000000.";
            this.labelThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "VND";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(87, 551);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 1);
            this.panel1.TabIndex = 5;
            // 
            // dTPTime
            // 
            this.dTPTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dTPTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPTime.Location = new System.Drawing.Point(111, 575);
            this.dTPTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPTime.Name = "dTPTime";
            this.dTPTime.Size = new System.Drawing.Size(203, 30);
            this.dTPTime.TabIndex = 49;
            // 
            // panelOrder
            // 
            this.panelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOrder.Controls.Add(this.BtHistory);
            this.panelOrder.Controls.Add(this.BtCreateOrder);
            this.panelOrder.Controls.Add(this.BtCancel);
            this.panelOrder.Controls.Add(this.BtPrint);
            this.panelOrder.Controls.Add(this.BtDelete);
            this.panelOrder.Controls.Add(this.BtSave);
            this.panelOrder.Controls.Add(this.BtEdit);
            this.panelOrder.Controls.Add(this.BtMain);
            this.panelOrder.Controls.Add(this.label9);
            this.panelOrder.Controls.Add(this.panel6);
            this.panelOrder.Controls.Add(this.label8);
            this.panelOrder.Controls.Add(this.label7);
            this.panelOrder.Controls.Add(this.dTPTime);
            this.panelOrder.Controls.Add(this.panel1);
            this.panelOrder.Controls.Add(this.label6);
            this.panelOrder.Controls.Add(this.labelThanhTien);
            this.panelOrder.Controls.Add(this.label4);
            this.panelOrder.Controls.Add(this.label3);
            this.panelOrder.Controls.Add(this.label2);
            this.panelOrder.Controls.Add(this.label1);
            this.panelOrder.Controls.Add(this.dGVOrders);
            this.panelOrder.Controls.Add(this.tBDoiTac);
            this.panelOrder.Location = new System.Drawing.Point(619, 2);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(540, 717);
            this.panelOrder.TabIndex = 50;
            // 
            // BtHistory
            // 
            this.BtHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.BtHistory.FlatAppearance.BorderSize = 0;
            this.BtHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtHistory.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtHistory.IconChar = FontAwesome.Sharp.IconChar.History;
            this.BtHistory.IconColor = System.Drawing.Color.White;
            this.BtHistory.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtHistory.IconSize = 35;
            this.BtHistory.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtHistory.Location = new System.Drawing.Point(384, 3);
            this.BtHistory.Name = "BtHistory";
            this.BtHistory.Size = new System.Drawing.Size(146, 48);
            this.BtHistory.TabIndex = 69;
            this.BtHistory.Text = "Lịch Sử";
            this.BtHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtHistory.UseVisualStyleBackColor = false;
            this.BtHistory.Click += new System.EventHandler(this.BtHistory_Click);
            // 
            // BtCreateOrder
            // 
            this.BtCreateOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtCreateOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtCreateOrder.FlatAppearance.BorderSize = 0;
            this.BtCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCreateOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(201)))), ((int)(((byte)(189)))));
            this.BtCreateOrder.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.BtCreateOrder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.BtCreateOrder.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtCreateOrder.IconSize = 40;
            this.BtCreateOrder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtCreateOrder.Location = new System.Drawing.Point(87, 647);
            this.BtCreateOrder.Name = "BtCreateOrder";
            this.BtCreateOrder.Size = new System.Drawing.Size(60, 55);
            this.BtCreateOrder.TabIndex = 67;
            this.BtCreateOrder.UseVisualStyleBackColor = false;
            this.BtCreateOrder.Click += new System.EventHandler(this.btCreateOrder_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtCancel.FlatAppearance.BorderSize = 0;
            this.BtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(201)))), ((int)(((byte)(189)))));
            this.BtCancel.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtCancel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.BtCancel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtCancel.IconSize = 40;
            this.BtCancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtCancel.Location = new System.Drawing.Point(442, 647);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(60, 55);
            this.BtCancel.TabIndex = 66;
            this.BtCancel.UseVisualStyleBackColor = false;
            this.BtCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // BtPrint
            // 
            this.BtPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtPrint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtPrint.FlatAppearance.BorderSize = 0;
            this.BtPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(201)))), ((int)(((byte)(189)))));
            this.BtPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtPrint.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.BtPrint.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtPrint.IconSize = 40;
            this.BtPrint.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtPrint.Location = new System.Drawing.Point(229, 647);
            this.BtPrint.Name = "BtPrint";
            this.BtPrint.Size = new System.Drawing.Size(60, 55);
            this.BtPrint.TabIndex = 65;
            this.BtPrint.UseVisualStyleBackColor = false;
            // 
            // BtDelete
            // 
            this.BtDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtDelete.FlatAppearance.BorderSize = 0;
            this.BtDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(201)))), ((int)(((byte)(189)))));
            this.BtDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.BtDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtDelete.IconSize = 37;
            this.BtDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtDelete.Location = new System.Drawing.Point(371, 647);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(60, 55);
            this.BtDelete.TabIndex = 64;
            this.BtDelete.UseVisualStyleBackColor = false;
            this.BtDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // BtSave
            // 
            this.BtSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtSave.FlatAppearance.BorderSize = 0;
            this.BtSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(201)))), ((int)(((byte)(189)))));
            this.BtSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.BtSave.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtSave.IconSize = 40;
            this.BtSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSave.Location = new System.Drawing.Point(158, 647);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(60, 55);
            this.BtSave.TabIndex = 63;
            this.BtSave.UseVisualStyleBackColor = false;
            this.BtSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // BtEdit
            // 
            this.BtEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtEdit.FlatAppearance.BorderSize = 0;
            this.BtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(201)))), ((int)(((byte)(189)))));
            this.BtEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.BtEdit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtEdit.IconSize = 40;
            this.BtEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEdit.Location = new System.Drawing.Point(300, 647);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(60, 55);
            this.BtEdit.TabIndex = 62;
            this.BtEdit.UseVisualStyleBackColor = false;
            this.BtEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // BtMain
            // 
            this.BtMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtMain.FlatAppearance.BorderSize = 0;
            this.BtMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(201)))), ((int)(((byte)(189)))));
            this.BtMain.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.BtMain.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.BtMain.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtMain.IconSize = 55;
            this.BtMain.Location = new System.Drawing.Point(11, 636);
            this.BtMain.Name = "BtMain";
            this.BtMain.Size = new System.Drawing.Size(60, 55);
            this.BtMain.TabIndex = 61;
            this.BtMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtMain.UseVisualStyleBackColor = false;
            this.BtMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(287, 650);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 24);
            this.label9.TabIndex = 60;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Khaki;
            this.panel6.Location = new System.Drawing.Point(11, 43);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(155, 2);
            this.panel6.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 615);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 56;
            this.label8.Text = "Tùy chọn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.label7.Location = new System.Drawing.Point(7, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 23);
            this.label7.TabIndex = 54;
            this.label7.Text = "Chi Tiết Hóa Đơn:";
            // 
            // buttonTimer
            // 
            this.buttonTimer.Interval = 50;
            this.buttonTimer.Tick += new System.EventHandler(this.buttonTimer_Tick);
            // 
            // OrderUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.GrAddOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderUser";
            this.Size = new System.Drawing.Size(1161, 721);
            this.Load += new System.EventHandler(this.OderUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).EndInit();
            this.GrAddOrder.ResumeLayout(false);
            this.GrAddOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSearch)).EndInit();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVOrders;
        private System.Windows.Forms.GroupBox GrAddOrder;
        private System.Windows.Forms.Panel pLe;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.ComboBox cBSelect;
        private System.Windows.Forms.DataGridView dGVSearch;
        private System.Windows.Forms.TextBox tBDoiTac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelThanhTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTenHang;
        private System.Windows.Forms.Label labelMaHang;
        private System.Windows.Forms.TextBox tBMaHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tBSoLuong;
        private System.Windows.Forms.TextBox tBDonGia;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.TextBox tBTenHang;
        private System.Windows.Forms.DateTimePicker dTPTime;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Timer buttonTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_HANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DON_GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton BtCreateOrder;
        private FontAwesome.Sharp.IconButton BtCancel;
        private FontAwesome.Sharp.IconButton BtPrint;
        private FontAwesome.Sharp.IconButton BtDelete;
        private FontAwesome.Sharp.IconButton BtSave;
        private FontAwesome.Sharp.IconButton BtEdit;
        private FontAwesome.Sharp.IconButton BtMain;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton BtAdd;
        private FontAwesome.Sharp.IconButton BtHistory;
        private FontAwesome.Sharp.IconButton BtSearch;
    }
}