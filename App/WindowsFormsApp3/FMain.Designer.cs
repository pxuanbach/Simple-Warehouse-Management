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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Stock = new System.Windows.Forms.Button();
            this.BtOder = new System.Windows.Forms.Button();
            this.BtStatistics = new System.Windows.Forms.Button();
            this.Copyright = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtAcc = new System.Windows.Forms.Button();
            this.BtHelp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.BtHelp);
            this.panel1.Controls.Add(this.BtAcc);
            this.panel1.Controls.Add(this.Copyright);
            this.panel1.Controls.Add(this.BtStatistics);
            this.panel1.Controls.Add(this.BtOder);
            this.panel1.Controls.Add(this.Stock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 351);
            this.panel1.TabIndex = 2;
            // 
            // Stock
            // 
            this.Stock.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.Location = new System.Drawing.Point(-2, 54);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(153, 49);
            this.Stock.TabIndex = 0;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
            this.Stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // BtOder
            // 
            this.BtOder.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtOder.Location = new System.Drawing.Point(-2, 101);
            this.BtOder.Name = "BtOder";
            this.BtOder.Size = new System.Drawing.Size(153, 54);
            this.BtOder.TabIndex = 4;
            this.BtOder.Text = "Oder";
            this.BtOder.UseVisualStyleBackColor = true;
            // 
            // BtStatistics
            // 
            this.BtStatistics.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtStatistics.Location = new System.Drawing.Point(-2, 153);
            this.BtStatistics.Name = "BtStatistics";
            this.BtStatistics.Size = new System.Drawing.Size(153, 52);
            this.BtStatistics.TabIndex = 5;
            this.BtStatistics.Text = "Statistics";
            this.BtStatistics.UseVisualStyleBackColor = true;
            this.BtStatistics.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Location = new System.Drawing.Point(4, 311);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(141, 26);
            this.Copyright.TabIndex = 6;
            this.Copyright.Text = "Copyright © 2020-2021 UIT \r\nTeam,Inc ";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 351);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtAcc
            // 
            this.BtAcc.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAcc.Location = new System.Drawing.Point(-2, 203);
            this.BtAcc.Name = "BtAcc";
            this.BtAcc.Size = new System.Drawing.Size(153, 52);
            this.BtAcc.TabIndex = 7;
            this.BtAcc.Text = "Account";
            this.BtAcc.UseVisualStyleBackColor = true;
            // 
            // BtHelp
            // 
            this.BtHelp.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtHelp.Location = new System.Drawing.Point(-2, 253);
            this.BtHelp.Name = "BtHelp";
            this.BtHelp.Size = new System.Drawing.Size(153, 52);
            this.BtHelp.TabIndex = 8;
            this.BtHelp.Text = "Help";
            this.BtHelp.UseVisualStyleBackColor = true;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 351);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FMain";
            this.Text = "Stock Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Button BtStatistics;
        private System.Windows.Forms.Button BtOder;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtHelp;
        private System.Windows.Forms.Button BtAcc;
    }
}