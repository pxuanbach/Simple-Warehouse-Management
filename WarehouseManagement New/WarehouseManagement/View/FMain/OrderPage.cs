using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement.Controller;

namespace WarehouseManagement
{
    public partial class OderUser : UserControl
    {
        OrderPage_Controller controller = new OrderPage_Controller();
        public int UKEY;
        public int saveStatus = 0;
        public bool isSearched = false;
        bool isClickedButtonMain = false;
        bool isClickedButtonEdit = false;
        bool isNewOrder = false;
        List<CTHD> listCTHD = new List<CTHD>();
        ToolTip toolTip = new ToolTip();
        public OderUser(int ukey)
        {
            InitializeComponent();
            setButtonHide();
            cBSelect.SelectedIndex = 0;
            UKEY = ukey;

            toolTip.SetToolTip(btMain, "Click to show list button.");
            toolTip.SetToolTip(btCreateOrder, "NEW ORDER\nClick to create new order.");
            toolTip.SetToolTip(btEdit, "EDIT\nClick to edit order.");
            toolTip.SetToolTip(btSave, "SAVE\nClick to save ORDER.");
            toolTip.SetToolTip(btCancel, "CANCEL\nClick to exit edit mode.");
            toolTip.SetToolTip(btDelete, "DELETE\nClick to delete row in order.");
            toolTip.SetToolTip(btPrint, "PRINT\nClick to print order.");

            tBDonGia.KeyPress += textBox_KeyPress;
            tBSoLuong.KeyPress += textBox_KeyPress;
            dGVOrders.CellBeginEdit += DGVOrders_CellBeginEdit;
            dGVOrders.CellValueChanged += DGVOrders_CellValueChanged;
        }

        public string maHang;
        public int oldValue;
        private void DGVOrders_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            maHang = dGVOrders.SelectedRows[0].Cells[0].Value.ToString();
            oldValue = Convert.ToInt32(dGVOrders.SelectedRows[0].Cells[3].Value);
        }

