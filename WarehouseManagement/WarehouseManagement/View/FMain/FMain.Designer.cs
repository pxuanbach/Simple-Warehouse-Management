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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNhay = new System.Windows.Forms.Panel();
            this.buttonABOUT = new System.Windows.Forms.Button();
            this.buttonACCOUNT = new System.Windows.Forms.Button();
            this.buttonSTATISTICS = new System.Windows.Forms.Button();
            this.buttonORDER = new System.Windows.Forms.Button();
            this.buttonSTOCK = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.labelCopy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StockPage = new WarehouseManagement.StockPage();
            this.AccPage = new WarehouseManagement.AccountUser();
            this.HelpUserPage = new WarehouseManagement.HelpUser();
            this.OrderPage = new WarehouseManagement.OderUser();
            this.StatisticsPage = new WarehouseManagement.StatisticsPage();
            this.UserPage = new WarehouseManagement.UserWelcome();
            this.TimeDatePage = new WarehouseManagement.TimeDate();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.buttonLogout);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Controls.Add(this.labelCopy);
            this.panelLeft.Controls.Add(this.TimeDatePage);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.panelNhay);
            this.panelLeft.Controls.Add(this.buttonABOUT);
            this.panelLeft.Controls.Add(this.buttonACCOUNT);
            this.panelLeft.Controls.Add(this.buttonSTATISTICS);
            this.panelLeft.Controls.Add(this.buttonORDER);
            this.panelLeft.Controls.Add(this.buttonSTOCK);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(192, 553);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarehouseManagement.Properties.Resources.Logo;
            this.pictureBox1.InitialImage = global::WarehouseManagement.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 90);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panelNhay
            // 
            this.panelNhay.BackColor = System.Drawing.Color.Silver;
            this.panelNhay.Location = new System.Drawing.Point(182, 103);
            this.panelNhay.Name = "panelNhay";
            this.panelNhay.Size = new System.Drawing.Size(10, 48);
            this.panelNhay.TabIndex = 6;
            // 
            // buttonABOUT
            // 
            this.buttonABOUT.BackColor = System.Drawing.Color.Gray;
            this.buttonABOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonABOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonABOUT.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonABOUT.Image = ((System.Drawing.Image)(resources.GetObject("buttonABOUT.Image")));
            this.buttonABOUT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonABOUT.Location = new System.Drawing.Point(-1, 347);
            this.buttonABOUT.Name = "buttonABOUT";
            this.buttonABOUT.Size = new System.Drawing.Size(202, 56);
            this.buttonABOUT.TabIndex = 7;
            this.buttonABOUT.Text = "    ABOUT";
            this.buttonABOUT.UseVisualStyleBackColor = false;
            this.buttonABOUT.Click += new System.EventHandler(this.buttonABOUT_Click);
            // 
            // buttonACCOUNT
            // 
            this.buttonACCOUNT.BackColor = System.Drawing.Color.Gray;
            this.buttonACCOUNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonACCOUNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonACCOUNT.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonACCOUNT.Image = global::WarehouseManagement.Properties.Resources.AccIC2;
            this.buttonACCOUNT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonACCOUNT.Location = new System.Drawing.Point(-1, 285);
            this.buttonACCOUNT.Name = "buttonACCOUNT";
            this.buttonACCOUNT.Size = new System.Drawing.Size(202, 56);
            this.buttonACCOUNT.TabIndex = 3;
            this.buttonACCOUNT.Text = "    ACCOUNT";
            this.buttonACCOUNT.UseVisualStyleBackColor = false;
            this.buttonACCOUNT.Click += new System.EventHandler(this.buttonACCOUNT_Click);
            // 
            // buttonSTATISTICS
            // 
            this.buttonSTATISTICS.BackColor = System.Drawing.Color.Gray;
            this.buttonSTATISTICS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSTATISTICS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSTATISTICS.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSTATISTICS.Image = global::WarehouseManagement.Properties.Resources.StatisticsIC;
            this.buttonSTATISTICS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSTATISTICS.Location = new System.Drawing.Point(-1, 223);
            this.buttonSTATISTICS.Name = "buttonSTATISTICS";
            this.buttonSTATISTICS.Size = new System.Drawing.Size(202, 56);
            this.buttonSTATISTICS.TabIndex = 2;
            this.buttonSTATISTICS.Text = "    STATISTICS";
            this.buttonSTATISTICS.UseVisualStyleBackColor = false;
            this.buttonSTATISTICS.Click += new System.EventHandler(this.buttonSTATISTICS_Click);
            // 
            // buttonORDER
            // 
            this.buttonORDER.BackColor = System.Drawing.Color.Gray;
            this.buttonORDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonORDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonORDER.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonORDER.Image = global::WarehouseManagement.Properties.Resources.OderIC;
            this.buttonORDER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonORDER.Location = new System.Drawing.Point(-1, 161);
            this.buttonORDER.Name = "buttonORDER";
            this.buttonORDER.Size = new System.Drawing.Size(202, 56);
            this.buttonORDER.TabIndex = 1;
            this.buttonORDER.Text = "  ORDER";
            this.buttonORDER.UseVisualStyleBackColor = false;
            this.buttonORDER.Click += new System.EventHandler(this.buttonORDER_Click);
            // 
            // buttonSTOCK
            // 
            this.buttonSTOCK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSTOCK.BackColor = System.Drawing.Color.Gray;
            this.buttonSTOCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSTOCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSTOCK.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSTOCK.Image = ((System.Drawing.Image)(resources.GetObject("buttonSTOCK.Image")));
            this.buttonSTOCK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSTOCK.Location = new System.Drawing.Point(-1, 99);
            this.buttonSTOCK.Name = "buttonSTOCK";
            this.buttonSTOCK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSTOCK.Size = new System.Drawing.Size(202, 56);
            this.buttonSTOCK.TabIndex = 0;
            this.buttonSTOCK.Text = "  STOCK";
            this.buttonSTOCK.UseVisualStyleBackColor = false;
            this.buttonSTOCK.Click += new System.EventHandler(this.buttonSTOCK_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.Controls.Add(this.StockPage);
            this.panelDisplay.Controls.Add(this.AccPage);
            this.panelDisplay.Controls.Add(this.HelpUserPage);
            this.panelDisplay.Controls.Add(this.OrderPage);
            this.panelDisplay.Controls.Add(this.StatisticsPage);
            this.panelDisplay.Controls.Add(this.UserPage);
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplay.Location = new System.Drawing.Point(192, 0);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(1002, 553);
            this.panelDisplay.TabIndex = 1;
            // 
            // labelCopy
            // 
            this.labelCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopy.Location = new System.Drawing.Point(3, 510);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(174, 40);
            this.labelCopy.TabIndex = 9;
            this.labelCopy.Text = "Copyright © 2020-2021 UIT Team, Inc\r\n";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 2);
            this.panel1.TabIndex = 10;
            // 
            // StockPage
            // 
            this.StockPage.AutoSize = true;
            this.StockPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StockPage.Location = new System.Drawing.Point(0, 0);
            this.StockPage.Margin = new System.Windows.Forms.Padding(4);
            this.StockPage.Name = "StockPage";
            this.StockPage.Size = new System.Drawing.Size(1005, 546);
            this.StockPage.TabIndex = 4;
            // 
            // AccPage
            // 
            this.AccPage.AutoSize = true;
            this.AccPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AccPage.BackColor = System.Drawing.Color.White;
            this.AccPage.Location = new System.Drawing.Point(0, 1);
            this.AccPage.Margin = new System.Windows.Forms.Padding(4);
            this.AccPage.Name = "AccPage";
            this.AccPage.Size = new System.Drawing.Size(996, 550);
            this.AccPage.TabIndex = 0;
            // 
            // HelpUserPage
            // 
            this.HelpUserPage.BackColor = System.Drawing.SystemColors.Control;
            this.HelpUserPage.Location = new System.Drawing.Point(0, 0);
            this.HelpUserPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HelpUserPage.Name = "HelpUserPage";
            this.HelpUserPage.Size = new System.Drawing.Size(992, 546);
            this.HelpUserPage.TabIndex = 1;
            // 
            // OrderPage
            // 
            this.OrderPage.BackColor = System.Drawing.Color.White;
            this.OrderPage.Location = new System.Drawing.Point(0, -1);
            this.OrderPage.Margin = new System.Windows.Forms.Padding(4);
            this.OrderPage.Name = "OrderPage";
            this.OrderPage.Size = new System.Drawing.Size(992, 546);
            this.OrderPage.TabIndex = 2;
            // 
            // StatisticsPage
            // 
            this.StatisticsPage.BackColor = System.Drawing.Color.White;
            this.StatisticsPage.Location = new System.Drawing.Point(0, 0);
            this.StatisticsPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatisticsPage.Name = "StatisticsPage";
            this.StatisticsPage.Size = new System.Drawing.Size(992, 546);
            this.StatisticsPage.TabIndex = 3;
            // 
            // UserPage
            // 
            this.UserPage.BackColor = System.Drawing.SystemColors.Control;
            this.UserPage.Location = new System.Drawing.Point(0, 0);
            this.UserPage.Margin = new System.Windows.Forms.Padding(4);
            this.UserPage.Name = "UserPage";
            this.UserPage.Size = new System.Drawing.Size(992, 546);
            this.UserPage.TabIndex = 5;
            // 
            // TimeDatePage
            // 
            this.TimeDatePage.Location = new System.Drawing.Point(-1, 442);
            this.TimeDatePage.Margin = new System.Windows.Forms.Padding(4);
            this.TimeDatePage.Name = "TimeDatePage";
            this.TimeDatePage.Size = new System.Drawing.Size(192, 60);
            this.TimeDatePage.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Image = global::WarehouseManagement.Properties.Resources.logout;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(82, 409);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(102, 35);
            this.buttonLogout.TabIndex = 11;
            this.buttonLogout.Text = "  Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 553);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelLeft);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMain";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountUser AccPage;                //Khoi tao cua cac user control
        private HelpUser HelpUserPage;              //
        private OderUser OrderPage;                 //
        private StatisticsPage StatisticsPage;      //
        private StockPage StockPage;                //
        private TimeDate TimeDatePage;              //
        private UserWelcome UserPage;               //
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonSTOCK;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Button buttonORDER;
        private System.Windows.Forms.Button buttonSTATISTICS;
        private System.Windows.Forms.Button buttonACCOUNT;
        private System.Windows.Forms.Panel panelNhay;
        private System.Windows.Forms.Button buttonABOUT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCopy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogout;
    }
}