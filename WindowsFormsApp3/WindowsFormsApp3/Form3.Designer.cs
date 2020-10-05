namespace WindowsFormsApp3
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TagHangHoa = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tDonHang = new System.Windows.Forms.TabPage();
            this.tReport = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.themHangHoa = new System.Windows.Forms.Button();
            this.soLuong = new System.Windows.Forms.Label();
            this.textSL = new System.Windows.Forms.TextBox();
            this.tenHang = new System.Windows.Forms.Label();
            this.maHangHoa = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.textMaHang = new System.Windows.Forms.TextBox();
            this.textTen = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taoDon = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TagHangHoa.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Image = global::WindowsFormsApp3.Properties.Resources.character;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Account";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Image = global::WindowsFormsApp3.Properties.Resources.personal_information;
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Personal Data";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Image = global::WindowsFormsApp3.Properties.Resources.key;
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Change Password";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::WindowsFormsApp3.Properties.Resources.log_out;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Log out";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnToolStripMenuItem,
            this.tácGiảToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.trợGiúpToolStripMenuItem.Text = "Help";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.hướngDẫnToolStripMenuItem.Text = "Guide";
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.tácGiảToolStripMenuItem.Text = "About Author";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TagHangHoa);
            this.tabControl1.Controls.Add(this.tDonHang);
            this.tabControl1.Controls.Add(this.tReport);
            this.tabControl1.ItemSize = new System.Drawing.Size(62, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
<<<<<<< HEAD
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> 70609aad4b67e9f054db324e5ebb63b783d8a07d
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 601);
            this.tabControl1.TabIndex = 2;
            // 
            // TagHangHoa
            // 
            this.TagHangHoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TagHangHoa.Controls.Add(this.panel1);
            this.TagHangHoa.Controls.Add(this.panel2);
            this.TagHangHoa.Controls.Add(this.dataGridView1);
            this.TagHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagHangHoa.Location = new System.Drawing.Point(4, 22);
<<<<<<< HEAD
            this.TagHangHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TagHangHoa.Name = "TagHangHoa";
            this.TagHangHoa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.TagHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.TagHangHoa.Name = "TagHangHoa";
            this.TagHangHoa.Padding = new System.Windows.Forms.Padding(4);
>>>>>>> 70609aad4b67e9f054db324e5ebb63b783d8a07d
            this.TagHangHoa.Size = new System.Drawing.Size(1112, 575);
            this.TagHangHoa.TabIndex = 0;
            this.TagHangHoa.Text = "Stock";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(30, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 62);
            this.panel1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Tên",
            "Mã hàng",
            "Ngày nhập"});
            this.comboBox1.Location = new System.Drawing.Point(46, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 26);
            this.comboBox1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 24);
            this.textBox1.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icon_41_512;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::WindowsFormsApp3.Properties.Resources.statistics;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(868, 16);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "  Search";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
<<<<<<< HEAD
            this.panel2.Location = new System.Drawing.Point(832, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 434);
=======
            this.panel2.Location = new System.Drawing.Point(852, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 432);
>>>>>>> 70609aad4b67e9f054db324e5ebb63b783d8a07d
            this.panel2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Image = global::WindowsFormsApp3.Properties.Resources.printer;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(13, 279);
<<<<<<< HEAD
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.button3.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> 70609aad4b67e9f054db324e5ebb63b783d8a07d
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "PRINT";
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Image = global::WindowsFormsApp3.Properties.Resources.delete;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(13, 153);
<<<<<<< HEAD
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.button2.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> 70609aad4b67e9f054db324e5ebb63b783d8a07d
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "DELETE";
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = global::WindowsFormsApp3.Properties.Resources.plus;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 53);
<<<<<<< HEAD
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.button1.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> 70609aad4b67e9f054db324e5ebb63b783d8a07d
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
<<<<<<< HEAD
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 62);
            this.panel1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker2.Location = new System.Drawing.Point(225, 16);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(160, 24);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "to";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 16);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 24);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 24);
            this.textBox1.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icon_41_512;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Image = global::WindowsFormsApp3.Properties.Resources.statistics;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(919, 14);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "Search";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(805, 432);
=======
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(790, 432);
>>>>>>> 70609aad4b67e9f054db324e5ebb63b783d8a07d
            this.dataGridView1.TabIndex = 0;
            // 
            // tDonHang
            // 
            this.tDonHang.BackColor = System.Drawing.Color.LightBlue;
            this.tDonHang.Controls.Add(this.taoDon);
            this.tDonHang.Controls.Add(this.label1);
            this.tDonHang.Controls.Add(this.textBox2);
            this.tDonHang.Controls.Add(this.dataGridView2);
            this.tDonHang.Controls.Add(this.themHangHoa);
            this.tDonHang.Controls.Add(this.soLuong);
            this.tDonHang.Controls.Add(this.textSL);
            this.tDonHang.Controls.Add(this.tenHang);
            this.tDonHang.Controls.Add(this.maHangHoa);
            this.tDonHang.Controls.Add(this.ID);
            this.tDonHang.Controls.Add(this.textMaHang);
            this.tDonHang.Controls.Add(this.textTen);
            this.tDonHang.Controls.Add(this.textID);
            this.tDonHang.Location = new System.Drawing.Point(4, 22);
