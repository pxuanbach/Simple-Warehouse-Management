namespace WindowsFormsApp3
{
    partial class OderUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OderUser));
            this.btEdit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtDel = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btEdit
            // 
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdit.Location = new System.Drawing.Point(358, 364);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(90, 38);
            this.btEdit.TabIndex = 8;
            this.btEdit.Text = "EDIT";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEdit.UseMnemonic = false;
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(634, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "PRINT";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtDel
            // 
            this.BtDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDel.Image = ((System.Drawing.Image)(resources.GetObject("BtDel.Image")));
            this.BtDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtDel.Location = new System.Drawing.Point(481, 364);
            this.BtDel.Name = "BtDel";
            this.BtDel.Size = new System.Drawing.Size(121, 38);
            this.BtDel.TabIndex = 6;
            this.BtDel.Text = "DELETE";
            this.BtDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtDel.UseMnemonic = false;
            this.BtDel.UseVisualStyleBackColor = true;
            // 
            // BtAdd
            // 
            this.BtAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtAdd.Image")));
            this.BtAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAdd.Location = new System.Drawing.Point(54, 375);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(95, 38);
            this.BtAdd.TabIndex = 5;
            this.BtAdd.Text = "     ADD";
            this.BtAdd.UseMnemonic = false;
            this.BtAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(352, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(382, 338);
            this.dataGridView1.TabIndex = 11;
            // 
            // OderUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtDel);
            this.Controls.Add(this.BtAdd);
            this.Name = "OderUser";
            this.Size = new System.Drawing.Size(744, 444);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtDel;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
