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
    public partial class OrderUser : UserControl
    {
        OrderPage_Controller controller = new OrderPage_Controller();
        public int UKEY;
        public int saveStatus = 0;
        int Position;
        public bool isSearched = false;
        bool isClickedButtonMain = false;
        bool isNewOrder = false;
        bool isHistory = false;
        List<CTHD> listCTHD = new List<CTHD>();
        ToolTip toolTip = new ToolTip();
        public OrderUser(int ukey, int Pos)
        {
            InitializeComponent();
            setButtonHide();
            cBSelect.SelectedIndex = 0;
            UKEY = ukey;
            Position = Pos;

            toolTip.SetToolTip(BtMain, "Click to show list button.");
            toolTip.SetToolTip(BtCreateOrder, "NEW ORDER\nClick to create new order.");
            toolTip.SetToolTip(BtEdit, "EDIT\nClick to edit order.");
            toolTip.SetToolTip(BtSave, "SAVE\nClick to save ORDER.");
            toolTip.SetToolTip(BtCancel, "CANCEL\nClick to exit edit mode.");
            toolTip.SetToolTip(BtDelete, "DELETE\nClick to delete row in order.");
            toolTip.SetToolTip(BtPrint, "PRINT\nClick to print order.");

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
            if (!isNewOrder)
            {
                BtAdd.Click += new EventHandler(buttonMain_Click);
            }
        }

        void setAccessButton(bool Main, bool COrder, bool Edit, bool Save, bool Cancel, bool Del, bool Print)
        {
            BtMain.Enabled = Main;
            BtCreateOrder.Enabled = COrder;
            BtEdit.Enabled = Edit;
            BtSave.Enabled = Save;
            BtCancel.Enabled = Cancel;
            BtDelete.Enabled = Del;
            BtPrint.Enabled = Print;
        }

        void setButtonHide()
        {
            setAccessButton(true, true, true, true, false, false, true);
            BtCreateOrder.Hide();
            BtEdit.Hide();
            BtSave.Hide();
            BtCancel.Hide();
            BtDelete.Hide();
            BtPrint.Hide();
        }

        int i = 0;
        private void buttonMain_Click(object sender, EventArgs e)
        {

            #region đổi icon Main từ "v" thành  ">" khi click
            if (this.BtMain.IconChar == FontAwesome.Sharp.IconChar.AngleRight)
            {
                this.BtMain.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            }
            else this.BtMain.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            #endregion 
            if (isClickedButtonMain)
            {
                toolTip.SetToolTip(BtMain, "Click to SHOW list button.");
                setButtonHide();
                isClickedButtonMain = false;
            } 
            else
            {
                buttonTimer.Start();
                toolTip.SetToolTip(BtMain, "Click to HIDE list button.");
                if (isHistory == true)
                {
                    setAccessButton(true, false, false, false, true, false, true);
                }    
                isClickedButtonMain = true;
            }    
        }

        private void buttonTimer_Tick(object sender, EventArgs e)
        {
            i++;
            switch(i)
            {
                case 1:
                    BtCreateOrder.Show();
                    break;
                case 2:
                    BtSave.Show(); break;
                case 3:
                    BtPrint.Show(); break;
                case 4:
                    BtEdit.Show(); break;
                case 5:
                    BtDelete.Show(); break;
                case 6:
                    BtCancel.Show(); break;
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
            setAccessButton(false, false, false, true, true, true, false);
            dGVOrders.ReadOnly = false;
            dGVOrders.Columns[0].ReadOnly = true;
            dGVOrders.Columns[1].ReadOnly = true;
            dGVOrders.Columns[2].ReadOnly = true;
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            setAccessButton(true, true, true, true, false, false, true);
            dGVOrders.ReadOnly = true;
            isHistory = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!isNewOrder)
            {
                MessageBox.Show("Vui lòng tạo hóa đơn mới.", "Thông báo");
                BtAdd.Click -= new EventHandler(buttonMain_Click);
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

                    labelThanhTien.Text = controller.Sum_DONGIA(listCTHD).ToString(); //Trị giá
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
            if (saveStatus == 0)    //Tạo hóa đơn mới và save lần đầu tiên
            {
                //Xóa tất cả CTHD có MAHD hiện tại trong database
                controller.Delete_CTHD(MAHD, UKEY);

                for (int i = 0; i < listCTHD.Count; i++)
                {
                    //Check nếu CTHD nào có Số Lượng = 0 thì xóa khỏi List
                    if (listCTHD[i].SOLUONG == 0)
                    {
                        listCTHD.RemoveAt(i);
                        continue;
                    }
                    //Thêm CTHD vào database
                    if (!controller.Add_CTHD(MAHD, listCTHD[i].MAHANG, listCTHD[i].SOLUONG, UKEY))
                    {
                        MessageBox.Show("Có gì đó không đúng!", "Thông báo");
                        return;
                    }
                    controller.Update_Order(MAHD, labelThanhTien.Text);
                    //Trừ đi số lượng hàng hóa trong kho hàng
                    controller.Update_SoLuong_HangHoa(listCTHD[i].MAHANG, UKEY, listCTHD[i].SOLUONG, '-');
                }

                dGVSearch.DataSource = controller.Load_On(UKEY);
                
                MessageBox.Show("Mã hóa đơn: " + MAHD + "\nĐã lưu chi tiết hóa đơn thành công.", "Thông báo");
                
                BtMain.Enabled = true;
                BtCreateOrder.Enabled = true;
                tBDoiTac.ReadOnly = false;
            }    
            else if (saveStatus == 1)   //Save lần thứ 2 trở đi
            {
                List<CTHD> oldCTHDs = controller.GetCTHDs(MAHD, UKEY);
                for (int i = 0; i < oldCTHDs.Count; i++)
                {
                    //Lấy số lượng hàng hóa đã lấy trong CTHD cũ trả lại cho Kho
                    controller.Update_SoLuong_HangHoa(oldCTHDs[i].MAHANG, UKEY, oldCTHDs[i].SOLUONG, '+');
                }

                //Xóa tất cả CTHD có MAHD hiện tại trong database
                controller.Delete_CTHD(MAHD, UKEY);

                for (int i = 0; i < listCTHD.Count; i++)
                {
                    //Check nếu CTHD mới nào có Số Lượng = 0 thì xóa khỏi List
                    if (listCTHD[i].SOLUONG == 0)
                    {
                        listCTHD.RemoveAt(i);
                        continue;
                    }

                    //Thêm CTHD mới vào database
                    if (!controller.Add_CTHD(MAHD, listCTHD[i].MAHANG, listCTHD[i].SOLUONG, UKEY))
                    {
                        MessageBox.Show("Có gì đó không đúng!", "Thông báo");
                        return;
                    }
                    controller.Update_Order(MAHD, labelThanhTien.Text);
                    //Trừ đi số lượng hàng hóa trong kho hàng
                    controller.Update_SoLuong_HangHoa(listCTHD[i].MAHANG, UKEY, listCTHD[i].SOLUONG, '-');
                }
                dGVSearch.DataSource = controller.Load_On(UKEY);
                
                MessageBox.Show("Mã hóa đơn: " + MAHD + "\nĐã lưu chi tiết hóa đơn thành công.", "Thông báo");
            }
            var CTHDList = new BindingList<CTHD>(listCTHD); // <-- BindingList
            dGVOrders.DataSource = CTHDList;
            saveStatus = 1;
            BtMain.Enabled = true;
            BtCreateOrder.Enabled = true;
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
                    BtAdd.Click -= new EventHandler(buttonMain_Click);
                    MessageBox.Show("Tạo hóa đơn mới thành công.", "Thông báo");
                    BtMain.Enabled = false;
                    BtCreateOrder.Enabled = false;
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

        private void BtHistory_Click(object sender, EventArgs e)
        {
            FHistory f = new FHistory(UKEY, Position, 1);
            f.ShowDialog();
            listCTHD = f.getCTHDDefine();
            if (listCTHD != null)
            {
                var CTHDList = new BindingList<CTHD>(listCTHD); // <-- BindingList
                dGVOrders.DataSource = CTHDList;
                dGVOrders.Columns["TENHANG"].Visible = false;
                dGVOrders.Columns["NGNHAP"].Visible = false;
                tBDoiTac.Text = f.getTenDoiTac();
                labelThanhTien.Text = f.getGiaTri();
                setAccessButton(true, false, false, false, true, false, true);
                isHistory = true;
            }    
            else
            {
                listCTHD = new List<CTHD>();
            }    
            this.Show();
        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            dGVSearch.DataSource = controller.Load_Search(cBSelect.Text, tBSearch.Text, UKEY, Position);
            isSearched = true;
        }
    }
}