using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagement
{
    public partial class AdminPage : UserControl
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    }

        private void BtAddKey_Click(object sender, EventArgs e)
        {
            /* if (controller.Check_UKEY(Convert.ToInt32(tBUkey.Text)))
            {
                MessageBox.Show("Mã bản quyền đã tồn tại.");
                return;
            }
            else
                controller.them_UKEY(Convert.ToInt32(tBUkey.Text)); */
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void BtBlock_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelUkey_Click(object sender, EventArgs e)
        {

        }
    }
}
