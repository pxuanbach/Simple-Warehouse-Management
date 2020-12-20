
namespace WarehouseManagement
{
    partial class FHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pHistory = new System.Windows.Forms.Panel();
            this.BtPosDefine = new FontAwesome.Sharp.IconButton();
            this.CbAll = new System.Windows.Forms.CheckBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVHistory = new System.Windows.Forms.DataGridView();
            this.dTPThoiGian = new System.Windows.Forms.DateTimePicker();
            this.lbViTri = new System.Windows.Forms.Label();
            this.cMSHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHistory)).BeginInit();
            this.cMSHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHistory
            // 
            this.pHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHistory.Controls.Add(this.BtPosDefine);
            this.pHistory.Controls.Add(this.CbAll);
            this.pHistory.Controls.Add(this.iconButton2);
            this.pHistory.Controls.Add(this.iconButton1);
            this.pHistory.Controls.Add(this.label2);
            this.pHistory.Controls.Add(this.dGVHistory);
            this.pHistory.Controls.Add(this.dTPThoiGian);
            this.pHistory.Controls.Add(this.lbViTri);
            this.pHistory.Location = new System.Drawing.Point(7, 5);
            this.pHistory.Name = "pHistory";
            this.pHistory.Size = new System.Drawing.Size(931, 656);
            this.pHistory.TabIndex = 0;
            // 
            // BtPosDefine
            // 
            this.BtPosDefine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtPosDefine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtPosDefine.FlatAppearance.BorderSize = 0;
            this.BtPosDefine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPosDefine.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPosDefine.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.BtPosDefine.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtPosDefine.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtPosDefine.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtPosDefine.Location = new System.Drawing.Point(682, 117);
            this.BtPosDefine.Name = "BtPosDefine";
            this.BtPosDefine.Size = new System.Drawing.Size(240, 66);
            this.BtPosDefine.TabIndex = 107;
            this.BtPosDefine.Text = "Xem Chi Tiết ";
            this.BtPosDefine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtPosDefine.UseVisualStyleBackColor = false;
            this.BtPosDefine.Click += new System.EventHandler(this.BtPosDefine_Click);
            // 
            // CbAll
            // 
            this.CbAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CbAll.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbAll.Location = new System.Drawing.Point(208, 92);
            this.CbAll.Margin = new System.Windows.Forms.Padding(4);
            this.CbAll.Name = "CbAll";
            this.CbAll.Size = new System.Drawing.Size(30, 32);
            this.CbAll.TabIndex = 106;
            this.CbAll.UseVisualStyleBackColor = true;
            this.CbAll.CheckedChanged += new System.EventHandler(this.CbAll_CheckedChanged);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton2.Location = new System.Drawing.Point(27, 133);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(163, 39);
            this.iconButton2.TabIndex = 105;
            this.iconButton2.Text = "       Thời gian";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton1.Location = new System.Drawing.Point(27, 88);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(163, 39);
            this.iconButton1.TabIndex = 104;
            this.iconButton1.Text = "  Tất cả";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(394, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 102;
            this.label2.Text = "Lịch Sử";
            // 
            // dGVHistory
            // 
            this.dGVHistory.AllowUserToAddRows = false;
            this.dGVHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHistory.ContextMenuStrip = this.cMSHistory;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVHistory.Location = new System.Drawing.Point(4, 190);
            this.dGVHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dGVHistory.Name = "dGVHistory";
            this.dGVHistory.RowHeadersVisible = false;
            this.dGVHistory.RowHeadersWidth = 51;
            this.dGVHistory.Size = new System.Drawing.Size(918, 462);
            this.dGVHistory.TabIndex = 101;
            // 
            // dTPThoiGian
            // 
            this.dTPThoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dTPThoiGian.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPThoiGian.Location = new System.Drawing.Point(208, 137);
            this.dTPThoiGian.Name = "dTPThoiGian";
            this.dTPThoiGian.Size = new System.Drawing.Size(352, 30);
            this.dTPThoiGian.TabIndex = 1;
            this.dTPThoiGian.ValueChanged += new System.EventHandler(this.dTPThoiGian_ValueChanged);
            // 
            // lbViTri
            // 
            this.lbViTri.AutoSize = true;
            this.lbViTri.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbViTri.Location = new System.Drawing.Point(22, 56);
            this.lbViTri.Name = "lbViTri";
            this.lbViTri.Size = new System.Drawing.Size(67, 29);
            this.lbViTri.TabIndex = 0;
            this.lbViTri.Text = "User";
            // 
            // cMSHistory
            // 
            this.cMSHistory.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMSHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtToolStripMenuItem});
            this.cMSHistory.Name = "contextMenuStrip1";
            this.cMSHistory.Size = new System.Drawing.Size(215, 58);
            // 
            // chiTiếtToolStripMenuItem
            // 
            this.chiTiếtToolStripMenuItem.Image = global::WarehouseManagement.Properties.Resources.send;
            this.chiTiếtToolStripMenuItem.Name = "chiTiếtToolStripMenuItem";
            this.chiTiếtToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.chiTiếtToolStripMenuItem.Text = "Chi Tiết";
            this.chiTiếtToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtToolStripMenuItem_Click);
            // 
            // FHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(942, 673);
            this.Controls.Add(this.pHistory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "FHistory";
            this.Text = "History";
            this.Load += new System.EventHandler(this.FHistory_Load);
            this.pHistory.ResumeLayout(false);
            this.pHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHistory)).EndInit();
            this.cMSHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHistory;
        private System.Windows.Forms.Label lbViTri;
        private System.Windows.Forms.DateTimePicker dTPThoiGian;
        private System.Windows.Forms.DataGridView dGVHistory;
        private System.Windows.Forms.CheckBox CbAll;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BtPosDefine;
        private System.Windows.Forms.ContextMenuStrip cMSHistory;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtToolStripMenuItem;
    }
}