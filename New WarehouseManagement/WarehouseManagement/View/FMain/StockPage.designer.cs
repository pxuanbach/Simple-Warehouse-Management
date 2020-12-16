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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockPage));
            this.comboBoxSeach = new System.Windows.Forms.ComboBox();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelButton = new System.Windows.Forms.Panel();
            this.BtBin = new System.Windows.Forms.Button();
            this.BtHistory = new FontAwesome.Sharp.IconButton();
            this.BtDel = new FontAwesome.Sharp.IconButton();
            this.BtEdit = new FontAwesome.Sharp.IconButton();
            this.BtAdd = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtSearch = new ePOSOne.btnProduct.Button_WOC();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MAHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_NGTHEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSeach
            // 
            this.comboBoxSeach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSeach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeach.FormattingEnabled = true;
            this.comboBoxSeach.ItemHeight = 29;
            this.comboBoxSeach.Items.AddRange(new object[] {
            "Mã Hàng",
            "Tên Hàng",
            "Ngày Nhập"});
            this.comboBoxSeach.Location = new System.Drawing.Point(52, 540);
            this.comboBoxSeach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSeach.Name = "comboBoxSeach";
            this.comboBoxSeach.Size = new System.Drawing.Size(206, 37);
            this.comboBoxSeach.TabIndex = 0;
            // 
            // tBSearch
            // 
            this.tBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tBSearch.Location = new System.Drawing.Point(269, 543);
            this.tBSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(667, 31);
            this.tBSearch.TabIndex = 1;
            this.tBSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHANG,
            this.TENHANG,
            this.DVT,
            this.SOLUONG,
            this.DONGIA,
            this.NGNHAP,
            this.NSX,
            this.HSD,
            this.MA_NGTHEM});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1121, 478);
            this.dataGridView1.TabIndex = 100;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.BtBin);
            this.panelButton.Controls.Add(this.BtHistory);
            this.panelButton.Controls.Add(this.BtDel);
            this.panelButton.Controls.Add(this.BtEdit);
            this.panelButton.Controls.Add(this.BtAdd);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 595);
            this.panelButton.Margin = new System.Windows.Forms.Padding(4);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1149, 140);
            this.panelButton.TabIndex = 9;
            // 
            // BtBin
            // 
            this.BtBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtBin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtBin.FlatAppearance.BorderSize = 0;
            this.BtBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.BtBin.Image = ((System.Drawing.Image)(resources.GetObject("BtBin.Image")));
            this.BtBin.Location = new System.Drawing.Point(722, 35);
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
            this.BtHistory.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtHistory.IconChar = FontAwesome.Sharp.IconChar.History;
            this.BtHistory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.BtHistory.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtHistory.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtHistory.Location = new System.Drawing.Point(542, 35);
            this.BtHistory.Name = "BtHistory";
            this.BtHistory.Size = new System.Drawing.Size(157, 66);
            this.BtHistory.TabIndex = 5;
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
            this.BtDel.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDel.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.BtDel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.BtDel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtDel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtDel.Location = new System.Drawing.Point(380, 35);
            this.BtDel.Name = "BtDel";
            this.BtDel.Size = new System.Drawing.Size(138, 66);
            this.BtDel.TabIndex = 4;
            this.BtDel.Text = "Xóa  ";
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
            this.BtEdit.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.BtEdit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtEdit.IconSize = 50;
            this.BtEdit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtEdit.Location = new System.Drawing.Point(219, 35);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(138, 66);
            this.BtEdit.TabIndex = 7;
            this.BtEdit.Text = "Sửa  ";
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
            this.BtAdd.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(197)))), ((int)(((byte)(158)))));
            this.BtAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtAdd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtAdd.Location = new System.Drawing.Point(54, 35);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(141, 66);
            this.BtAdd.TabIndex = 3;
            this.BtAdd.Text = "Thêm ";
            this.BtAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAdd.UseVisualStyleBackColor = false;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(265, 571);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 1);
            this.panel1.TabIndex = 12;
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
            this.BtSearch.Location = new System.Drawing.Point(939, 542);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.BtSearch.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtSearch.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtSearch.Size = new System.Drawing.Size(135, 30);
            this.BtSearch.TabIndex = 2;
            this.BtSearch.Text = "Search";
            this.BtSearch.TextColor = System.Drawing.Color.DimGray;
            this.BtSearch.UseVisualStyleBackColor = false;
            this.BtSearch.Click += new System.EventHandler(this.BtSearch_Click);
            this.BtSearch.Enter += new System.EventHandler(this.BtSearch_Enter);
            this.BtSearch.Leave += new System.EventHandler(this.BtSearch_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.BtSearch);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.comboBoxSeach);
            this.panel2.Controls.Add(this.tBSearch);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 595);
            this.panel2.TabIndex = 101;
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
            // StockPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockPage";
            this.Size = new System.Drawing.Size(1149, 735);
            this.Load += new System.EventHandler(this.StockUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSeach;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panel1;
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
    }
}
