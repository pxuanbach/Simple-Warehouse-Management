using MVCproject.Controller;
using MVCproject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCproject.View
{
    public partial class HangHoa : Form
    {
        HangHoa_Controller hangHoa = new HangHoa_Controller();
        public HangHoa()
        {
            InitializeComponent();
        }

        HangHoa_Model hanghoa = new HangHoa_Model();
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hanghoa.Load_On();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dataGridView1.CurrentRow.Index;
                textBoxMH.Text = dataGridView1.Rows[i].Cells["maHang"].Value.ToString();
                textBoxTH.Text = dataGridView1.Rows[i].Cells["tenHang"].Value.ToString();
                textBoxDV.Text = dataGridView1.Rows[i].Cells["donVi"].Value.ToString();
                textBoxSL.Text = dataGridView1.Rows[i].Cells["soLuong"].Value.ToString();
                textBoxDG.Text = dataGridView1.Rows[i].Cells["donGia"].Value.ToString();
                dateTimePickerNN.Value = (DateTime)dataGridView1.Rows[i].Cells["ngNhap"].Value;
                dateTimePickerNSX.Value = (DateTime)dataGridView1.Rows[i].Cells["ngSanXuat"].Value;
                dateTimePickerHSD.Value = (DateTime)dataGridView1.Rows[i].Cells["hanSuDung"].Value;
            }
            catch
            {
                e.ToString();
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (hangHoa.Them_HangHoa(textBoxMH.Text, textBoxTH.Text, textBoxDV.Text, Convert.ToInt32(textBoxSL.Text),
                Convert.ToInt32(textBoxDG.Text), dateTimePickerNN.Value, dateTimePickerNSX.Value,
                dateTimePickerHSD.Value, 19521233) == true)
                MessageBox.Show("Chúc mừng đã thêm thành công!");
        }
    }
}
