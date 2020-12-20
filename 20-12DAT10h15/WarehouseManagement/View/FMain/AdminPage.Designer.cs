
namespace WarehouseManagement
{
    partial class AdminPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.KEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSITION = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BtChat = new FontAwesome.Sharp.IconButton();
            this.BtBlock = new FontAwesome.Sharp.IconButton();
            this.BtEdit = new FontAwesome.Sharp.IconButton();
            this.BtAddKey = new FontAwesome.Sharp.IconButton();
            this.labelUkey = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupChat = new System.Windows.Forms.GroupBox();
            this.icons = new FontAwesome.Sharp.IconButton();
            this.tBMess = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelAddKey = new System.Windows.Forms.Panel();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.GroupChat.SuspendLayout();
            this.panelAddKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdmin.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KEY,
            this.UNAME,
            this.POSITION,
            this.STATUS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(18, 5);
            this.dataGridViewAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAdmin.MinimumSize = new System.Drawing.Size(527, 194);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.RowHeadersVisible = false;
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(982, 327);
            this.dataGridViewAdmin.TabIndex = 1;
            this.dataGridViewAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellClick);
            // 
            // KEY
            // 
            this.KEY.DataPropertyName = "UKEY";
            this.KEY.HeaderText = "Mã Bản Quyền";
            this.KEY.MinimumWidth = 6;
            this.KEY.Name = "KEY";
            // 
            // UNAME
            // 
            this.UNAME.DataPropertyName = "USERNAME";
            this.UNAME.HeaderText = "Tên Tài Khoản";
            this.UNAME.MinimumWidth = 6;
            this.UNAME.Name = "UNAME";
            // 
            // POSITION
            // 
            this.POSITION.DataPropertyName = "POSITION";
            this.POSITION.HeaderText = "Chức Vụ";
            this.POSITION.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý",
            "Quản trị viên"});
            this.POSITION.MinimumWidth = 6;
            this.POSITION.Name = "POSITION";
            this.POSITION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.POSITION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUSACC";
            this.STATUS.HeaderText = "Tình Trạng";
            this.STATUS.Items.AddRange(new object[] {
            "Bình thường",
            "Chặn"});
            this.STATUS.MinimumWidth = 6;
            this.STATUS.Name = "STATUS";
            this.STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BtChat
            // 
            this.BtChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtChat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtChat.FlatAppearance.BorderSize = 0;
            this.BtChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtChat.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtChat.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.BtChat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(174)))), ((int)(((byte)(184)))));
            this.BtChat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtChat.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtChat.Location = new System.Drawing.Point(459, 18);
            this.BtChat.Margin = new System.Windows.Forms.Padding(4);
            this.BtChat.Name = "BtChat";
            this.BtChat.Size = new System.Drawing.Size(141, 63);
            this.BtChat.TabIndex = 10;
            this.BtChat.Text = "Chat  ";
            this.BtChat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtChat.UseVisualStyleBackColor = false;
            // 
            // BtBlock
            // 
            this.BtBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtBlock.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtBlock.FlatAppearance.BorderSize = 0;
            this.BtBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtBlock.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtBlock.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.BtBlock.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(174)))), ((int)(((byte)(184)))));
            this.BtBlock.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtBlock.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtBlock.Location = new System.Drawing.Point(268, 18);
            this.BtBlock.Margin = new System.Windows.Forms.Padding(4);
            this.BtBlock.Name = "BtBlock";
            this.BtBlock.Size = new System.Drawing.Size(141, 63);
            this.BtBlock.TabIndex = 9;
            this.BtBlock.Text = "Chặn  ";
            this.BtBlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtBlock.UseVisualStyleBackColor = false;
            this.BtBlock.Click += new System.EventHandler(this.BtBlock_Click);
            // 
            // BtEdit
            // 
            this.BtEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtEdit.FlatAppearance.BorderSize = 0;
            this.BtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEdit.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(174)))), ((int)(((byte)(184)))));
            this.BtEdit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtEdit.IconSize = 50;
            this.BtEdit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtEdit.Location = new System.Drawing.Point(76, 18);
            this.BtEdit.Margin = new System.Windows.Forms.Padding(4);
            this.BtEdit.Name = "BtEdit";
            this.BtEdit.Size = new System.Drawing.Size(141, 63);
            this.BtEdit.TabIndex = 11;
            this.BtEdit.Text = "Sửa  ";
            this.BtEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtEdit.UseVisualStyleBackColor = false;
            this.BtEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // BtAddKey
            // 
            this.BtAddKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtAddKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(174)))), ((int)(((byte)(184)))));
            this.BtAddKey.FlatAppearance.BorderSize = 0;
            this.BtAddKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAddKey.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAddKey.ForeColor = System.Drawing.Color.White;
            this.BtAddKey.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtAddKey.IconColor = System.Drawing.Color.White;
            this.BtAddKey.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtAddKey.IconSize = 40;
            this.BtAddKey.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtAddKey.Location = new System.Drawing.Point(771, 203);
            this.BtAddKey.Margin = new System.Windows.Forms.Padding(4);
            this.BtAddKey.Name = "BtAddKey";
            this.BtAddKey.Size = new System.Drawing.Size(147, 51);
            this.BtAddKey.TabIndex = 8;
            this.BtAddKey.Text = "Tạo Mã ";
            this.BtAddKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtAddKey.UseVisualStyleBackColor = false;
            this.BtAddKey.Click += new System.EventHandler(this.BtAddKey_Click);
            // 
            // labelUkey
            // 
            this.labelUkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUkey.AutoSize = true;
            this.labelUkey.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelUkey.Location = new System.Drawing.Point(43, 219);
            this.labelUkey.Name = "labelUkey";
            this.labelUkey.Size = new System.Drawing.Size(94, 24);
            this.labelUkey.TabIndex = 14;
            this.labelUkey.Text = "Chức vụ :";
            this.labelUkey.Click += new System.EventHandler(this.labelUkey_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(185, 247);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 1);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // GroupChat
            // 
            this.GroupChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupChat.Controls.Add(this.icons);
            this.GroupChat.Controls.Add(this.tBMess);
            this.GroupChat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupChat.Location = new System.Drawing.Point(1019, 56);
            this.GroupChat.Margin = new System.Windows.Forms.Padding(4);
            this.GroupChat.Name = "GroupChat";
            this.GroupChat.Padding = new System.Windows.Forms.Padding(4);
            this.GroupChat.Size = new System.Drawing.Size(441, 584);
            this.GroupChat.TabIndex = 16;
            this.GroupChat.TabStop = false;
            this.GroupChat.Text = "Chat";
            this.GroupChat.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // icons
            // 
            this.icons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.icons.FlatAppearance.BorderSize = 0;
            this.icons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icons.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icons.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.icons.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(174)))), ((int)(((byte)(184)))));
            this.icons.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.icons.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icons.Location = new System.Drawing.Point(375, 400);
            this.icons.Margin = new System.Windows.Forms.Padding(4);
            this.icons.Name = "icons";
            this.icons.Size = new System.Drawing.Size(58, 153);
            this.icons.TabIndex = 3;
            this.icons.Text = "Gửi";
            this.icons.UseVisualStyleBackColor = true;
            // 
            // tBMess
            // 
            this.tBMess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tBMess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBMess.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBMess.ForeColor = System.Drawing.Color.Gray;
            this.tBMess.Location = new System.Drawing.Point(8, 400);
            this.tBMess.Margin = new System.Windows.Forms.Padding(4);
            this.tBMess.Multiline = true;
            this.tBMess.Name = "tBMess";
            this.tBMess.Size = new System.Drawing.Size(333, 177);
            this.tBMess.TabIndex = 1;
            this.tBMess.Text = "Nhập tin nhắn . . .";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel3.Location = new System.Drawing.Point(1019, 432);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 1);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(174)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(29, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "*Tạo mã bản quyền cho nhân viên";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(174)))), ((int)(((byte)(184)))));
            this.panel2.Location = new System.Drawing.Point(33, 181);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 5);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1031, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Đến: ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1096, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "username";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(174)))), ((int)(((byte)(184)))));
            this.panel4.Location = new System.Drawing.Point(1078, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(335, 1);
            this.panel4.TabIndex = 21;
            // 
            // panelAddKey
            // 
            this.panelAddKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddKey.Controls.Add(this.cbPosition);
            this.panelAddKey.Controls.Add(this.panel2);
            this.panelAddKey.Controls.Add(this.label2);
            this.panelAddKey.Controls.Add(this.panel1);
            this.panelAddKey.Controls.Add(this.labelUkey);
            this.panelAddKey.Controls.Add(this.BtAddKey);
            this.panelAddKey.Controls.Add(this.BtEdit);
            this.panelAddKey.Controls.Add(this.BtChat);
            this.panelAddKey.Controls.Add(this.BtBlock);
            this.panelAddKey.Location = new System.Drawing.Point(6, 366);
            this.panelAddKey.Name = "panelAddKey";
            this.panelAddKey.Size = new System.Drawing.Size(994, 287);
            this.panelAddKey.TabIndex = 22;
            // 
            // cbPosition
            // 
            this.cbPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.cbPosition.Location = new System.Drawing.Point(185, 219);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(550, 24);
            this.cbPosition.TabIndex = 19;
            this.cbPosition.Text = "Nhân viên";
            // 
            // AdminPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panelAddKey);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GroupChat);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPage";
            this.Size = new System.Drawing.Size(1471, 654);
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.GroupChat.ResumeLayout(false);
            this.GroupChat.PerformLayout();
            this.panelAddKey.ResumeLayout(false);
            this.panelAddKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private FontAwesome.Sharp.IconButton BtChat;
        private FontAwesome.Sharp.IconButton BtBlock;
        private FontAwesome.Sharp.IconButton BtEdit;
        private FontAwesome.Sharp.IconButton BtAddKey;
        private System.Windows.Forms.Label labelUkey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GroupChat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tBMess;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton icons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelAddKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn KEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNAME;
        private System.Windows.Forms.DataGridViewComboBoxColumn POSITION;
        private System.Windows.Forms.DataGridViewComboBoxColumn STATUS;
        private System.Windows.Forms.ComboBox cbPosition;
    }
}
