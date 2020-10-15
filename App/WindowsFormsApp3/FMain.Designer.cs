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
            this.rHelp = new System.Windows.Forms.Panel();
            this.rAcc = new System.Windows.Forms.Panel();
            this.rStatistics = new System.Windows.Forms.Panel();
            this.rOder = new System.Windows.Forms.Panel();
            this.rStock = new System.Windows.Forms.Panel();
            this.Copyright = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtHelp = new System.Windows.Forms.Button();
            this.BtAcc = new System.Windows.Forms.Button();
            this.BtStatistics = new System.Windows.Forms.Button();
            this.BtOder = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Button();
            this.StockUser = new WindowsFormsApp3.StockForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.rHelp);
            this.panel1.Controls.Add(this.rAcc);
            this.panel1.Controls.Add(this.rStatistics);
            this.panel1.Controls.Add(this.rOder);
            this.panel1.Controls.Add(this.rStock);
            this.panel1.Controls.Add(this.BtHelp);
            this.panel1.Controls.Add(this.BtAcc);
            this.panel1.Controls.Add(this.Copyright);
            this.panel1.Controls.Add(this.BtStatistics);
            this.panel1.Controls.Add(this.BtOder);
            this.panel1.Controls.Add(this.Stock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 451);
            this.panel1.TabIndex = 2;
            // 
            // rHelp
            // 
            this.rHelp.BackColor = System.Drawing.Color.Goldenrod;
            this.rHelp.Location = new System.Drawing.Point(-9, 253);
            this.rHelp.Name = "rHelp";
            this.rHelp.Size = new System.Drawing.Size(12, 52);
            this.rHelp.TabIndex = 6;
            // 
            // rAcc
            // 
            this.rAcc.BackColor = System.Drawing.Color.Goldenrod;
            this.rAcc.Location = new System.Drawing.Point(-9, 204);
            this.rAcc.Name = "rAcc";
            this.rAcc.Size = new System.Drawing.Size(12, 52);
            this.rAcc.TabIndex = 5;
            // 
            // rStatistics
            // 
            this.rStatistics.BackColor = System.Drawing.Color.Goldenrod;
            this.rStatistics.Location = new System.Drawing.Point(-9, 153);
            this.rStatistics.Name = "rStatistics";
            this.rStatistics.Size = new System.Drawing.Size(12, 52);
            this.rStatistics.TabIndex = 4;
            // 
            // rOder
            // 
            this.rOder.BackColor = System.Drawing.Color.Goldenrod;
            this.rOder.Location = new System.Drawing.Point(-9, 101);
            this.rOder.Name = "rOder";
            this.rOder.Size = new System.Drawing.Size(12, 54);
            this.rOder.TabIndex = 2;
            // 
            // rStock
            // 
            this.rStock.BackColor = System.Drawing.Color.Goldenrod;
            this.rStock.Location = new System.Drawing.Point(-9, 54);
            this.rStock.Name = "rStock";
            this.rStock.Size = new System.Drawing.Size(12, 49);
            this.rStock.TabIndex = 1;
            this.rStock.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Copyright.Location = new System.Drawing.Point(3, 366);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(141, 26);
            this.Copyright.TabIndex = 6;
            this.Copyright.Text = "Copyright © 2020-2021 UIT \r\nTeam,Inc ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.StockUser);
            this.panel2.Location = new System.Drawing.Point(153, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 444);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(0, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 2);
            this.panel3.TabIndex = 4;
            // 
            // BtHelp
            // 
            this.BtHelp.FlatAppearance.BorderSize = 0;
            this.BtHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtHelp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtHelp.Image = ((System.Drawing.Image)(resources.GetObject("BtHelp.Image")));
            this.BtHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtHelp.Location = new System.Drawing.Point(-2, 253);
            this.BtHelp.Name = "BtHelp";
            this.BtHelp.Size = new System.Drawing.Size(153, 52);
            this.BtHelp.TabIndex = 8;
            this.BtHelp.Text = "Help";
            this.BtHelp.UseVisualStyleBackColor = true;
            // 
            // BtAcc
            // 
            this.BtAcc.FlatAppearance.BorderSize = 0;
            this.BtAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAcc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtAcc.Image = ((System.Drawing.Image)(resources.GetObject("BtAcc.Image")));
            this.BtAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAcc.Location = new System.Drawing.Point(-2, 203);
            this.BtAcc.Name = "BtAcc";
            this.BtAcc.Size = new System.Drawing.Size(153, 52);
            this.BtAcc.TabIndex = 7;
            this.BtAcc.Text = "   Account";
            this.BtAcc.UseVisualStyleBackColor = true;
            // 
            // BtStatistics
            // 
            this.BtStatistics.FlatAppearance.BorderSize = 0;
            this.BtStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtStatistics.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtStatistics.Image = ((System.Drawing.Image)(resources.GetObject("BtStatistics.Image")));
            this.BtStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtStatistics.Location = new System.Drawing.Point(-2, 153);
            this.BtStatistics.Name = "BtStatistics";
            this.BtStatistics.Size = new System.Drawing.Size(153, 52);
            this.BtStatistics.TabIndex = 5;
            this.BtStatistics.Text = "   Statistics";
            this.BtStatistics.UseVisualStyleBackColor = true;
            this.BtStatistics.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BtOder
            // 
            this.BtOder.FlatAppearance.BorderSize = 0;
            this.BtOder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtOder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtOder.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtOder.Image = ((System.Drawing.Image)(resources.GetObject("BtOder.Image")));
            this.BtOder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtOder.Location = new System.Drawing.Point(-2, 101);
            this.BtOder.Name = "BtOder";
            this.BtOder.Size = new System.Drawing.Size(153, 54);
            this.BtOder.TabIndex = 4;
            this.BtOder.Text = "Order";
            this.BtOder.UseVisualStyleBackColor = true;
            this.BtOder.Click += new System.EventHandler(this.BtOder_Click);
            // 
            // Stock
            // 
            this.Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Stock.FlatAppearance.BorderSize = 0;
            this.Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Stock.Image = ((System.Drawing.Image)(resources.GetObject("Stock.Image")));
            this.Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Stock.Location = new System.Drawing.Point(-2, 54);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(153, 49);
            this.Stock.TabIndex = 0;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = false;
            this.Stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // StockUser
            // 
            this.StockUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StockUser.Location = new System.Drawing.Point(1, 0);
            this.StockUser.Name = "StockUser";
            this.StockUser.Size = new System.Drawing.Size(744, 444);
            this.StockUser.TabIndex = 0;
            this.StockUser.Load += new System.EventHandler(this.stockForm1_Load_1);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(903, 451);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FMain";
            this.Text = "Stock Manager";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Button BtStatistics;
        private System.Windows.Forms.Button BtOder;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Button BtHelp;
        private System.Windows.Forms.Panel panel2;
        private StockForm StockUser;
        private System.Windows.Forms.Panel rStock;
        private System.Windows.Forms.Panel rHelp;
        private System.Windows.Forms.Panel rAcc;
        private System.Windows.Forms.Panel rStatistics;
        private System.Windows.Forms.Panel rOder;
        private System.Windows.Forms.Button BtAcc;
        private System.Windows.Forms.Panel panel3;
    }
}