<<<<<<< HEAD
            this.tDonHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tDonHang.Name = "tDonHang";
            this.tDonHang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.tDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.tDonHang.Name = "tDonHang";
            this.tDonHang.Padding = new System.Windows.Forms.Padding(4);
>>>>>>> 70609aad4b67e9f054db324e5ebb63b783d8a07d
            this.tDonHang.Size = new System.Drawing.Size(1112, 575);
            this.tDonHang.TabIndex = 1;
            this.tDonHang.Text = "Oder";
            // 
            // tReport
            // 
            this.tReport.Location = new System.Drawing.Point(4, 22);
<<<<<<< HEAD
            this.tReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tReport.Name = "tReport";
            this.tReport.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.tReport.Margin = new System.Windows.Forms.Padding(4);
            this.tReport.Name = "tReport";
            this.tReport.Padding = new System.Windows.Forms.Padding(4);
>>>>>>> 70609aad4b67e9f054db324e5ebb63b783d8a07d
            this.tReport.Size = new System.Drawing.Size(1112, 575);
            this.tReport.TabIndex = 2;
            this.tReport.Text = "Report";
            this.tReport.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(547, 78);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(512, 319);
            this.dataGridView2.TabIndex = 19;
            // 
            // themHangHoa
            // 
            this.themHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themHangHoa.Image = global::WindowsFormsApp3.Properties.Resources.plus;
            this.themHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.themHangHoa.Location = new System.Drawing.Point(354, 170);
            this.themHangHoa.Name = "themHangHoa";
            this.themHangHoa.Size = new System.Drawing.Size(143, 61);
            this.themHangHoa.TabIndex = 18;
            this.themHangHoa.Text = "    ADD";
            this.themHangHoa.UseVisualStyleBackColor = true;
            // 
            // soLuong
            // 
            this.soLuong.AutoSize = true;
            this.soLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuong.Location = new System.Drawing.Point(54, 359);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(88, 20);
            this.soLuong.TabIndex = 17;
            this.soLuong.Text = "Số lượng:";
            // 
            // textSL
            // 
            this.textSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSL.Location = new System.Drawing.Point(161, 356);
            this.textSL.Name = "textSL";
            this.textSL.Size = new System.Drawing.Size(143, 27);
            this.textSL.TabIndex = 16;
            // 
            // tenHang
            // 
            this.tenHang.AutoSize = true;
            this.tenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenHang.Location = new System.Drawing.Point(54, 298);
            this.tenHang.Name = "tenHang";
            this.tenHang.Size = new System.Drawing.Size(92, 20);
            this.tenHang.TabIndex = 15;
            this.tenHang.Text = "Tên hàng:";
            // 
            // maHangHoa
            // 
            this.maHangHoa.AutoSize = true;
            this.maHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maHangHoa.Location = new System.Drawing.Point(54, 237);
            this.maHangHoa.Name = "maHangHoa";
            this.maHangHoa.Size = new System.Drawing.Size(86, 20);
            this.maHangHoa.TabIndex = 14;
            this.maHangHoa.Text = "Mã hàng:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(54, 176);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(34, 20);
            this.ID.TabIndex = 13;
            this.ID.Text = "ID:";
            // 
            // textMaHang
            // 
            this.textMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaHang.Location = new System.Drawing.Point(161, 234);
            this.textMaHang.Name = "textMaHang";
            this.textMaHang.Size = new System.Drawing.Size(143, 27);
            this.textMaHang.TabIndex = 12;
            // 
            // textTen
            // 
            this.textTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTen.Location = new System.Drawing.Point(161, 295);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(143, 27);
            this.textTen.TabIndex = 11;
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(161, 173);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(143, 27);
            this.textID.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(161, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 27);
            this.textBox2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã đơn hàng:";
            // 
            // taoDon
            // 
            this.taoDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taoDon.Image = ((System.Drawing.Image)(resources.GetObject("taoDon.Image")));
            this.taoDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taoDon.Location = new System.Drawing.Point(701, 422);
            this.taoDon.Name = "taoDon";
            this.taoDon.Size = new System.Drawing.Size(237, 61);
            this.taoDon.TabIndex = 22;
            this.taoDon.Text = "      CREATE ODER";
            this.taoDon.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1120, 649);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> 70609aad4b67e9f054db324e5ebb63b783d8a07d
            this.Name = "Form3";
            this.Text = "Phần mềm quản lý kho hàng";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TagHangHoa.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tDonHang.ResumeLayout(false);
            this.tDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TagHangHoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tDonHang;
        private System.Windows.Forms.TabPage tReport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button themHangHoa;
        private System.Windows.Forms.Label soLuong;
        private System.Windows.Forms.TextBox textSL;
        private System.Windows.Forms.Label tenHang;
        private System.Windows.Forms.Label maHangHoa;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox textMaHang;
        private System.Windows.Forms.TextBox textTen;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button taoDon;
    }
}