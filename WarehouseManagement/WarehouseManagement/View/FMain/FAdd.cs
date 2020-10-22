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
    public partial class FAdd : Form
    {
        StockPage_Controller stock = new StockPage_Controller();
        private string MyUsername;
        private int MyUkey;
        public FAdd(string username, int Ukey)
        {
            InitializeComponent();
            MyUsername = username;
            MyUkey = Ukey;
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (tBMaHang.Text == "" || tBTenHang.Text == "" || tBDVT.Text == "" ||
                tBSoLuong.Text == "" || tBDonGia.Text == "")
                MessageBox.Show("Something wrong.");
            else
            {
                string[] donGia = tBDonGia.Text.Split('.');
                if (stock.Them_HangHoa(tBMaHang.Text, tBTenHang.Text, tBDVT.Text, Convert.ToInt32(tBSoLuong.Text),
                    Convert.ToInt32(donGia[0]), dTPNgNhap.Value, dTPNSX.Value,
                    dTPHSD.Value, MyUkey) == true)
                {
                    MessageBox.Show("Chúc mừng đã thêm thành công!");
                    //this.Close();
                }
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
