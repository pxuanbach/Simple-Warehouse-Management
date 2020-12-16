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
    public partial class FStock : Form
    {
        //tạo 1 đối tượng controller
        StockPage_Controller controller = new StockPage_Controller();
        
        //tạo 1 biến lưu giá trị UKey
        private int MyUkey;
        int Type;
        Stock stock;
        public FStock(int Ukey, int Type, Stock g)   //Đầu vào là UKey nhận được từ Main Form
        {
            //Type = 0 và stock = null => form ADD
            //Type = 1 và stock != null => form EDIT

            InitializeComponent();
            MyUkey = Ukey;
            this.Type = Type;
            stock = g;
            if (Type == 0)
            {
                Header.Text = "Thêm Hàng Hóa:";
                BtAdd.Text = "    Thêm";
                BtAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
                cbBDVT.SelectedIndex = 0;
            }
            else if (Type == 1)
            {
                Header.Text = "Sửa Hàng Hóa:";
                BtAdd.Text = "     Lưu";
                BtAdd.IconChar = FontAwesome.Sharp.IconChar.Save;
            }    
            tBDonGia.KeyPress += textBox_KeyPress;
            tBSoLuong.KeyPress += textBox_KeyPress;
        }

        //Click vào button ADD thì hàng hóa đã nhập sẽ được thêm vào SQL Server
        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (tBTenHang.Text == "" || tBSoLuong.Text == "" || tBDonGia.Text == "")    //check Exception
                MessageBox.Show("Không được bỏ trống thông tin!");
            else
            {
                string[] donGia = tBDonGia.Text.Split('.');
                string NSX = dTPNSX.Value.ToString();
                string HSD = dTPHSD.Value.ToString();
                if (CbNSX.Checked == true)
                {
                    NSX = "null";
                }
                if (CbHSD.Checked == true)
                {
                    HSD = "null";
                }    
                
                if (Type == 0)
                {
                    if (controller.Them_HangHoa(tBTenHang.Text, cbBDVT.Text, Convert.ToInt32(tBSoLuong.Text),   //Thêm 1 hàng
                        Convert.ToInt32(donGia[0]), DateTime.Now, NSX,                                          //hóa vào database
                        HSD, MyUkey) == true)                                                                   
                    {
                        MessageBox.Show("Chúc mừng đã thêm thành công!");
                    }
                }
                else if (Type == 1)
                {
                    if (controller.Update_HangHoa(stock.MAHANG, tBTenHang.Text, cbBDVT.Text, Convert.ToInt32(tBSoLuong.Text),
                        Convert.ToInt32(donGia[0]), NSX, HSD, stock.UKEY1))
                    {
                        MessageBox.Show("Chúc mừng đã sửa thành công!");
                    }    
                }    
            }

        }

        //Click vào button CANCEL sẽ quay về Main Form
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FStock_Load(object sender, EventArgs e)
        {
            if (stock != null)
            {
                labelMaHang.Text = stock.MAHANG;
                tBTenHang.Text = stock.TENHANG;
                tBSoLuong.Text = stock.SOLUONG;
                tBDonGia.Text = stock.DONGIA;
                cbBDVT.SelectedItem = stock.DVT;
                if (stock.NGSANXUAT == "")
                {
                    CbNSX.Checked = true;
                }
                else
                {
                    dTPNSX.Value = Convert.ToDateTime(stock.NGSANXUAT);
                }

                if (stock.HSD == "")
                {
                    CbHSD.Checked = true;
                }
                else
                {
                    dTPHSD.Value = Convert.ToDateTime(stock.HSD);
                }
                
            }    
            
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
