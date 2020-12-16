namespace WarehouseManagement
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.panelL = new System.Windows.Forms.Panel();
            this.BtAdmin = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtAbout = new FontAwesome.Sharp.IconButton();
            this.BtAcc = new FontAwesome.Sharp.IconButton();
            this.BtSta = new FontAwesome.Sharp.IconButton();
            this.BtOder = new FontAwesome.Sharp.IconButton();
            this.BtStock = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Copyright = new System.Windows.Forms.Label();
            this.timeDate1 = new WarehouseManagement.TimeDate();
            this.BtLogout = new System.Windows.Forms.Button();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.TimeDatePage = new WarehouseManagement.TimeDate();
            this.panelL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelL
            // 
            this.panelL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.panelL.Controls.Add(this.BtAdmin);
            this.panelL.Controls.Add(this.pictureBox1);
            this.panelL.Controls.Add(this.BtAbout);
            this.panelL.Controls.Add(this.BtAcc);
            this.panelL.Controls.Add(this.BtSta);
            this.panelL.Controls.Add(this.BtOder);
            this.panelL.Controls.Add(this.BtStock);
            this.panelL.Controls.Add(this.panel7);
            this.panelL.Controls.Add(this.Copyright);
            this.panelL.Controls.Add(this.timeDate1);
            this.panelL.Controls.Add(this.BtLogout);
            this.panelL.Controls.Add(this.PanelLeft);
            this.panelL.Location = new System.Drawing.Point(3, 2);
            this.panelL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelL.Name = "panelL";
            this.panelL.Size = new System.Drawing.Size(209, 718);
            this.panelL.TabIndex = 0;
            this.panelL.Paint += new System.Windows.Forms.PaintEventHandler(this.panelL_Paint);
            // 
            // BtAdmin
            // 
            this.BtAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.BtAdmin.FlatAppearance.BorderSize = 0;
            this.BtAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAdmin.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.BtAdmin.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.BtAdmin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.BtAdmin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtAdmin.IconSize = 33;
            this.BtAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtAdmin.Location = new System.Drawing.Point(-3, 423);
            this.BtAdmin.Name = "BtAdmin";
            this.BtAdmin.Size = new System.Drawing.Size(197, 49);
            this.BtAdmin.TabIndex = 34;
            this.BtAdmin.Text = "      Quản Trị";
            this.BtAdmin.UseVisualStyleBackColor = false;
            this.BtAdmin.Click += new System.EventHandler(this.BtAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarehouseManagement.Properties.Resources.Temp;
            this.pictureBox1.Location = new System.Drawing.Point(23, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // BtAbout
            // 
            this.BtAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.BtAbout.FlatAppearance.BorderSize = 0;
            this.BtAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAbout.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.BtAbout.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.BtAbout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.BtAbout.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtAbout.IconSize = 33;
            this.BtAbout.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtAbout.Location = new System.Drawing.Point(1, 368);
            this.BtAbout.Name = "BtAbout";
            this.BtAbout.Size = new System.Drawing.Size(194, 49);
            this.BtAbout.TabIndex = 33;
            this.BtAbout.Text = "     Chi tiết";
            this.BtAbout.UseVisualStyleBackColor = false;
            this.BtAbout.Click += new System.EventHandler(this.BtAbout_Click);
            // 
            // BtAcc
            // 
            this.BtAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.BtAcc.FlatAppearance.BorderSize = 0;
            this.BtAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAcc.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.BtAcc.IconChar = FontAwesome.Sharp.IconChar.User;
            this.BtAcc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.BtAcc.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtAcc.IconSize = 33;
            this.BtAcc.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtAcc.Location = new System.Drawing.Point(1, 315);
            this.BtAcc.Name = "BtAcc";
            this.BtAcc.Size = new System.Drawing.Size(194, 49);
            this.BtAcc.TabIndex = 32;
            this.BtAcc.Text = "      Tài khoản";
            this.BtAcc.UseVisualStyleBackColor = false;
            this.BtAcc.Click += new System.EventHandler(this.BtAcc_Click);
            // 
            // BtSta
            // 
            this.BtSta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.BtSta.FlatAppearance.BorderSize = 0;
            this.BtSta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSta.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.BtSta.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.BtSta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.BtSta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtSta.IconSize = 40;
            this.BtSta.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtSta.Location = new System.Drawing.Point(1, 262);
            this.BtSta.Name = "BtSta";
            this.BtSta.Size = new System.Drawing.Size(194, 49);
            this.BtSta.TabIndex = 31;
            this.BtSta.Text = "      Thống Kê";
            this.BtSta.UseVisualStyleBackColor = false;
            this.BtSta.Click += new System.EventHandler(this.BtSta_Click);
            // 
            // BtOder
            // 
            this.BtOder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.BtOder.FlatAppearance.BorderSize = 0;
            this.BtOder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtOder.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtOder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.BtOder.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.BtOder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.BtOder.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtOder.IconSize = 40;
            this.BtOder.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtOder.Location = new System.Drawing.Point(1, 209);
            this.BtOder.Name = "BtOder";
            this.BtOder.Size = new System.Drawing.Size(194, 49);
            this.BtOder.TabIndex = 30;
            this.BtOder.Text = "      Đơn Hàng";
            this.BtOder.UseVisualStyleBackColor = false;
            this.BtOder.Click += new System.EventHandler(this.BtOrder_Click);
            // 
            // BtStock
            // 
            this.BtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.BtStock.FlatAppearance.BorderSize = 0;
            this.BtStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtStock.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.BtStock.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.BtStock.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.BtStock.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtStock.IconSize = 40;
            this.BtStock.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtStock.Location = new System.Drawing.Point(1, 156);
            this.BtStock.Name = "BtStock";
            this.BtStock.Size = new System.Drawing.Size(193, 49);
            this.BtStock.TabIndex = 29;
            this.BtStock.Text = "       Kho Hàng";
            this.BtStock.UseVisualStyleBackColor = false;
            this.BtStock.Click += new System.EventHandler(this.BtStock_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(1, 672);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(208, 2);
            this.panel7.TabIndex = 22;
            // 
            // Copyright
            // 
            this.Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Copyright.AutoSize = true;
            this.Copyright.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Copyright.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Copyright.Location = new System.Drawing.Point(8, 679);
            this.Copyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(185, 34);
            this.Copyright.TabIndex = 21;
            this.Copyright.Text = "Copyright © 2020-2021 UIT \r\nTeam,Inc ";
            // 
            // timeDate1
            // 
            this.timeDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeDate1.Location = new System.Drawing.Point(1, 609);
            this.timeDate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeDate1.Name = "timeDate1";
            this.timeDate1.Size = new System.Drawing.Size(195, 74);
            this.timeDate1.TabIndex = 20;
            // 
            // BtLogout
            // 
            this.BtLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtLogout.FlatAppearance.BorderSize = 0;
            this.BtLogout.Font = new System.Drawing.Font("Tahoma", 9.2F, System.Drawing.FontStyle.Bold);
            this.BtLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtLogout.Image = global::WarehouseManagement.Properties.Resources.IClogout;
            this.BtLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtLogout.Location = new System.Drawing.Point(8, 506);
            this.BtLogout.Margin = new System.Windows.Forms.Padding(4);
            this.BtLogout.Name = "BtLogout";
            this.BtLogout.Size = new System.Drawing.Size(137, 30);
            this.BtLogout.TabIndex = 36;
            this.BtLogout.Text = "   Đăng xuất";
            this.BtLogout.UseVisualStyleBackColor = false;
            this.BtLogout.Click += new System.EventHandler(this.BtLogout_Click);
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(78)))));
            this.PanelLeft.Location = new System.Drawing.Point(190, -2);
            this.PanelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(10, 104);
            this.PanelLeft.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 725);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1353, 2);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1353, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 723);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 723);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1350, 2);
            this.panel4.TabIndex = 4;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelMain.Location = new System.Drawing.Point(204, 2);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1149, 721);
            this.panelMain.TabIndex = 5;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // TimeDatePage
            // 
            this.TimeDatePage.Location = new System.Drawing.Point(0, 0);
            this.TimeDatePage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeDatePage.Name = "TimeDatePage";
            this.TimeDatePage.Size = new System.Drawing.Size(260, 74);
            this.TimeDatePage.TabIndex = 0;
            // 
            // FMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1356, 725);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1231, 598);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FMain";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panelL.ResumeLayout(false);
            this.panelL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TimeDate TimeDatePage;              //
        private System.Windows.Forms.Panel panelL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button BtLogout;
        private TimeDate timeDate1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Copyright;
        private FontAwesome.Sharp.IconButton BtAbout;
        private FontAwesome.Sharp.IconButton BtAcc;
        private FontAwesome.Sharp.IconButton BtSta;
        private FontAwesome.Sharp.IconButton BtOder;
        private FontAwesome.Sharp.IconButton BtStock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtAdmin;
    }
}