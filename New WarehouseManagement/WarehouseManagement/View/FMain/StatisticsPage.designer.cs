namespace WarehouseManagement
{
    partial class StatisticsPage
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
            this.GbRevenue = new System.Windows.Forms.GroupBox();
            this.GbChart = new System.Windows.Forms.GroupBox();
            this.TabChart = new System.Windows.Forms.TabControl();
            this.ChartMonth = new System.Windows.Forms.TabPage();
            this.ChartYear = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GbChart.SuspendLayout();
            this.TabChart.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbRevenue
            // 
            this.GbRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.GbRevenue.Location = new System.Drawing.Point(642, 129);
            this.GbRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.GbRevenue.Name = "GbRevenue";
            this.GbRevenue.Padding = new System.Windows.Forms.Padding(4);
            this.GbRevenue.Size = new System.Drawing.Size(566, 428);
            this.GbRevenue.TabIndex = 2;
            this.GbRevenue.TabStop = false;
            this.GbRevenue.Text = "Revenue(DoanhThu)";
            // 
            // GbChart
            // 
            this.GbChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GbChart.Controls.Add(this.TabChart);
            this.GbChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.GbChart.Location = new System.Drawing.Point(57, 129);
            this.GbChart.Margin = new System.Windows.Forms.Padding(4);
            this.GbChart.Name = "GbChart";
            this.GbChart.Padding = new System.Windows.Forms.Padding(4);
            this.GbChart.Size = new System.Drawing.Size(488, 428);
            this.GbChart.TabIndex = 3;
            this.GbChart.TabStop = false;
            this.GbChart.Text = "Chart(BieuDo)";
            // 
            // TabChart
            // 
            this.TabChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TabChart.Controls.Add(this.ChartMonth);
            this.TabChart.Controls.Add(this.ChartYear);
            this.TabChart.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TabChart.Location = new System.Drawing.Point(8, 23);
            this.TabChart.Margin = new System.Windows.Forms.Padding(4);
            this.TabChart.Name = "TabChart";
            this.TabChart.SelectedIndex = 0;
            this.TabChart.Size = new System.Drawing.Size(472, 364);
            this.TabChart.TabIndex = 0;
            // 
            // ChartMonth
            // 
            this.ChartMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartMonth.Location = new System.Drawing.Point(4, 27);
            this.ChartMonth.Margin = new System.Windows.Forms.Padding(4);
            this.ChartMonth.Name = "ChartMonth";
            this.ChartMonth.Padding = new System.Windows.Forms.Padding(4);
            this.ChartMonth.Size = new System.Drawing.Size(464, 333);
            this.ChartMonth.TabIndex = 0;
            this.ChartMonth.Text = "Month";
            this.ChartMonth.UseVisualStyleBackColor = true;
            // 
            // ChartYear
            // 
            this.ChartYear.Location = new System.Drawing.Point(4, 27);
            this.ChartYear.Margin = new System.Windows.Forms.Padding(4);
            this.ChartYear.Name = "ChartYear";
            this.ChartYear.Padding = new System.Windows.Forms.Padding(4);
            this.ChartYear.Size = new System.Drawing.Size(425, 333);
            this.ChartYear.TabIndex = 1;
            this.ChartYear.Text = "Year";
            this.ChartYear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân tích Thống kê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(356, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 54);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(57, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 2);
            this.panel2.TabIndex = 31;
            // 
            // StatisticsPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GbChart);
            this.Controls.Add(this.GbRevenue);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatisticsPage";
            this.Size = new System.Drawing.Size(1290, 687);
            this.Load += new System.EventHandler(this.StatisticsUser_Load);
            this.GbChart.ResumeLayout(false);
            this.TabChart.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbRevenue;
        private System.Windows.Forms.GroupBox GbChart;
        private System.Windows.Forms.TabControl TabChart;
        private System.Windows.Forms.TabPage ChartMonth;
        private System.Windows.Forms.TabPage ChartYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
