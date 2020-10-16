namespace WindowsFormsApp3
{
    partial class StockUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockUser));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btEdit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtDel = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name\t",
            "Goods ID",
            "Date"});
            this.comboBox1.Location = new System.Drawing.Point(36, 251);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxtSearch
            // 
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TxtSearch.Location = new System.Drawing.Point(208, 247);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(388, 28);
            this.TxtSearch.TabIndex = 10;
            this.TxtSearch.Text = "Search Stock";
            this.TxtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.icon_41_512;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::WindowsFormsApp3.Properties.Resources.statistics;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(596, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 31);
            this.button4.TabIndex = 9;
            this.button4.Text = "Search";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 233);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btEdit);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.BtDel);
            this.panel2.Controls.Add(this.BtAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 114);
            this.panel2.TabIndex = 9;
            // 
            // btEdit
            // 
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdit.Location = new System.Drawing.Point(202, 33);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(140, 57);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "EDIT";
            this.btEdit.UseMnemonic = false;
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(565, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "PRINT";
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtDel
            // 
            this.BtDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDel.Image = ((System.Drawing.Image)(resources.GetObject("BtDel.Image")));
            this.BtDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtDel.Location = new System.Drawing.Point(379, 33);
            this.BtDel.Name = "BtDel";
            this.BtDel.Size = new System.Drawing.Size(140, 57);
            this.BtDel.TabIndex = 2;
            this.BtDel.Text = "DELETE";
            this.BtDel.UseMnemonic = false;
            this.BtDel.UseVisualStyleBackColor = true;
            // 
            // BtAdd
            // 
            this.BtAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtAdd.Image")));
            this.BtAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAdd.Location = new System.Drawing.Point(34, 33);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(140, 57);
            this.BtAdd.TabIndex = 1;
            this.BtAdd.Text = "ADD";
            this.BtAdd.UseMnemonic = false;
            this.BtAdd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(202, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 1);
            this.panel1.TabIndex = 12;
            // 
            // StockUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Name = "StockUser";
            this.Size = new System.Drawing.Size(744, 444);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtDel;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.Panel panel1;
    }
}
