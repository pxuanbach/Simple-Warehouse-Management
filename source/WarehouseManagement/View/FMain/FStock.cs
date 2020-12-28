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
using System.Globalization;

namespace WarehouseManagement
{
    public partial class FStock : Form
    {
        //tạo 1 đối tượng controller
        StockPage_Controller controller = new StockPage_Controller();
        
        //tạo 1 biến lưu giá trị UKey
        private int MyUkey;
        int Type;
        int Position;
        Stock stock;
        public FStock(int Ukey, int Type, Stock g, int Pos)   //Đầu vào là UKey nhận được từ Main Form
        {
            //Type = 0 và stock = null => form ADD
            //Type = 1 và stock != null => form EDIT

            InitializeComponent();
            MyUkey = Ukey;
            this.Type = Type;
            Position = Pos;
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

        public event EventHandler Updated;

        //Click vào button ADD thì hàng hóa đã nhập sẽ được thêm vào SQL Server
        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (tBTenHang.Text == "" || tBSoLuong.Text == "" || tBDonGia.Text == "")    //check Exception
                MessageBox.Show("Không được bỏ trống thông tin!", "Thông báo");
            else
            {
                string[] donGia = tBDonGia.Text.Split('.');
                string NSX = "null", HSD = "null", nsx = "", hsd = "";
                if (CbNSX.Checked == false)
                {
                    NSX = dTPNSX.Value.ToString("yyyy/MM/dd");
                    nsx = dTPNSX.Value.ToString("dd/MM/yyyy");
                }    
                if (CbHSD.Checked == false)
                {
                    HSD = dTPHSD.Value.ToString("yyyy/MM/dd");
                    hsd = dTPHSD.Value.ToString("dd/MM/yyyy");
                }

                if (Type == 0)
                {
                    if (Convert.ToInt32(tBSoLuong.Text) < 1)
                    {
                        MessageBox.Show("Số lượng không được nhỏ hơn 1.", "Thông tin không hợp lệ");
                        return;
                    }    
                    if (Convert.ToInt32(tBDonGia.Text) < 500)
                    {
                        MessageBox.Show("Đơn giá không nhỏ hơn 500đ.", "Thông tin không hợp lệ");
                        return;
                    }    
                    if (CbNSX.Checked == true && CbHSD.Checked == false)
                    {
                        MessageBox.Show("Có hạn sử dụng nhưng không có ngày sản xuất.\nVui lòng kiểm tra lại!", "Thông tin không hợp lệ");
                        return;
                    }    
                    if (CbNSX.Checked != true && CbHSD.Checked != true)
                    {
                        if (DateTime.Compare(dTPNSX.Value, dTPHSD.Value) == 0
                            || DateTime.Compare(dTPNSX.Value, dTPHSD.Value) > 0)
                        {
                            MessageBox.Show("Ngày sản xuất phải nhỏ hơn hạn sử dụng.", "Thông tin không hợp lệ");
                            return;
                        }    
                    }
                    if (tBTenHang.Text == controller.getTenHang(tBTenHang.Text, MyUkey, Position))
                    {
                        var window = MessageBox.Show("Tên hàng đã tồn tại trong kho.\n" +
                            "Bạn chắc chắn muốn tạo mới hàng hóa này?", "Thông báo", MessageBoxButtons.YesNo);
                        if (window == DialogResult.Yes)
                        {
                            if (controller.Them_HangHoa(tBTenHang.Text, cbBDVT.Text, Convert.ToInt32(tBSoLuong.Text),   //Thêm 1 hàng
                                Convert.ToInt32(donGia[0]), DateTime.Now, NSX,                                          //hóa vào database
                                HSD, MyUkey) == true)
                            {
                                MessageBox.Show("Chúc mừng đã thêm thành công!", "Thông báo");
                            }
                        }    
                    }
                    else
                    {
                        if (controller.Them_HangHoa(tBTenHang.Text, cbBDVT.Text, Convert.ToInt32(tBSoLuong.Text),   //Thêm 1 hàng
                            Convert.ToInt32(donGia[0]), DateTime.Now, NSX,                                          //hóa vào database
                            HSD, MyUkey) == true)
                        {
                            MessageBox.Show("Chúc mừng đã thêm thành công!", "Thông báo");
                        }
                    }
                }
                else if (Type == 1)
                {
                    if (NSX != "null" && HSD != "null")
                    {
                        if (DateTime.Compare(dTPNSX.Value, dTPHSD.Value) == 0
                            || DateTime.Compare(dTPNSX.Value, dTPHSD.Value) > 0)
                        {
                            MessageBox.Show("Ngày sản xuất phải nhỏ hơn hạn sử dụng.", "Thông tin không hợp lệ");
                            return;
                        }
                    }
                    
                    if (!kiemTraKhacNhau(stock, tBTenHang.Text, cbBDVT.Text, tBDonGia.Text, nsx, hsd))
                    {
                        if (controller.Check_HangHoa_In_CTHD(labelMaHang.Text, MyUkey, Position))
                        {
                            MessageBox.Show("Hàng hóa này đã tồn tại trong hóa đơn.\nChỉ có thể thay đổi số lượng.", "Thông báo");
                            setValue_EditMode();
                            return;
                        }    
                    }    
                    if (controller.Update_HangHoa(stock.MAHANG, tBTenHang.Text, cbBDVT.Text, Convert.ToInt32(tBSoLuong.Text),
                            Convert.ToInt32(donGia[0]), NSX, HSD, stock.UKEY1))
                    {
                        MessageBox.Show("Chúc mừng đã sửa thành công!", "Thông báo");
                    }    
                }    
                else
                {
                    MessageBox.Show("Lỗi chức vụ.", "Đã có lỗi xảy ra");
                    this.Close();
                }   
            }
            if (Updated != null)
            {
                Updated(sender, new EventArgs()); //Raise a change.
            }
        }

        bool kiemTraKhacNhau(Stock g, string tenHang, string dVT, string donGia, string NSX, string HSD)
        {
            NSX = NSX.Replace('-', '/');
            HSD = HSD.Replace('-', '/');
            if (g.NGSANXUAT != NSX)
                return false;
            if (g.HSD != HSD)
                return false;
            if (g.TENHANG != tenHang)
                return false;
            if (g.DVT != dVT)
                return false;
            if (g.DONGIA != donGia)
                return false;
            return true;
        }

        //Click vào button CANCEL sẽ quay về Main Form
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void setValue_EditMode()
        {
            if (stock != null)
            {
                labelMaHang.Text = stock.MAHANG;
                tBTenHang.Text = stock.TENHANG;
                tBSoLuong.Text = stock.SOLUONG;
                tBDonGia.Text = stock.DONGIA;
                cbBDVT.SelectedItem = stock.DVT;
                if (stock.NGSANXUAT == "")
                    CbNSX.Checked = true;
                else
                {
                    CbNSX.Checked = false;
                    dTPNSX.Value = DateTime.ParseExact(stock.NGSANXUAT, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }    
                    

                if (stock.HSD == "")
                    CbHSD.Checked = true;
                else
                {
                    CbHSD.Checked = false;
                    dTPHSD.Value = DateTime.ParseExact(stock.HSD, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
            }
        }

        private void FStock_Load(object sender, EventArgs e)
        {
            setValue_EditMode();
            
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
