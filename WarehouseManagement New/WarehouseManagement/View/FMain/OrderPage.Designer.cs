namespace WarehouseManagement
{
    partial class OderUser
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
            this.GrAddOrder = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBSoLuong = new System.Windows.Forms.TextBox();
            this.tBDonGia = new System.Windows.Forms.TextBox();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.tBTenHang = new System.Windows.Forms.TextBox();
            this.labelTenHang = new System.Windows.Forms.Label();
            this.labelMaHang = new System.Windows.Forms.Label();
            this.tBMaHang = new System.Windows.Forms.TextBox();
            this.pLe = new System.Windows.Forms.Panel();
            this.btSearch = new System.Windows.Forms.Button();
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
            this.btCreateOrder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btMain = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.buttonTimer = new System.Windows.Forms.Timer(this.components);
            this.MA_HANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DON_GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrders)).BeginInit();
            this.GrAddOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSearch)).BeginInit();
            this.panelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVOrders
            // 
            this.dGVOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVOrders.Location = new System.Drawing.Point(11, 47);
            this.dGVOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dGVOrders.Name = "dGVOrders";
            this.dGVOrders.RowHeadersVisible = false;
            this.dGVOrders.RowHeadersWidth = 51;
            this.dGVOrders.Size = new System.Drawing.Size(476, 304);
            this.dGVOrders.TabIndex = 11;
            // 
            // GrAddOrder
            // 
            this.GrAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrAddOrder.Controls.Add(this.btAdd);
            this.GrAddOrder.Controls.Add(this.label5);
            this.GrAddOrder.Controls.Add(this.panel5);
            this.GrAddOrder.Controls.Add(this.panel4);
            this.GrAddOrder.Controls.Add(this.panel3);
            this.GrAddOrder.Controls.Add(this.panel2);
            this.GrAddOrder.Controls.Add(this.tBSoLuong);
            this.GrAddOrder.Controls.Add(this.tBDonGia);
            this.GrAddOrder.Controls.Add(this.labelDonGia);
            this.GrAddOrder.Controls.Add(this.labelSoLuong);
            this.GrAddOrder.Controls.Add(this.tBTenHang);
            this.GrAddOrder.Controls.Add(this.labelTenHang);
            this.GrAddOrder.Controls.Add(this.labelMaHang);
            this.GrAddOrder.Controls.Add(this.tBMaHang);
            this.GrAddOrder.Controls.Add(this.pLe);
            this.GrAddOrder.Controls.Add(this.btSearch);
            this.GrAddOrder.Controls.Add(this.tBSearch);
            this.GrAddOrder.Controls.Add(this.cBSelect);
            this.GrAddOrder.Controls.Add(this.dGVSearch);
            this.GrAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrAddOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GrAddOrder.Location = new System.Drawing.Point(4, 10);
            this.GrAddOrder.Margin = new System.Windows.Forms.Padding(4);
            this.GrAddOrder.Name = "GrAddOrder";
            this.GrAddOrder.Padding = new System.Windows.Forms.Padding(4);
            this.GrAddOrder.Size = new System.Drawing.Size(465, 532);
            this.GrAddOrder.TabIndex = 30;
            this.GrAddOrder.TabStop = false;
            this.GrAddOrder.Text = "Creat New Order";
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Image = global::WarehouseManagement.Properties.Resources.ICAdd;
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.Location = new System.Drawing.Point(332, 480);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(109, 46);
            this.btAdd.TabIndex = 51;
            this.btAdd.Text = "ADD";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 386);
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
            this.panel5.Location = new System.Drawing.Point(124, 453);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 1);
            this.panel5.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(112, 410);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(312, 1);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(111, 370);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 1);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(119, 327);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 1);
            this.panel2.TabIndex = 5;
            // 
            // tBSoLuong
            // 
            this.tBSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tBSoLuong.Location = new System.Drawing.Point(128, 432);
            this.tBSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBSoLuong.Name = "tBSoLuong";
            this.tBSoLuong.Size = new System.Drawing.Size(296, 20);
            this.tBSoLuong.TabIndex = 47;
            // 
            // tBDonGia
            // 
            this.tBDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBDonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tBDonGia.Location = new System.Drawing.Point(119, 389);
            this.tBDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBDonGia.Name = "tBDonGia";
            this.tBDonGia.Size = new System.Drawing.Size(305, 20);
            this.tBDonGia.TabIndex = 46;
            // 
            // labelDonGia
            // 
            this.labelDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonGia.Location = new System.Drawing.Point(17, 386);
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
            this.labelSoLuong.Location = new System.Drawing.Point(17, 428);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(97, 24);
            this.labelSoLuong.TabIndex = 42;
            this.labelSoLuong.Text = "Số Lượng:";
            // 
            // tBTenHang
            // 
            this.tBTenHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBTenHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tBTenHang.Location = new System.Drawing.Point(125, 347);
            this.tBTenHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBTenHang.Name = "tBTenHang";
            this.tBTenHang.Size = new System.Drawing.Size(299, 20);
            this.tBTenHang.TabIndex = 41;
            // 
            // labelTenHang
            // 
            this.labelTenHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTenHang.AutoSize = true;
            this.labelTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenHang.Location = new System.Drawing.Point(17, 345);
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
            this.labelMaHang.Location = new System.Drawing.Point(17, 302);
            this.labelMaHang.Name = "labelMaHang";
            this.labelMaHang.Size = new System.Drawing.Size(92, 24);
            this.labelMaHang.TabIndex = 39;
            this.labelMaHang.Text = "Mã Hàng:";
            // 
            // tBMaHang
            // 
            this.tBMaHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBMaHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tBMaHang.Location = new System.Drawing.Point(125, 306);
            this.tBMaHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBMaHang.Name = "tBMaHang";
            this.tBMaHang.Size = new System.Drawing.Size(299, 20);
            this.tBMaHang.TabIndex = 5;
            // 
            // pLe
            // 
            this.pLe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pLe.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pLe.Location = new System.Drawing.Point(133, 276);
            this.pLe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pLe.Name = "pLe";
            this.pLe.Size = new System.Drawing.Size(261, 1);
            this.pLe.TabIndex = 4;
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.Image = global::WarehouseManagement.Properties.Resources.ICsearch;
            this.btSearch.Location = new System.Drawing.Point(401, 246);
            this.btSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(59, 30);
            this.btSearch.TabIndex = 3;
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tBSearch
            // 
            this.tBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.Location = new System.Drawing.Point(139, 251);
            this.tBSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(257, 23);
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
            this.cBSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cBSelect.FormattingEnabled = true;
            this.cBSelect.Items.AddRange(new object[] {
            "Mã Hàng",
            "Tên Hàng",
            "Ngày Nhập"});
            this.cBSelect.Location = new System.Drawing.Point(7, 246);
            this.cBSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBSelect.Name = "cBSelect";
            this.cBSelect.Size = new System.Drawing.Size(125, 28);
            this.cBSelect.TabIndex = 1;
            // 
            // dGVSearch
            // 
            this.dGVSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHANG,
            this.TENHANG,
            this.NGNHAP,
            this.DONGIA,
            this.SoLuong});
            this.dGVSearch.Location = new System.Drawing.Point(7, 25);
            this.dGVSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVSearch.Name = "dGVSearch";
            this.dGVSearch.RowHeadersVisible = false;
            this.dGVSearch.RowHeadersWidth = 51;
            this.dGVSearch.RowTemplate.Height = 24;
            this.dGVSearch.Size = new System.Drawing.Size(451, 215);
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
            this.tBDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBDoiTac.Location = new System.Drawing.Point(91, 367);
            this.tBDoiTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBDoiTac.Name = "tBDoiTac";
            this.tBDoiTac.Size = new System.Drawing.Size(395, 20);
            this.tBDoiTac.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 367);
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
            this.label2.Location = new System.Drawing.Point(3, 416);
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
            this.label3.Location = new System.Drawing.Point(272, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Thành Tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 36;
            // 
            // labelThanhTien
            // 
            this.labelThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThanhTien.Location = new System.Drawing.Point(381, 411);
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
            this.label6.Location = new System.Drawing.Point(436, 441);
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
            this.panel1.Location = new System.Drawing.Point(83, 390);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 5;
            // 
            // dTPTime
            // 
            this.dTPTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dTPTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPTime.Location = new System.Drawing.Point(107, 414);
            this.dTPTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPTime.Name = "dTPTime";
            this.dTPTime.Size = new System.Drawing.Size(160, 27);
            this.dTPTime.TabIndex = 49;
            // 
            // panelOrder
            // 
            this.panelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOrder.Controls.Add(this.btCreateOrder);
            this.panelOrder.Controls.Add(this.label7);
            this.panelOrder.Controls.Add(this.btSave);
            this.panelOrder.Controls.Add(this.btCancel);
            this.panelOrder.Controls.Add(this.btMain);
            this.panelOrder.Controls.Add(this.dTPTime);
            this.panelOrder.Controls.Add(this.panel1);
            this.panelOrder.Controls.Add(this.label6);
            this.panelOrder.Controls.Add(this.labelThanhTien);
            this.panelOrder.Controls.Add(this.label4);
            this.panelOrder.Controls.Add(this.label3);
            this.panelOrder.Controls.Add(this.label2);
            this.panelOrder.Controls.Add(this.label1);
            this.panelOrder.Controls.Add(this.tBDoiTac);
            this.panelOrder.Controls.Add(this.dGVOrders);
            this.panelOrder.Controls.Add(this.btEdit);
            this.panelOrder.Controls.Add(this.btPrint);
            this.panelOrder.Controls.Add(this.btDelete);
            this.panelOrder.Location = new System.Drawing.Point(493, 2);
            this.panelOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(497, 542);
            this.panelOrder.TabIndex = 50;
            // 
            // btCreateOrder
            // 
            this.btCreateOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCreateOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateOrder.Image = global::WarehouseManagement.Properties.Resources.ICAdd;
            this.btCreateOrder.Location = new System.Drawing.Point(69, 473);
            this.btCreateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btCreateOrder.Name = "btCreateOrder";
            this.btCreateOrder.Size = new System.Drawing.Size(59, 47);
            this.btCreateOrder.TabIndex = 55;
            this.btCreateOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCreateOrder.UseMnemonic = false;
            this.btCreateOrder.UseVisualStyleBackColor = true;
            this.btCreateOrder.Click += new System.EventHandler(this.btCreateOrder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 24);
            this.label7.TabIndex = 54;
            this.label7.Text = "Chi Tiết Hóa Đơn:";
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Image = global::WarehouseManagement.Properties.Resources.ICsave;
            this.btSave.Location = new System.Drawing.Point(136, 473);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(59, 47);
            this.btSave.TabIndex = 53;
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.UseMnemonic = false;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Image = global::WarehouseManagement.Properties.Resources.delete;
            this.btCancel.Location = new System.Drawing.Point(406, 473);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(61, 47);
            this.btCancel.TabIndex = 52;
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.UseMnemonic = false;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btMain
            // 
            this.btMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btMain.Image = global::WarehouseManagement.Properties.Resources.settings;
            this.btMain.Location = new System.Drawing.Point(11, 473);
            this.btMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMain.Name = "btMain";
            this.btMain.Size = new System.Drawing.Size(51, 47);
            this.btMain.TabIndex = 51;
            this.btMain.UseVisualStyleBackColor = true;
            this.btMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // btEdit
            // 
            this.btEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Image = global::WarehouseManagement.Properties.Resources.ICEdit;
            this.btEdit.Location = new System.Drawing.Point(270, 473);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(59, 47);
            this.btEdit.TabIndex = 12;
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEdit.UseMnemonic = false;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btPrint
            // 
            this.btPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Image = global::WarehouseManagement.Properties.Resources.ICprint;
            this.btPrint.Location = new System.Drawing.Point(203, 473);
            this.btPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(59, 47);
            this.btPrint.TabIndex = 14;
            this.btPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPrint.UseMnemonic = false;
            this.btPrint.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Image = global::WarehouseManagement.Properties.Resources.ICDel;
            this.btDelete.Location = new System.Drawing.Point(337, 473);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(61, 47);
            this.btDelete.TabIndex = 13;
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDelete.UseMnemonic = false;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // buttonTimer
            // 
            this.buttonTimer.Interval = 50;
            this.buttonTimer.Tick += new System.EventHandler(this.buttonTimer_Tick);
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
            // OderUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.GrAddOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OderUser";
            this.Size = new System.Drawing.Size(992, 546);
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

        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView dGVOrders;
        private System.Windows.Forms.GroupBox GrAddOrder;
        private System.Windows.Forms.Panel pLe;
        private System.Windows.Forms.Button btSearch;
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
        private System.Windows.Forms.Button btMain;
        private System.Windows.Forms.Timer buttonTimer;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCreateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_HANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DON_GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
    }
}