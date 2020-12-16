using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using WarehouseManagement.Controller;
using System.Drawing.Text;

namespace WarehouseManagement
{
    public partial class Admin_AddUser : Form
    {
        Admin_Controller controller = new Admin_Controller();
        public Admin_AddUser(int ukey)
        {
            InitializeComponent();
            tBUkey.KeyPress += textBox_KeyPress;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Admin_AddUser_Load(object sender, EventArgs e)
        {

        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (controller.Check_UKEY(Convert.ToInt32(tBUkey.Text)))
            {
                MessageBox.Show("Mã bản quyền đã tồn tại.");
                return;
            }
            else
                controller.them_UKEY(Convert.ToInt32(tBUkey.Text));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBUkey_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUkey_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