        private void DGVOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int newValue;
            if (int.TryParse(dGVOrders.SelectedRows[0].Cells[3].Value.ToString(), out newValue))
            {
                for (int i = 0; i < listCTHD.Count; i++)
                {
                    if (listCTHD[i].MAHANG == maHang)
                    {
                        listCTHD[i].SOLUONG = newValue;
                    }    
                }    
            }    
        }

        private void OderUser_Load(object sender, EventArgs e)
        {
            dGVSearch.DataSource = controller.Load_On(UKEY);
            dGVSearch.ReadOnly = true;                      //Set datagridview chỉ được đọc
            dGVSearch.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;    //khi click vào ô bất kì thì hàng đó sẽ được chọn
            dGVOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVOrders.ReadOnly = true;
        }

        void setAccessButton(bool check)
        {
            btMain.Enabled = check;
            btCreateOrder.Enabled = check;
            btEdit.Enabled = check;
            btSave.Enabled = check;
            btCancel.Enabled = !check;
            btDelete.Enabled = !check;
            btPrint.Enabled = check;
        }

        void setButtonHide()
        {
            setAccessButton(true);
            btCreateOrder.Hide();
            btEdit.Hide();
            btSave.Hide();
            btCancel.Hide();
            btDelete.Hide();
            btPrint.Hide();
        }

        int i = 0;
        private void buttonMain_Click(object sender, EventArgs e)
        {
            if (isClickedButtonMain)
            {
                toolTip.SetToolTip(btMain, "Click to SHOW list button.");
                setButtonHide();
                isClickedButtonMain = false;
            } 
            else
            {
                buttonTimer.Start();
                toolTip.SetToolTip(btMain, "Click to HIDE list button.");
                isClickedButtonMain = true;
            }    
        }

        private void buttonTimer_Tick(object sender, EventArgs e)
        {
            i++;
            switch(i)
            {
                case 1:
                    btCreateOrder.Show(); break;
                case 2:
                    btSave.Show(); break;
                case 3:
                    btPrint.Show(); break;
                case 4:
                    btEdit.Show(); break;
                case 5:
                    btDelete.Show(); break;
                case 6:
                    btCancel.Show(); break;
                default:
                    break;
            }
            if (i == 6)
            {
                i = 0;
                buttonTimer.Stop();
            }
        }

        private void dGVSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dGVSearch.SelectedRows[0].Index;
            string[] donGia = dGVSearch.Rows[n].Cells["DONGIA"].Value.ToString().Split('.');
            tBMaHang.Text = dGVSearch.Rows[n].Cells["MAHANG"].Value.ToString();
            tBTenHang.Text = dGVSearch.Rows[n].Cells["TENHANG"].Value.ToString();
            tBDonGia.Text = donGia[0];
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            setAccessButton(false);
            dGVOrders.ReadOnly = false;
            dGVOrders.Columns[0].ReadOnly = true;
            dGVOrders.Columns[1].ReadOnly = true;
            dGVOrders.Columns[2].ReadOnly = true;
            isClickedButtonEdit = true;
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            setAccessButton(true);
            dGVOrders.ReadOnly = true;
            btMain.Enabled = false;
            btCreateOrder.Enabled = false;
            isClickedButtonEdit = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!isNewOrder)
            {
                MessageBox.Show("Vui lòng tạo hóa đơn mới.", "Thông báo");
                return;
            }
            if (tBMaHang.Text == "" || tBTenHang.Text == "" || tBDonGia.Text == "" || tBSoLuong.Text == "")
            {
                MessageBox.Show("Có gì đó không đúng!", "Thông báo");
                return;
            }
            else
            {
                if (controller.Check_HangHoa(tBMaHang.Text, tBTenHang.Text, 
                    Convert.ToInt32(controller.splitPoint(tBDonGia.Text)), UKEY) == false)
                {
                    MessageBox.Show("Thông tin hàng hóa sai.", "Thông báo");
                    tBMaHang.Text = "";
                    tBTenHang.Text = "";
                    tBDonGia.Text = "";
                    tBSoLuong.Text = "";
                }    
                else if (!controller.Check_SoLuong_HangHoa(listCTHD, tBMaHang.Text, UKEY, Convert.ToInt32(tBSoLuong.Text)))
                {
                    MessageBox.Show("Số lượng hàng hóa yêu cầu lớn hơn số lượng hàng hóa có sẵn." +
                                "\nVui lòng điều chỉnh số lượng hàng hóa lại.", "Thông báo");
                    tBSoLuong.Text = "";
                }
                else
                {
                    if (!controller.Check_SOLUONG(listCTHD, tBMaHang.Text, Convert.ToInt32(tBSoLuong.Text)))
                    {
                        listCTHD.Add(new CTHD
                        {
                            MAHANG = tBMaHang.Text,
                            TENHANG = tBTenHang.Text,
                            DONGIA = Convert.ToInt32(tBDonGia.Text),
                            SOLUONG = Convert.ToInt32(tBSoLuong.Text)
                        });
                    }    

                    var CTHDList = new BindingList<CTHD>(listCTHD); // <-- BindingList
                    dGVOrders.DataSource = CTHDList;
                    dGVOrders.Columns["TENHANG"].Visible = false;
                    dGVOrders.Columns["NGNHAP"].Visible = false;

                    labelThanhTien.Text = controller.Sum_DONGIA(listCTHD).ToString(); 
                }    
            }    
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!isNewOrder)
            {
                MessageBox.Show("Vui lòng tạo hóa đơn mới.", "Thông báo");
                return;
            }
            int MAHD = controller.Get_MAHOADON();
            if (saveStatus == 0)
            {
                controller.Delete_CTHD(MAHD, UKEY);

                for (int i = 0; i < listCTHD.Count; i++)
                {
                    if (!controller.Add_CTHD(MAHD, listCTHD[i].MAHANG, listCTHD[i].SOLUONG, listCTHD[i].DONGIA, UKEY))
                    {
                        MessageBox.Show("Có gì đó không đúng!", "Thông báo");
                        return;
                    }
                    controller.Update_SoLuong_HangHoa(listCTHD[i].MAHANG, UKEY, listCTHD[i].SOLUONG, '-');
                }
                dGVSearch.DataSource = controller.Load_On(UKEY);

                MessageBox.Show("Mã hóa đơn: " + MAHD + "\nĐã lưu chi tiết hóa đơn thành công.", "Thông báo");
                
                btMain.Enabled = true;
                btCreateOrder.Enabled = true;
                tBDoiTac.ReadOnly = false;
            }    
            else if (saveStatus == 1)
            {
                List<CTHD> oldCTHDs = controller.GetCTHDs(MAHD, UKEY);
                for (int i = 0; i < oldCTHDs.Count; i++)
                {
                    controller.Update_SoLuong_HangHoa(oldCTHDs[i].MAHANG, UKEY, oldCTHDs[i].SOLUONG, '+');
                }
                controller.Delete_CTHD(MAHD, UKEY);
                for (int i = 0; i < listCTHD.Count; i++)
                {
                    if (!controller.Add_CTHD(MAHD, listCTHD[i].MAHANG, listCTHD[i].SOLUONG, listCTHD[i].DONGIA, UKEY))
                    {
                        MessageBox.Show("Có gì đó không đúng!", "Thông báo");
                        return;
                    }
                    controller.Update_SoLuong_HangHoa(listCTHD[i].MAHANG, UKEY, listCTHD[i].SOLUONG, '-');
                }
                dGVSearch.DataSource = controller.Load_On(UKEY);

                MessageBox.Show("Mã hóa đơn: " + MAHD + "\nĐã lưu chi tiết hóa đơn thành công.", "Thông báo");
            }
            saveStatus = 1;
            btMain.Enabled = true;
            btCreateOrder.Enabled = true;
            tBDoiTac.ReadOnly = false;
        }


        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            if (tBSearch.Text == "" && isSearched == true)
            {
                dGVSearch.DataSource = controller.Load_On(UKEY);
                isSearched = false;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (cBSelect.Text == "Mã Hàng")
                dGVSearch.DataSource = controller.Load_MA(tBSearch.Text, UKEY); // Load các hàng hóa có mã trùng nhau ( nhưng chắc là 1 cái thôi )
            if (cBSelect.Text == "Tên Hàng")
                dGVSearch.DataSource = controller.Load_TENHANG(tBSearch.Text, UKEY); // Load các hàng hóa có  tên trung nhau một phần nào đó
            if (cBSelect.Text == "Ngày Nhập")
                dGVSearch.DataSource = controller.Load_NGAYNHAP(tBSearch.Text, UKEY); // Load các hàng hóa có  tên trung nhau một phần nào đó
            isSearched = true;
        }

        private bool check_Wrong(string tenDoiTac, DateTime thoiGian)
        {
            if (tBDoiTac.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đối tác.", "Thông báo");
                return false;
            }
            else if (dTPTime.Value.Day < DateTime.Now.Day
                && dTPTime.Value.Month < DateTime.Now.Month
                && dTPTime.Value.Year < DateTime.Now.Year)
            {
                MessageBox.Show("Thời gian không đúng.", "Thông báo");
                return false;
            }
            else
                return true;
        }

        private void btCreateOrder_Click(object sender, EventArgs e)
        {
            saveStatus = 0;

            listCTHD.Clear();
            dGVOrders.Rows.Clear();
            labelThanhTien.Text = "00000000.";
            if (!check_Wrong(tBDoiTac.Text, dTPTime.Value))
            {
                return;
            }
            else
            {
                if (controller.Add_Order(tBDoiTac.Text, dTPTime.Value, UKEY))
                {
                    MessageBox.Show("Tạo hóa đơn mới thành công.", "Thông báo");
                    btMain.Enabled = false;
                    btCreateOrder.Enabled = false;
                    tBDoiTac.ReadOnly = true;
                }
            }
            isNewOrder = true;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int n = dGVOrders.SelectedRows[0].Index;    //lấy giá trị hàng đã chọn
            for (int i = 0; i < listCTHD.Count; i++)
            {
                if (listCTHD[i].MAHANG == dGVOrders.Rows[n].Cells[0].Value.ToString())
                {
                    listCTHD.RemoveAt(i);
                    MessageBox.Show("Đã xóa thành công.");
                }
            }
            var CTHDList = new BindingList<CTHD>(listCTHD); // <-- BindingList
            dGVOrders.DataSource = CTHDList;
            dGVOrders.Columns["TENHANG"].Visible = false;
            dGVOrders.Columns["NGNHAP"].Visible = false;
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