namespace WarehouseManagement
{
    partial class FormAdmin
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
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.KEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNameDataGridView = new System.Windows.Forms.Label();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonEDIT = new System.Windows.Forms.Button();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.buttonCANCEL = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdmin.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KEY,
            this.UNAME,
            this.POSITION});
            this.dataGridViewAdmin.Location = new System.Drawing.Point(180, 76);
            this.dataGridViewAdmin.MinimumSize = new System.Drawing.Size(527, 195);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.RowHeadersVisible = false;
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(527, 288);
            this.dataGridViewAdmin.TabIndex = 0;
            // 
            // KEY
            // 
            this.KEY.DataPropertyName = "UKEY";
            this.KEY.HeaderText = "Mã bản quyền";
            this.KEY.MinimumWidth = 6;
            this.KEY.Name = "KEY";
            // 
            // UNAME
            // 
            this.UNAME.DataPropertyName = "USERNAME";
            this.UNAME.HeaderText = "Tên tài khoản";
            this.UNAME.MinimumWidth = 6;
            this.UNAME.Name = "UNAME";
            // 
            // POSITION
            // 
            this.POSITION.DataPropertyName = "POSITION";
            this.POSITION.HeaderText = "Chức vụ";
            this.POSITION.MinimumWidth = 6;
            this.POSITION.Name = "POSITION";
            // 
            // labelNameDataGridView
            // 
            this.labelNameDataGridView.AutoSize = true;
            this.labelNameDataGridView.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.labelNameDataGridView.Location = new System.Drawing.Point(176, 39);
            this.labelNameDataGridView.Name = "labelNameDataGridView";
            this.labelNameDataGridView.Size = new System.Drawing.Size(438, 23);
            this.labelNameDataGridView.TabIndex = 1;
            this.labelNameDataGridView.Text = "Danh sách các tài khoản user đang được sử dụng:";
            // 
            // buttonADD
            // 
            this.buttonADD.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonADD.Location = new System.Drawing.Point(29, 169);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(107, 44);
            this.buttonADD.TabIndex = 2;
            this.buttonADD.Text = "Thêm";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonEDIT
            // 
            this.buttonEDIT.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonEDIT.Location = new System.Drawing.Point(29, 219);
            this.buttonEDIT.Name = "buttonEDIT";
            this.buttonEDIT.Size = new System.Drawing.Size(107, 44);
            this.buttonEDIT.TabIndex = 2;
            this.buttonEDIT.Text = "Sửa";
            this.buttonEDIT.UseVisualStyleBackColor = true;
            this.buttonEDIT.Click += new System.EventHandler(this.buttonEDIT_Click);
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDELETE.Location = new System.Drawing.Point(29, 320);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(107, 44);
            this.buttonDELETE.TabIndex = 2;
            this.buttonDELETE.Text = "Xóa";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // buttonCANCEL
            // 
            this.buttonCANCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCANCEL.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonCANCEL.Location = new System.Drawing.Point(605, 387);
            this.buttonCANCEL.Name = "buttonCANCEL";
            this.buttonCANCEL.Size = new System.Drawing.Size(105, 44);
            this.buttonCANCEL.TabIndex = 2;
            this.buttonCANCEL.Text = "Hủy bỏ";
            this.buttonCANCEL.UseVisualStyleBackColor = true;
            this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(29, 269);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(107, 44);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSAVE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarehouseManagement.Properties.Resources.Temp;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCANCEL);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEDIT);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.labelNameDataGridView);
            this.Controls.Add(this.dataGridViewAdmin);
            this.MinimumSize = new System.Drawing.Size(740, 489);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Label labelNameDataGridView;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonEDIT;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.Button buttonCANCEL;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSITION;
    }
}