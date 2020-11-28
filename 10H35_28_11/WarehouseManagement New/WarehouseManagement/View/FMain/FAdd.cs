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
        //tạo 1 đối tượng controller
        StockPage_Controller stock = new StockPage_Controller();
        
        //tạo 1 biến lưu giá trị UKey
        private int MyUkey;
        public FAdd(int Ukey)   //Đầu vào là UKey nhận được từ Main Form
        {
            InitializeComponent();
            MyUkey = Ukey;
            tBDonGia.KeyPress += textBox_KeyPress;
            tBSoLuong.KeyPress += textBox_KeyPress;
        }

        //Click vào button ADD thì hàng hóa đã nhập sẽ được thêm vào SQL Server
        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (tBMaHang.Text == "" || tBTenHang.Text == "" || tBDVT.Text == "" ||
                tBSoLuong.Text == "" || tBDonGia.Text == "")                            //check Exception
                MessageBox.Show("Something wrong.");
            else
            {
                string[] donGia = tBDonGia.Text.Split('.');
                if (stock.Them_HangHoa(tBMaHang.Text, tBTenHang.Text, tBDVT.Text, Convert.ToInt32(tBSoLuong.Text),  //Thêm 1 hàng
                    Convert.ToInt32(donGia[0]), dTPNgNhap.Value, dTPNSX.Value,                                      //hóa vào SQL
                    dTPHSD.Value, MyUkey) == true)                                                                  //Server
                {
                    MessageBox.Show("Chúc mừng đã thêm thành công!");
                }
            }
            
        }

        //Click vào button CANCEL sẽ quay về Main Form
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        
    }
}
