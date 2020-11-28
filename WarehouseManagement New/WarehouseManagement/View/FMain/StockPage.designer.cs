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
            this.comboBoxSeach = new System.Windows.Forms.ComboBox();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MAHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSeach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSeach
            // 
            this.comboBoxSeach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSeach.FormattingEnabled = true;
            this.comboBoxSeach.ItemHeight = 22;
            this.comboBoxSeach.Items.AddRange(new object[] {
            "Mã hàng",
            "Tên hàng",
            "Ngày nhập"});
            this.comboBoxSeach.Location = new System.Drawing.Point(45, 363);
            this.comboBoxSeach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSeach.Name = "comboBoxSeach";
            this.comboBoxSeach.Size = new System.Drawing.Size(220, 30);
            this.comboBoxSeach.TabIndex = 11;
            this.comboBoxSeach.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tBSearch
            // 
            this.tBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tBSearch.Location = new System.Drawing.Point(272, 363);
            this.tBSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(517, 27);
            this.tBSearch.TabIndex = 2;
            this.tBSearch.TextChanged += new System.EventHandler(this.tBSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.HSD});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(996, 305);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.NSX.HeaderText = "NSX";
            this.NSX.MinimumWidth = 6;
            this.NSX.Name = "NSX";
            // 
            // HSD
            // 
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "HSD";
            this.HSD.MinimumWidth = 6;
            this.HSD.Name = "HSD";
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btCancel);
            this.panelButton.Controls.Add(this.btSave);
            this.panelButton.Controls.Add(this.btEdit);
            this.panelButton.Controls.Add(this.btDel);
            this.panelButton.Controls.Add(this.btAdd);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 416);
            this.panelButton.Margin = new System.Windows.Forms.Padding(4);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1000, 140);
            this.panelButton.TabIndex = 9;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Image = global::WarehouseManagement.Properties.Resources.ICcancel;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(731, 44);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(149, 67);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "      CANCEL";
            this.btCancel.UseMnemonic = false;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Image = global::WarehouseManagement.Properties.Resources.ICsave;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(574, 44);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(149, 67);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "    SAVE";
            this.btSave.UseMnemonic = false;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btEdit
            // 
            this.btEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Image = global::WarehouseManagement.Properties.Resources.ICEdit;
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdit.Location = new System.Drawing.Point(405, 44);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(149, 67);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "  EDIT";
            this.btEdit.UseMnemonic = false;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDel
            // 
            this.btDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDel.Image = global::WarehouseManagement.Properties.Resources.ICDel;
            this.btDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDel.Location = new System.Drawing.Point(210, 44);
            this.btDel.Margin = new System.Windows.Forms.Padding(4);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(149, 67);
            this.btDel.TabIndex = 6;
            this.btDel.Text = "     DELETE";
            this.btDel.UseMnemonic = false;
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Image = global::WarehouseManagement.Properties.Resources.ICAdd;
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.Location = new System.Drawing.Point(15, 44);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(149, 67);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "  ADD";
            this.btAdd.UseMnemonic = false;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(267, 392);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 1);
            this.panel1.TabIndex = 12;
            // 
            // buttonSeach
            // 
            this.buttonSeach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSeach.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSeach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSeach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeach.Image = global::WarehouseManagement.Properties.Resources.ICsearch;
            this.buttonSeach.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSeach.Location = new System.Drawing.Point(797, 363);
            this.buttonSeach.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSeach.Name = "buttonSeach";
            this.buttonSeach.Size = new System.Drawing.Size(124, 32);
            this.buttonSeach.TabIndex = 3;
            this.buttonSeach.Text = "  Search";
            this.buttonSeach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSeach.UseVisualStyleBackColor = false;
            this.buttonSeach.Click += new System.EventHandler(this.buttonSeach_Click);
            // 
            // StockPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxSeach);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSeach);
            this.Controls.Add(this.panelButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockPage";
            this.Size = new System.Drawing.Size(1000, 556);
            this.Load += new System.EventHandler(this.StockUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSeach;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Button buttonSeach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
    }
}
