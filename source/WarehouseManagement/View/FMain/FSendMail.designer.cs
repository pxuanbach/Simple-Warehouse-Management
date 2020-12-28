
namespace WarehouseManagement
{
    partial class FSendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSendMail));
            this.icTo = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.icSubject = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.RichTextBox();
            this.icAttach = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtBack = new FontAwesome.Sharp.IconButton();
            this.BtSend = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // icTo
            // 
            this.icTo.BackColor = System.Drawing.Color.Transparent;
            this.icTo.FlatAppearance.BorderSize = 0;
            this.icTo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.icTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.icTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.icTo.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.icTo.IconColor = System.Drawing.Color.DarkGray;
            this.icTo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icTo.IconSize = 25;
            this.icTo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icTo.Location = new System.Drawing.Point(39, 78);
            this.icTo.Name = "icTo";
            this.icTo.Size = new System.Drawing.Size(26, 26);
            this.icTo.TabIndex = 40;
            this.icTo.TabStop = false;
            this.icTo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(101, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 1);
            this.panel1.TabIndex = 39;
            // 
            // tbTo
            // 
            this.tbTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTo.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTo.ForeColor = System.Drawing.Color.Silver;
            this.tbTo.Location = new System.Drawing.Point(135, 80);
            this.tbTo.Margin = new System.Windows.Forms.Padding(4);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(456, 27);
            this.tbTo.TabIndex = 38;
            this.tbTo.Tag = "1";
            this.tbTo.Text = "Email người nhận";
            // 
            // icSubject
            // 
            this.icSubject.BackColor = System.Drawing.Color.Transparent;
            this.icSubject.FlatAppearance.BorderSize = 0;
            this.icSubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.icSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.icSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icSubject.ForeColor = System.Drawing.Color.Gray;
            this.icSubject.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.icSubject.IconColor = System.Drawing.Color.DarkGray;
            this.icSubject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icSubject.IconSize = 23;
            this.icSubject.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icSubject.Location = new System.Drawing.Point(39, 137);
            this.icSubject.Name = "icSubject";
            this.icSubject.Size = new System.Drawing.Size(26, 26);
            this.icSubject.TabIndex = 49;
            this.icSubject.TabStop = false;
            this.icSubject.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(146, 164);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(449, 1);
            this.panel5.TabIndex = 48;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.Silver;
            this.tbTitle.Location = new System.Drawing.Point(157, 141);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(434, 27);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.Tag = "0";
            this.tbTitle.Text = "Nhập chủ đề";
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            this.tbTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTitle_KeyPress);
            // 
            // tbContent
            // 
            this.tbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContent.Location = new System.Drawing.Point(41, 201);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(554, 299);
            this.tbContent.TabIndex = 1;
            this.tbContent.Text = "";
            // 
            // icAttach
            // 
            this.icAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.icAttach.FlatAppearance.BorderSize = 0;
            this.icAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icAttach.Font = new System.Drawing.Font("Tahoma", 9.8F);
            this.icAttach.ForeColor = System.Drawing.Color.Teal;
            this.icAttach.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.icAttach.IconColor = System.Drawing.Color.Teal;
            this.icAttach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icAttach.IconSize = 20;
            this.icAttach.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.icAttach.Location = new System.Drawing.Point(39, 511);
            this.icAttach.Name = "icAttach";
            this.icAttach.Size = new System.Drawing.Size(122, 34);
            this.icAttach.TabIndex = 2;
            this.icAttach.Text = "File Attach";
            this.icAttach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icAttach.UseVisualStyleBackColor = true;
            this.icAttach.Click += new System.EventHandler(this.icAttach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(174)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Từ: BDTCompanyUIT@gmail.com";
            // 
            // BtBack
            // 
            this.BtBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(174)))), ((int)(((byte)(184)))));
            this.BtBack.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBack.ForeColor = System.Drawing.Color.White;
            this.BtBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.BtBack.IconColor = System.Drawing.Color.White;
            this.BtBack.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtBack.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtBack.Location = new System.Drawing.Point(363, 557);
            this.BtBack.Name = "BtBack";
            this.BtBack.Size = new System.Drawing.Size(232, 64);
            this.BtBack.TabIndex = 4;
            this.BtBack.Text = "Trở về     ";
            this.BtBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBack.UseVisualStyleBackColor = false;
            this.BtBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // BtSend
            // 
            this.BtSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(174)))), ((int)(((byte)(184)))));
            this.BtSend.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSend.ForeColor = System.Drawing.Color.White;
            this.BtSend.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.BtSend.IconColor = System.Drawing.Color.White;
            this.BtSend.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtSend.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtSend.Location = new System.Drawing.Point(39, 557);
            this.BtSend.Name = "BtSend";
            this.BtSend.Size = new System.Drawing.Size(228, 64);
            this.BtSend.TabIndex = 3;
            this.BtSend.Text = "Gửi đi     ";
            this.BtSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtSend.UseVisualStyleBackColor = false;
            this.BtSend.Click += new System.EventHandler(this.BtSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(71, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "Chủ đề:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(71, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 58;
            this.label3.Text = "Đến:";
            // 
            // FSendMail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtSend);
            this.Controls.Add(this.BtBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.icSubject);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.icAttach);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.icTo);
            this.Controls.Add(this.tbTo);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 700);
            this.Name = "FSendMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gửi email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton icTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbTo;
        private FontAwesome.Sharp.IconButton icSubject;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.RichTextBox tbContent;
        private FontAwesome.Sharp.IconButton icAttach;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtBack;
        private FontAwesome.Sharp.IconButton BtSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}