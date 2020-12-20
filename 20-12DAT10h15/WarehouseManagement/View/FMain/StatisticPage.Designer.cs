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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.GbRevenue = new System.Windows.Forms.GroupBox();
            this.lbChiTiet = new System.Windows.Forms.Label();
            this.GbChart = new System.Windows.Forms.GroupBox();
            this.TabChart = new System.Windows.Forms.TabControl();
            this.ChartDay = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelNoteD = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtShowChartD = new FontAwesome.Sharp.IconButton();
            this.tBThang = new System.Windows.Forms.TextBox();
            this.chartD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartMonth = new System.Windows.Forms.TabPage();
            this.panelNoteM = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtShowChartM = new FontAwesome.Sharp.IconButton();
            this.tBNam = new System.Windows.Forms.TextBox();
            this.chartM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartYear = new System.Windows.Forms.TabPage();
            this.panelNoteY = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.BtShowChartY = new FontAwesome.Sharp.IconButton();
            this.chartY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GbRevenue.SuspendLayout();
            this.GbChart.SuspendLayout();
            this.TabChart.SuspendLayout();
            this.ChartDay.SuspendLayout();
            this.panelNoteD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartD)).BeginInit();
            this.ChartMonth.SuspendLayout();
            this.panelNoteM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartM)).BeginInit();
            this.ChartYear.SuspendLayout();
            this.panelNoteY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbRevenue
            // 
            this.GbRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbRevenue.Controls.Add(this.lbChiTiet);
            this.GbRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.GbRevenue.Location = new System.Drawing.Point(864, 129);
            this.GbRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.GbRevenue.Name = "GbRevenue";
            this.GbRevenue.Padding = new System.Windows.Forms.Padding(4);
            this.GbRevenue.Size = new System.Drawing.Size(325, 590);
            this.GbRevenue.TabIndex = 2;
            this.GbRevenue.TabStop = false;
            this.GbRevenue.Text = "Chi Tiết";
            // 
            // lbChiTiet
            // 
            this.lbChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChiTiet.AutoSize = true;
            this.lbChiTiet.Location = new System.Drawing.Point(35, 50);
            this.lbChiTiet.Name = "lbChiTiet";
            this.lbChiTiet.Size = new System.Drawing.Size(268, 20);
            this.lbChiTiet.TabIndex = 1;
            this.lbChiTiet.Text = "TOP HÀNG HÓA TRONG THÁNG";
            // 
            // GbChart
            // 
            this.GbChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbChart.Controls.Add(this.TabChart);
            this.GbChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.GbChart.Location = new System.Drawing.Point(14, 106);
            this.GbChart.Margin = new System.Windows.Forms.Padding(4);
            this.GbChart.Name = "GbChart";
            this.GbChart.Padding = new System.Windows.Forms.Padding(4);
            this.GbChart.Size = new System.Drawing.Size(830, 665);
            this.GbChart.TabIndex = 3;
            this.GbChart.TabStop = false;
            this.GbChart.Text = "Revenue(Doanh Thu)";
            // 
            // TabChart
            // 
            this.TabChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabChart.Controls.Add(this.ChartDay);
            this.TabChart.Controls.Add(this.ChartMonth);
            this.TabChart.Controls.Add(this.ChartYear);
            this.TabChart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabChart.Location = new System.Drawing.Point(8, 23);
            this.TabChart.Margin = new System.Windows.Forms.Padding(4);
            this.TabChart.Name = "TabChart";
            this.TabChart.SelectedIndex = 0;
            this.TabChart.Size = new System.Drawing.Size(814, 634);
            this.TabChart.TabIndex = 0;
            // 
            // ChartDay
            // 
            this.ChartDay.Controls.Add(this.panel4);
            this.ChartDay.Controls.Add(this.tBThang);
            this.ChartDay.Controls.Add(this.BtShowChartD);
            this.ChartDay.Controls.Add(this.panel7);
            this.ChartDay.Controls.Add(this.panelNoteD);
            this.ChartDay.Controls.Add(this.chartD);
            this.ChartDay.Location = new System.Drawing.Point(4, 33);
            this.ChartDay.Name = "ChartDay";
            this.ChartDay.Size = new System.Drawing.Size(806, 597);
            this.ChartDay.TabIndex = 2;
            this.ChartDay.Text = "Day";
            this.ChartDay.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Location = new System.Drawing.Point(631, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(170, 100);
            this.panel7.TabIndex = 9;
            // 
            // panelNoteD
            // 
            this.panelNoteD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNoteD.Controls.Add(this.label2);
            this.panelNoteD.Controls.Add(this.panel6);
            this.panelNoteD.Location = new System.Drawing.Point(643, 420);
            this.panelNoteD.Name = "panelNoteD";
            this.panelNoteD.Size = new System.Drawing.Size(158, 63);
            this.panelNoteD.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doanh Thu";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.panel6.Location = new System.Drawing.Point(10, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(29, 25);
            this.panel6.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(544, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 1);
            this.panel4.TabIndex = 7;
            // 
            // BtShowChartD
            // 
            this.BtShowChartD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtShowChartD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtShowChartD.FlatAppearance.BorderSize = 0;
            this.BtShowChartD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtShowChartD.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtShowChartD.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.BtShowChartD.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(159)))), ((int)(((byte)(163)))));
            this.BtShowChartD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtShowChartD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtShowChartD.Location = new System.Drawing.Point(670, 7);
            this.BtShowChartD.Name = "BtShowChartD";
            this.BtShowChartD.Size = new System.Drawing.Size(131, 50);
            this.BtShowChartD.TabIndex = 6;
            this.BtShowChartD.Text = "Hiện";
            this.BtShowChartD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtShowChartD.UseVisualStyleBackColor = false;
            this.BtShowChartD.Click += new System.EventHandler(this.BtShowChartD_Click);
            // 
            // tBThang
            // 
            this.tBThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBThang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBThang.Location = new System.Drawing.Point(557, 17);
            this.tBThang.MaxLength = 4;
            this.tBThang.Name = "tBThang";
            this.tBThang.Size = new System.Drawing.Size(107, 31);
            this.tBThang.TabIndex = 5;
            // 
            // chartD
            // 
            this.chartD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartD.Legends.Add(legend1);
            this.chartD.Location = new System.Drawing.Point(5, 2);
            this.chartD.Name = "chartD";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            this.chartD.Series.Add(series1);
            this.chartD.Size = new System.Drawing.Size(796, 575);
            this.chartD.TabIndex = 1;
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Biểu Đồ Doanh Thu Tháng";
            this.chartD.Titles.Add(title1);
            // 
            // ChartMonth
            // 
            this.ChartMonth.Controls.Add(this.panel3);
            this.ChartMonth.Controls.Add(this.tBNam);
            this.ChartMonth.Controls.Add(this.BtShowChartM);
            this.ChartMonth.Controls.Add(this.panelNoteM);
            this.ChartMonth.Controls.Add(this.panel8);
            this.ChartMonth.Controls.Add(this.chartM);
            this.ChartMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartMonth.Location = new System.Drawing.Point(4, 33);
            this.ChartMonth.Margin = new System.Windows.Forms.Padding(4);
            this.ChartMonth.Name = "ChartMonth";
            this.ChartMonth.Padding = new System.Windows.Forms.Padding(4);
            this.ChartMonth.Size = new System.Drawing.Size(806, 597);
            this.ChartMonth.TabIndex = 0;
            this.ChartMonth.Text = "Month";
            this.ChartMonth.UseVisualStyleBackColor = true;
            // 
            // panelNoteM
            // 
            this.panelNoteM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNoteM.Controls.Add(this.label3);
            this.panelNoteM.Controls.Add(this.panel11);
            this.panelNoteM.Location = new System.Drawing.Point(641, 484);
            this.panelNoteM.Name = "panelNoteM";
            this.panelNoteM.Size = new System.Drawing.Size(158, 63);
            this.panelNoteM.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Doanh Thu";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.panel11.Location = new System.Drawing.Point(10, 20);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(29, 25);
            this.panel11.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Location = new System.Drawing.Point(627, 30);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(176, 79);
            this.panel8.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(542, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 1);
            this.panel3.TabIndex = 4;
            // 
            // BtShowChartM
            // 
            this.BtShowChartM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtShowChartM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtShowChartM.FlatAppearance.BorderSize = 0;
            this.BtShowChartM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtShowChartM.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtShowChartM.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.BtShowChartM.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(159)))), ((int)(((byte)(163)))));
            this.BtShowChartM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtShowChartM.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtShowChartM.Location = new System.Drawing.Point(668, 7);
            this.BtShowChartM.Name = "BtShowChartM";
            this.BtShowChartM.Size = new System.Drawing.Size(131, 50);
            this.BtShowChartM.TabIndex = 3;
            this.BtShowChartM.Text = "Hiện";
            this.BtShowChartM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtShowChartM.UseVisualStyleBackColor = false;
            this.BtShowChartM.Click += new System.EventHandler(this.BtShowChartM_Click);
            // 
            // tBNam
            // 
            this.tBNam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBNam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNam.Location = new System.Drawing.Point(555, 17);
            this.tBNam.MaxLength = 4;
            this.tBNam.Name = "tBNam";
            this.tBNam.Size = new System.Drawing.Size(107, 31);
            this.tBNam.TabIndex = 2;
            // 
            // chartM
            // 
            this.chartM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartM.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartM.Legends.Add(legend2);
            this.chartM.Location = new System.Drawing.Point(7, 2);
            this.chartM.Name = "chartM";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Doanh Thu";
            this.chartM.Series.Add(series2);
            this.chartM.Size = new System.Drawing.Size(796, 587);
            this.chartM.TabIndex = 0;
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Biểu Đồ Doanh Thu Năm";
            this.chartM.Titles.Add(title2);
            // 
            // ChartYear
            // 
            this.ChartYear.Controls.Add(this.BtShowChartY);
            this.ChartYear.Controls.Add(this.panelNoteY);
            this.ChartYear.Controls.Add(this.panel9);
            this.ChartYear.Controls.Add(this.chartY);
            this.ChartYear.Location = new System.Drawing.Point(4, 33);
            this.ChartYear.Margin = new System.Windows.Forms.Padding(4);
            this.ChartYear.Name = "ChartYear";
            this.ChartYear.Padding = new System.Windows.Forms.Padding(4);
            this.ChartYear.Size = new System.Drawing.Size(806, 597);
            this.ChartYear.TabIndex = 1;
            this.ChartYear.Text = "Year";
            this.ChartYear.UseVisualStyleBackColor = true;
            // 
            // panelNoteY
            // 
            this.panelNoteY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNoteY.Controls.Add(this.label4);
            this.panelNoteY.Controls.Add(this.panel13);
            this.panelNoteY.Location = new System.Drawing.Point(641, 485);
            this.panelNoteY.Name = "panelNoteY";
            this.panelNoteY.Size = new System.Drawing.Size(158, 63);
            this.panelNoteY.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doanh Thu";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.panel13.Location = new System.Drawing.Point(10, 20);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(29, 25);
            this.panel13.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Location = new System.Drawing.Point(625, 7);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(174, 99);
            this.panel9.TabIndex = 10;
            // 
            // BtShowChartY
            // 
            this.BtShowChartY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtShowChartY.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtShowChartY.FlatAppearance.BorderSize = 0;
            this.BtShowChartY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtShowChartY.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtShowChartY.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.BtShowChartY.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(159)))), ((int)(((byte)(163)))));
            this.BtShowChartY.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtShowChartY.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtShowChartY.Location = new System.Drawing.Point(666, 7);
            this.BtShowChartY.Name = "BtShowChartY";
            this.BtShowChartY.Size = new System.Drawing.Size(133, 50);
            this.BtShowChartY.TabIndex = 4;
            this.BtShowChartY.Text = "Hiện";
            this.BtShowChartY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtShowChartY.UseVisualStyleBackColor = false;
            this.BtShowChartY.Click += new System.EventHandler(this.BtShowChartY_Click);
            // 
            // chartY
            // 
            this.chartY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartY.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            legend3.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartY.Legends.Add(legend3);
            this.chartY.Location = new System.Drawing.Point(7, 3);
            this.chartY.Name = "chartY";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Doanh Thu";
            series3.YValuesPerPoint = 2;
            this.chartY.Series.Add(series3);
            this.chartY.Size = new System.Drawing.Size(796, 587);
            this.chartY.TabIndex = 0;
            this.chartY.Text = "chart2";
            title3.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Biểu Đồ Doanh Thu Theo Năm      ";
            this.chartY.Titles.Add(title3);
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
            this.panel2.Size = new System.Drawing.Size(1120, 2);
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
            this.Size = new System.Drawing.Size(1225, 790);
            this.GbRevenue.ResumeLayout(false);
            this.GbRevenue.PerformLayout();
            this.GbChart.ResumeLayout(false);
            this.TabChart.ResumeLayout(false);
            this.ChartDay.ResumeLayout(false);
            this.ChartDay.PerformLayout();
            this.panelNoteD.ResumeLayout(false);
            this.panelNoteD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartD)).EndInit();
            this.ChartMonth.ResumeLayout(false);
            this.ChartMonth.PerformLayout();
            this.panelNoteM.ResumeLayout(false);
            this.panelNoteM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartM)).EndInit();
            this.ChartYear.ResumeLayout(false);
            this.panelNoteY.ResumeLayout(false);
            this.panelNoteY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartY;
        private System.Windows.Forms.TextBox tBNam;
        private System.Windows.Forms.Label lbChiTiet;
        private FontAwesome.Sharp.IconButton BtShowChartM;
        private FontAwesome.Sharp.IconButton BtShowChartY;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage ChartDay;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton BtShowChartD;
        private System.Windows.Forms.TextBox tBThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartD;
        private System.Windows.Forms.Panel panelNoteD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panelNoteM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panelNoteY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel13;
    }
}
