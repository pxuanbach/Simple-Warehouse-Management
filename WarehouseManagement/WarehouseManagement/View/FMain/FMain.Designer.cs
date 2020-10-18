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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Copyright = new System.Windows.Forms.Label();
            this.timeDate1 = new WarehouseManagement.TimeDate();
            this.BtLogout = new System.Windows.Forms.Button();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.BtAbout = new System.Windows.Forms.Button();
            this.BtAcc = new System.Windows.Forms.Button();
            this.BtStock = new System.Windows.Forms.Button();
            this.BtSta = new System.Windows.Forms.Button();
            this.BtOder = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.welPage = new WarehouseManagement.UserWelcome();
            this.StPage = new WarehouseManagement.StockPage();
            this.StaPage = new WarehouseManagement.StatisticsPage();
            this.OrderPage = new WarehouseManagement.OderUser();
            this.HelpPage = new WarehouseManagement.HelpUser();
            this.AccPage = new WarehouseManagement.AccountUser();
            this.TimeDatePage = new WarehouseManagement.TimeDate();
            this.panelL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelL
            // 
            this.panelL.BackColor = System.Drawing.Color.White;
            this.panelL.Controls.Add(this.pictureBox1);
            this.panelL.Controls.Add(this.panel7);
            this.panelL.Controls.Add(this.Copyright);
            this.panelL.Controls.Add(this.timeDate1);
            this.panelL.Controls.Add(this.BtLogout);
            this.panelL.Controls.Add(this.PanelLeft);
            this.panelL.Controls.Add(this.BtAbout);
            this.panelL.Controls.Add(this.BtAcc);
            this.panelL.Controls.Add(this.BtStock);
            this.panelL.Controls.Add(this.BtSta);
            this.panelL.Controls.Add(this.BtOder);
            this.panelL.Location = new System.Drawing.Point(2, 2);
            this.panelL.Margin = new System.Windows.Forms.Padding(2);
            this.panelL.Name = "panelL";
            this.panelL.Size = new System.Drawing.Size(157, 442);
            this.panelL.TabIndex = 0;
            this.panelL.Paint += new System.Windows.Forms.PaintEventHandler(this.panelL_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarehouseManagement.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 62);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(1, 405);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(156, 2);
            this.panel7.TabIndex = 22;
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Copyright.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Copyright.Location = new System.Drawing.Point(6, 410);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(141, 26);
            this.Copyright.TabIndex = 21;
            this.Copyright.Text = "Copyright © 2020-2021 UIT \r\nTeam,Inc ";
            // 
            // timeDate1
            // 
            this.timeDate1.Location = new System.Drawing.Point(1, 347);
            this.timeDate1.Name = "timeDate1";
            this.timeDate1.Size = new System.Drawing.Size(153, 60);
            this.timeDate1.TabIndex = 20;
            // 
            // BtLogout
            // 
            this.BtLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtLogout.FlatAppearance.BorderSize = 0;
            this.BtLogout.Font = new System.Drawing.Font("Arial", 8.5F);
            this.BtLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtLogout.Location = new System.Drawing.Point(9, 289);
            this.BtLogout.Name = "BtLogout";
            this.BtLogout.Size = new System.Drawing.Size(94, 26);
            this.BtLogout.TabIndex = 19;
            this.BtLogout.Text = "Logout";
            this.BtLogout.UseVisualStyleBackColor = false;
            this.BtLogout.Click += new System.EventHandler(this.BtLogout_Click);
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(102)))));
            this.PanelLeft.Location = new System.Drawing.Point(148, 77);
            this.PanelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(10, 34);
            this.PanelLeft.TabIndex = 6;
            this.PanelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNhay_Paint);
            // 
            // BtAbout
            // 
            this.BtAbout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtAbout.FlatAppearance.BorderSize = 0;
            this.BtAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAbout.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.BtAbout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtAbout.Image = global::WarehouseManagement.Properties.Resources.HelpIIC;
            this.BtAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAbout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtAbout.Location = new System.Drawing.Point(3, 238);
            this.BtAbout.Name = "BtAbout";
            this.BtAbout.Size = new System.Drawing.Size(153, 33);
            this.BtAbout.TabIndex = 17;
            this.BtAbout.Text = "About";
            this.BtAbout.UseVisualStyleBackColor = false;
            this.BtAbout.Click += new System.EventHandler(this.BtHelp_Click);
            // 
            // BtAcc
            // 
            this.BtAcc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtAcc.FlatAppearance.BorderSize = 0;
            this.BtAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAcc.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.BtAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtAcc.Image = global::WarehouseManagement.Properties.Resources.UserIC3;
            this.BtAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAcc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtAcc.Location = new System.Drawing.Point(3, 199);
            this.BtAcc.Name = "BtAcc";
            this.BtAcc.Size = new System.Drawing.Size(153, 33);
            this.BtAcc.TabIndex = 16;
            this.BtAcc.Text = "   Account";
            this.BtAcc.UseVisualStyleBackColor = false;
            this.BtAcc.Click += new System.EventHandler(this.BtAcc_Click);
            // 
            // BtStock
            // 
            this.BtStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtStock.FlatAppearance.BorderSize = 0;
            this.BtStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtStock.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.BtStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtStock.Image = ((System.Drawing.Image)(resources.GetObject("BtStock.Image")));
            this.BtStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtStock.Location = new System.Drawing.Point(3, 77);
            this.BtStock.Name = "BtStock";
            this.BtStock.Size = new System.Drawing.Size(153, 33);
            this.BtStock.TabIndex = 13;
            this.BtStock.Text = "Stock";
            this.BtStock.UseVisualStyleBackColor = false;
            this.BtStock.Click += new System.EventHandler(this.BtStock_Click);
            // 
            // BtSta
            // 
            this.BtSta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtSta.FlatAppearance.BorderSize = 0;
            this.BtSta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtSta.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.BtSta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtSta.Image = ((System.Drawing.Image)(resources.GetObject("BtSta.Image")));
            this.BtSta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtSta.Location = new System.Drawing.Point(3, 155);
            this.BtSta.Name = "BtSta";
            this.BtSta.Size = new System.Drawing.Size(153, 33);
            this.BtSta.TabIndex = 15;
            this.BtSta.Text = "   Statistics";
            this.BtSta.UseVisualStyleBackColor = false;
            this.BtSta.Click += new System.EventHandler(this.BtSta_Click);
            // 
            // BtOder
            // 
            this.BtOder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtOder.FlatAppearance.BorderSize = 0;
            this.BtOder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtOder.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.BtOder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtOder.Image = ((System.Drawing.Image)(resources.GetObject("BtOder.Image")));
            this.BtOder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtOder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtOder.Location = new System.Drawing.Point(3, 116);
            this.BtOder.Name = "BtOder";
            this.BtOder.Size = new System.Drawing.Size(153, 33);
            this.BtOder.TabIndex = 14;
            this.BtOder.Text = "Order";
            this.BtOder.UseVisualStyleBackColor = false;
            this.BtOder.Click += new System.EventHandler(this.BtOder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 448);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 2);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(908, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 446);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(2, 446);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(906, 2);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.welPage);
            this.panel5.Controls.Add(this.StPage);
            this.panel5.Controls.Add(this.StaPage);
            this.panel5.Controls.Add(this.OrderPage);
            this.panel5.Controls.Add(this.HelpPage);
            this.panel5.Controls.Add(this.AccPage);
            this.panel5.Location = new System.Drawing.Point(164, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(744, 444);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 740);
            this.panel6.TabIndex = 6;
            // 
            // welPage
            // 
            this.welPage.BackColor = System.Drawing.SystemColors.Control;
            this.welPage.Location = new System.Drawing.Point(0, 0);
            this.welPage.Name = "welPage";
            this.welPage.Size = new System.Drawing.Size(744, 444);
            this.welPage.TabIndex = 5;
            // 
            // StPage
            // 
            this.StPage.AutoSize = true;
            this.StPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StPage.Location = new System.Drawing.Point(0, 0);
            this.StPage.Name = "StPage";
            this.StPage.Size = new System.Drawing.Size(750, 444);
            this.StPage.TabIndex = 4;
            // 
            // StaPage
            // 
            this.StaPage.BackColor = System.Drawing.Color.White;
            this.StaPage.Location = new System.Drawing.Point(0, 0);
            this.StaPage.Name = "StaPage";
            this.StaPage.Size = new System.Drawing.Size(744, 444);
            this.StaPage.TabIndex = 3;
            // 
            // OrderPage
            // 
            this.OrderPage.BackColor = System.Drawing.Color.White;
            this.OrderPage.Location = new System.Drawing.Point(0, 0);
            this.OrderPage.Name = "OrderPage";
            this.OrderPage.Size = new System.Drawing.Size(744, 444);
            this.OrderPage.TabIndex = 2;
            // 
            // HelpPage
            // 
            this.HelpPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HelpPage.Location = new System.Drawing.Point(0, 0);
            this.HelpPage.Name = "HelpPage";
            this.HelpPage.Size = new System.Drawing.Size(744, 444);
            this.HelpPage.TabIndex = 1;
            // 
            // AccPage
            // 
            this.AccPage.BackColor = System.Drawing.Color.Goldenrod;
            this.AccPage.Location = new System.Drawing.Point(0, 0);
            this.AccPage.Name = "AccPage";
            this.AccPage.Size = new System.Drawing.Size(744, 444);
            this.AccPage.TabIndex = 0;
            // 
            // TimeDatePage
            // 
            this.TimeDatePage.Location = new System.Drawing.Point(0, 0);
            this.TimeDatePage.Margin = new System.Windows.Forms.Padding(4);
            this.TimeDatePage.Name = "TimeDatePage";
            this.TimeDatePage.Size = new System.Drawing.Size(260, 74);
            this.TimeDatePage.TabIndex = 0;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 448);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMain";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panelL.ResumeLayout(false);
            this.panelL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TimeDate TimeDatePage;              //
        private System.Windows.Forms.Panel panelL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Button BtAbout;
        private System.Windows.Forms.Button BtAcc;
        private System.Windows.Forms.Button BtStock;
        private System.Windows.Forms.Button BtSta;
        private System.Windows.Forms.Button BtOder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private UserWelcome welPage;
        private StockPage StPage;
        private StatisticsPage StaPage;
        private OderUser OrderPage;
        private HelpUser HelpPage;
        private AccountUser AccPage;
        private System.Windows.Forms.Button BtLogout;
        private TimeDate timeDate1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}