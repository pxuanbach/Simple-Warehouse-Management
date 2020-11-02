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
        MainForm_Controller controller = new MainForm_Controller();
        public string UserName;
        public StockPage(string Username)
        {
            InitializeComponent();
            UserName = Username;
        }
        
        public void set_AccessButtonEdit()
        {
            btAdd.Enabled = false;
            btDel.Enabled = false;
            btEdit.Enabled = false;
            btPrint.Enabled = false;
        }

        public void set_AccessButtonCancel()
        {
            btAdd.Enabled = true;
            btDel.Enabled = true;
            btEdit.Enabled = true;
            btPrint.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            dataGridView1.DataSource = controller.Load_On(UserName);
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            //FAddStock f = new FAddStock();
            //this.Hide();
            //f.ShowDialog();
            //this.Show();

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            set_AccessButtonEdit();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            set_AccessButtonCancel();
        }
    }
}
