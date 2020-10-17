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

namespace WindowsFormsApp3
{
    public partial class StockPage : UserControl
    {
        public StockPage()
        {
            InitializeComponent();
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

        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            FAddStock f = new FAddStock();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
    }
}
