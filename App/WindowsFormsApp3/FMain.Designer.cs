namespace WindowsFormsApp3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeDate1 = new WindowsFormsApp3.TimeDate();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.BtHelp = new System.Windows.Forms.Button();
            this.BtAcc = new System.Windows.Forms.Button();
            this.Copyright = new System.Windows.Forms.Label();
            this.BtSta = new System.Windows.Forms.Button();
            this.BtOder = new System.Windows.Forms.Button();
            this.BtStock = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelVertical = new System.Windows.Forms.Panel();
            this.welPage = new WindowsFormsApp3.UserWelcome();
            this.AccPage = new WindowsFormsApp3.AccountUser();
            this.StaPage = new WindowsFormsApp3.StatisticsUser();
            this.OrderPage = new WindowsFormsApp3.OderUser();
            this.HelpPage = new WindowsFormsApp3.HelpUser();
            this.StPage = new WindowsFormsApp3.StockUser();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.timeDate1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.PanelLeft);
            this.panel1.Controls.Add(this.BtHelp);
            this.panel1.Controls.Add(this.BtAcc);
            this.panel1.Controls.Add(this.Copyright);
            this.panel1.Controls.Add(this.BtSta);
            this.panel1.Controls.Add(this.BtOder);
            this.panel1.Controls.Add(this.BtStock);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timeDate1
            // 
            resources.ApplyResources(this.timeDate1, "timeDate1");
            this.timeDate1.Name = "timeDate1";
            this.timeDate1.Load += new System.EventHandler(this.timeDate1_Load);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.PanelLeft, "PanelLeft");
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // BtHelp
            // 
            this.BtHelp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtHelp.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtHelp, "BtHelp");
            this.BtHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtHelp.Name = "BtHelp";
            this.BtHelp.UseVisualStyleBackColor = false;
            this.BtHelp.Click += new System.EventHandler(this.BtHelp_Click);
            // 
            // BtAcc
            // 
            this.BtAcc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtAcc.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtAcc, "BtAcc");
            this.BtAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtAcc.Name = "BtAcc";
            this.BtAcc.UseVisualStyleBackColor = false;
            this.BtAcc.Click += new System.EventHandler(this.BtAcc_Click);
            // 
            // Copyright
            // 
            resources.ApplyResources(this.Copyright, "Copyright");
            this.Copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Copyright.Name = "Copyright";
            this.Copyright.Click += new System.EventHandler(this.Copyright_Click);
            // 
            // BtSta
            // 
            this.BtSta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtSta.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtSta, "BtSta");
            this.BtSta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtSta.Name = "BtSta";
            this.BtSta.UseVisualStyleBackColor = false;
            this.BtSta.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BtOder
            // 
            this.BtOder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtOder.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtOder, "BtOder");
            this.BtOder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtOder.Name = "BtOder";
            this.BtOder.UseVisualStyleBackColor = false;
            this.BtOder.Click += new System.EventHandler(this.BtOder_Click);
            // 
            // BtStock
            // 
            this.BtStock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtStock.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtStock, "BtStock");
            this.BtStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtStock.Name = "BtStock";
            this.BtStock.UseVisualStyleBackColor = false;
            this.BtStock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.PanelVertical);
            this.panel2.Controls.Add(this.welPage);
            this.panel2.Controls.Add(this.AccPage);
            this.panel2.Controls.Add(this.StaPage);
            this.panel2.Controls.Add(this.OrderPage);
            this.panel2.Controls.Add(this.HelpPage);
            this.panel2.Controls.Add(this.StPage);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PanelVertical
            // 
            this.PanelVertical.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.PanelVertical, "PanelVertical");
            this.PanelVertical.Name = "PanelVertical";
            // 
            // welPage
            // 
            this.welPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.welPage, "welPage");
            this.welPage.Name = "welPage";
            this.welPage.Load += new System.EventHandler(this.welPage_Load);
            // 
            // AccPage
            // 
            this.AccPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.AccPage, "AccPage");
            this.AccPage.Name = "AccPage";
            this.AccPage.Load += new System.EventHandler(this.AccPage_Load_1);
            // 
            // StaPage
            // 
            this.StaPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.StaPage, "StaPage");
            this.StaPage.Name = "StaPage";
            // 
            // OrderPage
            // 
            this.OrderPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.OrderPage, "OrderPage");
            this.OrderPage.Name = "OrderPage";
            // 
            // HelpPage
            // 
            this.HelpPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.HelpPage, "HelpPage");
            this.HelpPage.Name = "HelpPage";
            this.HelpPage.Load += new System.EventHandler(this.HelpPage_Load);
            // 
            // StPage
            // 
            this.StPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            resources.ApplyResources(this.StPage, "StPage");
            this.StPage.Name = "StPage";
            // 
            // FMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.TransparencyKey = System.Drawing.Color.GhostWhite;
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtSta;
        private System.Windows.Forms.Button BtOder;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Button BtHelp;
   
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Button BtAcc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private HelpUser HelpPage;
        private StatisticsUser StaPage;
        private OderUser OrderPage;
        private StockUser StPage;
        private AccountUser AccPage;
        private System.Windows.Forms.Button BtStock;
        private TimeDate timeDate1;
        private UserWelcome welPage;
        private System.Windows.Forms.Panel PanelVertical;
    }
}