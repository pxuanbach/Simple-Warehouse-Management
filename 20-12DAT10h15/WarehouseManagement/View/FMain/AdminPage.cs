using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement.Controller;
namespace WarehouseManagement
{
    public partial class AdminPage : UserControl
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        Admin_Controller controller = new Admin_Controller();

        private void BtAddKey_Click(object sender, EventArgs e)
        {
            controller.them_Postion(cbPosition.Text);
            MessageBox.Show("Thêm thành công");
            AdminPage_Load(sender, e);  // load lại data sau khi add
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            dataGridViewAdmin.DataSource = controller.load_on(1000);
            dataGridViewAdmin.ReadOnly = true;
            for (int i = 0; i < dataGridViewAdmin.Rows.Count-1; i++)
            {
               if (dataGridViewAdmin.Rows[i].Cells[3].Value.ToString() =="Chặn")
                   dataGridViewAdmin.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
        }
        string Ukey_data = "";
        string uname = "";
        private void BtBlock_Click(object sender, EventArgs e)
        {
            if (Ukey_data == "") MessageBox.Show("Vui lòng chọn hàng để chặn.");
            else
            {
                controller.Fix_status(Ukey_data, "Chặn");
                AdminPage_Load(sender, e);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelUkey_Click(object sender, EventArgs e)
        {

        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            //check = false;
            dataGridViewAdmin.Columns[2].ReadOnly = false;
            dataGridViewAdmin.Columns[2].ReadOnly = false;
            //btSave.Enabled = true;
            MessageBox.Show("Bấm save để lưu lại bản chỉnh sửa");
        }

        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewAdmin.CurrentRow.Selected = true;
            if (e.RowIndex >= 0)
            {
                Ukey_data = dataGridViewAdmin.Rows[e.RowIndex].Cells["KEY"].Value.ToString();
                uname = dataGridViewAdmin.Rows[e.RowIndex].Cells["UNAME"].Value.ToString();
            }
        }
    }
}
