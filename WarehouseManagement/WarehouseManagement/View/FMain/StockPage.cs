using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using WarehouseManagement.Controller;

namespace WarehouseManagement
{
    public partial class StockPage : UserControl
    {
        StockPage_Controller stock = new StockPage_Controller();
        public string UserName;
        public int UKey;
        public StockPage(string Username, int Ukey)
        {
            InitializeComponent();
            UserName = Username;
            UKey = Ukey;
            set_AccessButtonCancel();
        }
        
        public void set_AccessButtonEdit()
        {
            btAdd.Enabled = false;
            btDel.Enabled = false;
            btEdit.Enabled = false;
            btPrint.Enabled = false;
            btCancel.Enabled = true;
            btSave.Enabled = true;
        }

        public void set_AccessButtonCancel()
        {
            btAdd.Enabled = true;
            btDel.Enabled = true;
            btEdit.Enabled = true;
            btPrint.Enabled = true;
            btCancel.Enabled = false;
            btSave.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //dataGridView1.SelectedRows[e.RowIndex].Selected = true;
            //dataGridView1.SelectedCells
            //MessageBox.Show(i.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void StockUser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = stock.Load_On(UserName);
            dataGridView1.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            FAdd f = new FAdd(UserName, UKey);
            //this.Hide();
            f.ShowDialog();
            this.Show();
            dataGridView1.DataSource = stock.Load_On(UserName);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            set_AccessButtonEdit();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            set_AccessButtonCancel();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            if (stock.Xoa_HangHoa(dataGridView1.Rows[n].Cells["maHang"].Value.ToString()) == true)
            {
                MessageBox.Show("Chúc mừng đã xóa thành công!");
                dataGridView1.Refresh();
                dataGridView1.DataSource = stock.Load_On(UserName);
            }
        }
    }
}
