namespace WindowsFormsApp3
{
    partial class StatisticsUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GbRevenue = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GbChart = new System.Windows.Forms.GroupBox();
            this.TabChart = new System.Windows.Forms.TabControl();
            this.ChartMonth = new System.Windows.Forms.TabPage();
            this.ChartYear = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.GbChart.SuspendLayout();
            this.TabChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statistics  Analysis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(247, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 44);
            this.panel1.TabIndex = 1;
            // 
            // GbRevenue
            // 
            this.GbRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbRevenue.Location = new System.Drawing.Point(429, 105);
            this.GbRevenue.Name = "GbRevenue";
            this.GbRevenue.Size = new System.Drawing.Size(279, 321);
            this.GbRevenue.TabIndex = 2;
            this.GbRevenue.TabStop = false;
            this.GbRevenue.Text = "Revenue(DoanhThu)";
            // 
            // GbChart
            // 
            this.GbChart.Controls.Add(this.TabChart);
            this.GbChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbChart.Location = new System.Drawing.Point(43, 105);
            this.GbChart.Name = "GbChart";
            this.GbChart.Size = new System.Drawing.Size(337, 321);
            this.GbChart.TabIndex = 3;
            this.GbChart.TabStop = false;
            this.GbChart.Text = "Chart(BieuDo)";
            // 
            // TabChart
            // 
            this.TabChart.Controls.Add(this.ChartMonth);
            this.TabChart.Controls.Add(this.ChartYear);
            this.TabChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabChart.Location = new System.Drawing.Point(6, 19);
            this.TabChart.Name = "TabChart";
            this.TabChart.SelectedIndex = 0;
            this.TabChart.Size = new System.Drawing.Size(325, 296);
            this.TabChart.TabIndex = 0;
            // 
            // ChartMonth
            // 
            this.ChartMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartMonth.Location = new System.Drawing.Point(4, 22);
            this.ChartMonth.Name = "ChartMonth";
            this.ChartMonth.Padding = new System.Windows.Forms.Padding(3);
            this.ChartMonth.Size = new System.Drawing.Size(317, 270);
            this.ChartMonth.TabIndex = 0;
            this.ChartMonth.Text = "Month";
            this.ChartMonth.UseVisualStyleBackColor = true;
            // 
            // ChartYear
            // 
            this.ChartYear.Location = new System.Drawing.Point(4, 22);
            this.ChartYear.Name = "ChartYear";
            this.ChartYear.Padding = new System.Windows.Forms.Padding(3);
            this.ChartYear.Size = new System.Drawing.Size(317, 270);
            this.ChartYear.TabIndex = 1;
            this.ChartYear.Text = "Year";
            this.ChartYear.UseVisualStyleBackColor = true;
            // 
            // StatisticsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GbChart);
            this.Controls.Add(this.GbRevenue);
            this.Controls.Add(this.panel1);
            this.Name = "StatisticsUser";
            this.Size = new System.Drawing.Size(744, 444);
            this.Load += new System.EventHandler(this.StatisticsUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GbChart.ResumeLayout(false);
            this.TabChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GbRevenue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox GbChart;
        private System.Windows.Forms.TabControl TabChart;
        private System.Windows.Forms.TabPage ChartMonth;
        private System.Windows.Forms.TabPage ChartYear;
    }
}
