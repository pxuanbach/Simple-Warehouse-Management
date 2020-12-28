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
    public partial class FOrderPageEdit : Form
    {
        OrderPage_Controller controller = new OrderPage_Controller();
        HoaDon hoaDonEdited = new HoaDon();
        int UKEY;
        int Position;
        public FOrderPageEdit(int UKEY, int Pos)
        {
            InitializeComponent();
            this.UKEY = UKEY;
            Position = Pos;

            tBDonGia.KeyPress += textBox_KeyPress;
            tBSoLuong.KeyPress += textBox_KeyPress;
        }

        //Bắt sự kiện khi nhấn phím bất kì, chỉ cho phép nhập các phím số và phím control (để Backspace được)
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public void getValue(HoaDon a)
        {
            hoaDonEdited = a;
        }

        public HoaDon returnHoaDon()
        {
            return hoaDonEdited;
        }

        void ClickCell_dGV()
        {
            if (dGVEditOrders.SelectedRows.Count > 0)
            {
                int n = dGVEditOrders.SelectedRows[0].Index;
                string[] donGia = dGVEditOrders.Rows[n].Cells["DONGIA"].Value.ToString().Split('.');
                tBMaHang.Text = dGVEditOrders.Rows[n].Cells["MAHANG"].Value.ToString();
                tBTenHang.Text = dGVEditOrders.Rows[n].Cells["TENHANG"].Value.ToString();
                tBDonGia.Text = donGia[0];
                tBSoLuong.Text = dGVEditOrders.Rows[n].Cells["SOLUONG"].Value.ToString();
            }
        }

        private void FOrderPageEdit_Load(object sender, EventArgs e)
        {
            //Binding dataGridView
            if (hoaDonEdited.ListCTHD != null)
            {
                var CTHDList = new BindingList<CTHD>(hoaDonEdited.ListCTHD); // <-- BindingList
                dGVEditOrders.DataSource = CTHDList;
                dGVEditOrders.Columns["NGNHAP"].Visible = false;
                dGVEditOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dGVEditOrders.ReadOnly = true;
            }    

            //Thông tin hóa đơn
            labelMaDon.Text = hoaDonEdited.MaHD.ToString();
            tBDoiTac.Text = hoaDonEdited.TenDoiTac;
            tBLienHe.Text = hoaDonEdited.LienHe;
            dTPTime.Value = new DateTime(hoaDonEdited.ThoiGian.Year, hoaDonEdited.ThoiGian.Month, hoaDonEdited.ThoiGian.Day);
            labelThanhTien.Text = controller.Sum_DONGIA(hoaDonEdited.ListCTHD).ToString();
        }

        private void BtSua_Click(object sender, EventArgs e)
        {
            if (tBMaHang.Text == "" || tBTenHang.Text == "" || tBDonGia.Text == "" || tBSoLuong.Text == "")
            {
                MessageBox.Show("Có thông tin trống.", "Thông báo");
                return;
            }
            else
            {
                if (controller.Check_HangHoa(tBMaHang.Text, tBTenHang.Text,
                    Convert.ToInt32(tBDonGia.Text), UKEY, Position) == false)
                {
                    MessageBox.Show("Thông tin hàng hóa sai.\nVui lòng chọn hàng hóa có sẵn trong kho!", "Thông báo");
                    tBMaHang.Text = "";
                    tBTenHang.Text = "";
                    tBDonGia.Text = "";
                    tBSoLuong.Text = "";
                    return;
                }
                else if (!controller.Check_SoLuong_HangHoa(hoaDonEdited.ListCTHD, 
                    tBMaHang.Text, UKEY, Convert.ToInt32(tBSoLuong.Text), Position))
                {
                    MessageBox.Show("Số lượng hàng hóa yêu cầu lớn hơn số lượng hàng hóa có sẵn." +
                                "\nVui lòng điều chỉnh số lượng hàng hóa lại.", "Thông báo");
                    tBSoLuong.Text = "";
                }
                else
                {
                    remove_CTHD(hoaDonEdited.ListCTHD, tBMaHang.Text);
                    if (Convert.ToInt32(tBSoLuong.Text) > 0)
                    {
                        hoaDonEdited.ListCTHD.Add(new CTHD
                        {
                            MAHANG = tBMaHang.Text,
                            TENHANG = tBTenHang.Text,
                            DONGIA = Convert.ToInt32(tBDonGia.Text),
                            SOLUONG = Convert.ToInt32(tBSoLuong.Text)
                        });
                    }    

                    hoaDonEdited.GiaTri = controller.Sum_DONGIA(hoaDonEdited.ListCTHD).ToString(); //Trị giá
                    
                    var CTHDList = new BindingList<CTHD>(hoaDonEdited.ListCTHD); // <-- BindingList
                    dGVEditOrders.DataSource = CTHDList;
                    dGVEditOrders.Columns["NGNHAP"].Visible = false;
                    labelThanhTien.Text = controller.Sum_DONGIA(hoaDonEdited.ListCTHD).ToString();
                }    
            }    
        }

        bool check_Wrong(string tenDoiTac, string lienHe, DateTime thoiGian)
        {
            DateTime d1 = new DateTime(dTPTime.Value.Year, dTPTime.Value.Month, dTPTime.Value.Day);
            DateTime d2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (tenDoiTac == "" || tenDoiTac == "Nhập tên đối tác cho hóa đơn")
            {
                MessageBox.Show("Vui lòng nhập tên đối tác.", "Thông báo");
                return false;
            }
            else if (lienHe == "" || lienHe == "Nhập số điện thoại hoặc địa chỉ của đối tác")
            {
                MessageBox.Show("Vui lòng nhập thông tin liên hệ.", "Thông báo");
                return false;
            }
            if (DateTime.Compare(d1, d2) < 0)
            {
                MessageBox.Show("Thời gian phải lớn hơn thời gian hiện tại.", "Thông báo");
                return false;
            }
            else
                return true;
        }

        void remove_CTHD(List<CTHD> cTHDs, string maHang)
        {
            for (int i = 0; i < cTHDs.Count; i++)
            {
                if (cTHDs[i].MAHANG == maHang)
                {
                    cTHDs.RemoveAt(i);
                    break;
                }    
            }    
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            if (dGVEditOrders.SelectedRows.Count > 0)
            {
                int n = dGVEditOrders.SelectedRows[0].Index;    //lấy giá trị hàng đã chọn
                for (int i = 0; i < hoaDonEdited.ListCTHD.Count; i++)
                {
                    if (hoaDonEdited.ListCTHD[i].MAHANG == dGVEditOrders.Rows[n].Cells[0].Value.ToString())
                    {
                        hoaDonEdited.ListCTHD.RemoveAt(i);
                    }
                }
                hoaDonEdited.GiaTri = controller.Sum_DONGIA(hoaDonEdited.ListCTHD).ToString(); //Trị giá
                var CTHDList = new BindingList<CTHD>(hoaDonEdited.ListCTHD); // <-- BindingList
                dGVEditOrders.DataSource = CTHDList;
                dGVEditOrders.Columns["NGNHAP"].Visible = false;
                labelThanhTien.Text = controller.Sum_DONGIA(hoaDonEdited.ListCTHD).ToString();
            }
        }

        private void BtSaveAll_Click(object sender, EventArgs e)
        {
            if (check_Wrong(tBDoiTac.Text, tBLienHe.Text, dTPTime.Value))
            {
                hoaDonEdited.TenDoiTac = tBDoiTac.Text;
                hoaDonEdited.LienHe = tBLienHe.Text;
                hoaDonEdited.ThoiGian = dTPTime.Value;
            }
            hoaDonEdited.GiaTri = controller.Sum_DONGIA(hoaDonEdited.ListCTHD).ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dGVEditOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClickCell_dGV();
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void panelInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
