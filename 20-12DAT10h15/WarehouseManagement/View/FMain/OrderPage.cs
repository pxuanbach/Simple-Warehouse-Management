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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace WarehouseManagement
{
    public partial class OrderUser : UserControl
    {
        OrderPage_Controller controller = new OrderPage_Controller();
        public int UKEY;
        bool isSaved = false;
        int Position;
        bool isSearched = false;
        bool isHistory = false;
        bool isNewOrder = true;
        List<CTHD> listCTHD = new List<CTHD>();
        ToolTip toolTip = new ToolTip();

        //Position = 0 tương đương ADMIN, = 1 là quản lý, = 2 là nhân viên
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
            toolTip.SetToolTip(BtDelete, "DELETE\nClick to delete row in order.");
            toolTip.SetToolTip(BtPrint, "PRINT\nClick to print order.");

            tBDonGia.KeyPress += textBox_KeyPress;
            tBSoLuong.KeyPress += textBox_KeyPress;

            dGVSearch.CellMouseClick += DGVSearch_CellMouseClick;

            dGVOrders.CellBeginEdit += DGVOrders_CellBeginEdit;
            dGVOrders.CellValueChanged += DGVOrders_CellValueChanged;

            tBDoiTac.ForeColor = Color.Gray;
            tBDoiTac.Text = "Nhập tên đối tác cho hóa đơn";
            tBDoiTac.Leave += TBDoiTac_Leave;
            tBDoiTac.Enter += TBDoiTac_Enter;

        }

        #region Các hàm hỗ trợ
        void ClickCell_dGV()
        {
            if (dGVSearch.SelectedRows.Count > 0)
            {
                int n = dGVSearch.SelectedRows[0].Index;
                string[] donGia = dGVSearch.Rows[n].Cells["DONGIA"].Value.ToString().Split('.');
                tBMaHang.Text = dGVSearch.Rows[n].Cells["MAHANG"].Value.ToString();
                tBTenHang.Text = dGVSearch.Rows[n].Cells["TENHANG"].Value.ToString();
                tBDonGia.Text = donGia[0];
            }    
        }

        void setAccessButton(bool Main, bool COrder, bool Edit, bool Save, bool Del, bool Print)
        {
            BtMain.Enabled = Main;
            BtCreateOrder.Enabled = COrder;
            BtEdit.Enabled = Edit;
            BtSave.Enabled = Save;
            BtDelete.Enabled = Del;
            BtPrint.Enabled = Print;
        }

        void setButtonHide()
        {
            BtCreateOrder.Hide();
            BtEdit.Hide();
            BtSave.Hide();
            BtDelete.Hide();
            BtPrint.Hide();
        }

        bool check_Wrong(string tenDoiTac, DateTime thoiGian)
        {
            DateTime d1 = new DateTime(dTPTime.Value.Year, dTPTime.Value.Month, dTPTime.Value.Day);
            DateTime d2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (tBDoiTac.Text == "" || tBDoiTac.Text == "Nhập tên đối tác cho hóa đơn")
            {
                MessageBox.Show("Vui lòng nhập tên đối tác.", "Thông báo");
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
        #endregion

        #region Sự kiện Click các button

        private void BtAdd_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Thông tin hàng hóa sai.\nVui lòng chọn hàng hóa có sẵn trong kho!", "Thông báo");
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
                         //Kiểm tra đã tồn tại hàng hóa chưa? Nếu đã tồn tại thì + vào và trả về true, ngược lại false
                    if (!controller.Sum_SOLUONG(listCTHD, tBMaHang.Text, Convert.ToInt32(tBSoLuong.Text)))  
                    {
                        //Hàng hóa mới tạo phần tử mới trong list
                        listCTHD.Add(new CTHD
                        {
                            MAHANG = tBMaHang.Text,
                            TENHANG = tBTenHang.Text,
                            DONGIA = Convert.ToInt32(tBDonGia.Text),
                            SOLUONG = Convert.ToInt32(tBSoLuong.Text)
                        });
                    }

                    if (BtMain.IconChar == FontAwesome.Sharp.IconChar.AngleDown)
                        BtMain.PerformClick();

                    var CTHDList = new BindingList<CTHD>(listCTHD); // <-- BindingList
                    dGVOrders.DataSource = CTHDList;
                    dGVOrders.Columns["NGNHAP"].Visible = false;
                    labelThanhTien.Text = controller.Sum_DONGIA(listCTHD).ToString(); //Trị giá
                }
            }
        }

        int i = 0;
        private void BtMain_Click(object sender, EventArgs e)
        {

            #region đổi icon Main từ "v" thành  ">" khi click
            if (this.BtMain.IconChar == FontAwesome.Sharp.IconChar.AngleRight)  //Đã click rồi
            {
                
                this.BtMain.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
                toolTip.SetToolTip(BtMain, "Click to SHOW list button.");
                setButtonHide();
            }
            else            //Chưa click
            {
                this.BtMain.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
                buttonTimer.Start();
                toolTip.SetToolTip(BtMain, "Click to HIDE list button.");
                if (isHistory == true)
                {
                    setAccessButton(true, false, false, false, false, true);
                }
                else
                {
                    if (isSaved == false)
                    {
                        setAccessButton(true, false, false, true, false, false);
                    }    
                    else
                    {
                        setAccessButton(true, true, true, true, false, true);
                    }    
                }    
            }
            #endregion   
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            if (this.BtEdit.IconChar == FontAwesome.Sharp.IconChar.Edit)
            {
                this.BtEdit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
                setAccessButton(false, false, true, true, true, false);
                dGVOrders.ReadOnly = false;
                dGVOrders.Columns[0].ReadOnly = true;
                dGVOrders.Columns[1].ReadOnly = true;
                dGVOrders.Columns[2].ReadOnly = true;
            }
            else
            {
                labelThanhTien.Text = controller.Sum_DONGIA(listCTHD).ToString(); //Trị giá
                this.BtEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
                setAccessButton(true, true, true, true, false, true);
                dGVOrders.ReadOnly = true;
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if (!check_Wrong(tBDoiTac.Text, dTPTime.Value))
            {
                return;
            }
            else
            {
                if (isNewOrder)
                {
                    if (controller.Add_Order(tBDoiTac.Text, dTPTime.Value, UKEY))
                    {
                        MessageBox.Show("Lưu hóa đơn mới thành công.", "Thông báo");
                        tBDoiTac.ReadOnly = true;
                        dTPTime.Enabled = false;
                        isNewOrder = false;
                    }
                }
            }
            int MAHD = controller.Get_MAHOADON();

            List<CTHD> oldCTHDs = controller.GetCTHDs(MAHD, UKEY);
            if (oldCTHDs != null)
            {
                for (int i = 0; i < oldCTHDs.Count; i++)
                {
                    //Lấy số lượng hàng hóa đã lấy trong CTHD cũ trả lại cho Kho
                    controller.Update_SoLuong_HangHoa(oldCTHDs[i].MAHANG, UKEY, oldCTHDs[i].SOLUONG, '+');
                }
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

                //Update Giá trị cho hóa đơn
                controller.Update_Order(MAHD, labelThanhTien.Text);

                //Trừ đi số lượng hàng hóa trong kho hàng
                controller.Update_SoLuong_HangHoa(listCTHD[i].MAHANG, UKEY, listCTHD[i].SOLUONG, '-');
            }
            //load lại data kho sau khi trừ bớt số lượng
            dGVSearch.DataSource = controller.Load_On(UKEY);
                
            MessageBox.Show("Mã hóa đơn: " + MAHD + "\nĐã lưu chi tiết hóa đơn thành công.", "Thông báo");
            
            var CTHDList = new BindingList<CTHD>(listCTHD); // <-- BindingList
            dGVOrders.DataSource = CTHDList;
            dGVOrders.Columns["NGNHAP"].Visible = false;
            isSaved = true;
        }

        private void BtCreateOrder_Click(object sender, EventArgs e)
        {
            labelThanhTien.Text = "0";
            isSaved = false;
            isNewOrder = true;
            listCTHD.Clear();
            dGVOrders.Rows.Clear();
            tBDoiTac.Text = "Nhập tên đối tác cho hóa đơn";
            tBDoiTac.ForeColor = Color.Gray;
            tBDoiTac.ReadOnly = false;
            dTPTime.Value = DateTime.Now;
            dTPTime.Enabled = true;
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (dGVOrders.SelectedRows.Count > 0)
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
                dGVOrders.Columns["NGNHAP"].Visible = false;
            }
            
        }

        private void BtHistory_Click(object sender, EventArgs e)
        {
            if (isHistory == false)
            {
                FHistory f = new FHistory(UKEY, Position, 1);
                f.ShowDialog();
                listCTHD = f.getCTHDDefine();
                if (listCTHD != null)
                {
                    var CTHDList = new BindingList<CTHD>(listCTHD); // <-- BindingList
                    dGVOrders.DataSource = CTHDList;
                    dGVOrders.Columns["NGNHAP"].Visible = false;
                    tBDoiTac.ForeColor = Color.Black;
                    tBDoiTac.Text = f.getTenDoiTac();
                    tBDoiTac.ReadOnly = true;
                    dTPTime.Value = f.getThoiGian();
                    dTPTime.Enabled = false;
                    labelThanhTien.Text = f.getGiaTri();
                    isHistory = true;
                    BtHistory.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
                    BtHistory.Text = "Quay lại";
                    setAccessButton(true, false, false, false, false, true);
                }
                else
                {
                    listCTHD = new List<CTHD>();
                }
                this.Show();
            }
            else
            {
                BtHistory.IconChar = FontAwesome.Sharp.IconChar.History;
                BtHistory.Text = "Lịch sử";
                isHistory = false;
                listCTHD.Clear();
                dGVOrders.Rows.Clear();
                tBDoiTac.Text = "Nhập tên đối tác cho hóa đơn";
                tBDoiTac.ForeColor = Color.Gray;
                tBDoiTac.ReadOnly = false;
                dTPTime.Value = DateTime.Now;
                dTPTime.Enabled = true;
                labelThanhTien.Text = "0";
                setAccessButton(true, false, true, true, false, false);
            }

        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            if (tBSearch.Text != "")
            {
                dGVSearch.DataSource = controller.Load_Search(cBSelect.Text, tBSearch.Text, UKEY, Position);
                isSearched = true;
            }    
        }

        private void BtPrint_Click(object sender, EventArgs e)
        {
            if (dGVOrders.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "hoadon.pdf";
                bool fileError = false;
                //Full path to the Unicode Arial file
                string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "tahoma.ttf");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //Create a specific font object
                iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dGVOrders.Columns.Count-1);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Thêm tên cột
                            foreach (DataGridViewColumn column in dGVOrders.Columns)
                            {
                                if (column.Name != "NGNHAP")
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, f));
                                    pdfTable.AddCell(cell);
                                }
                            
                            }
                            // Thêm dữ liệu trong từng cột
                            foreach (DataGridViewRow row in dGVOrders.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.ColumnIndex != 4)
                                    {
                                        if (cell.Value == null)
                                        {
                                            pdfTable.AddCell(new Phrase("", f));
                                        }
                                        else
                                            pdfTable.AddCell(new Phrase(cell.Value.ToString(), f));
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A5, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                // Thêm Tiêu đề
                                PdfPTable pdfTableTitle = new PdfPTable(2);
                                pdfTableTitle.AddCell(new Phrase("BDT Comany\n" + "ĐT: 080600060-Fax:301.302.303\n", f));
                                pdfTableTitle.AddCell(new Phrase("HÓA ĐƠN BÁN HÀNG\n", f));
                                pdfDoc.Add(pdfTableTitle);
                                pdfDoc.Add(new Phrase("Người mua hàng: " + tBDoiTac.Text + '\n' + '\n', f));                               
                                // Phần thân
                                pdfDoc.Add(pdfTable);
                                string Money = labelThanhTien.Text;
                                string []tien = Money.Split('.'); 
                                pdfDoc.Add(new Phrase("Tổng cộng hàng: " + tien[0] + "VNĐ", f));
                                // Chữ ký 
                                PdfPTable pdfTableTitle2 = new PdfPTable(2);
                                pdfTableTitle2.TotalWidth = 460f;
                                pdfTableTitle2.LockedWidth = true;
                                PdfPCell cell = new PdfPCell(new Phrase("NGƯỜI MUA HÀNG\n\n" + "(Ký ghi rõ họ tên)\n" + '\n' + '\n' + '\n' + '\n', f));
                                cell.HorizontalAlignment = 1;
                                pdfTableTitle2.AddCell(cell);
                                PdfPCell cell2 = new PdfPCell(new Phrase("Ngày " + DateTime.Now.Day.ToString() +
                                                                    " Tháng " + DateTime.Now.Month.ToString() +
                                                                    " Năm " + DateTime.Now.Year.ToString() + '\n'+'\n' 
                                                                    + "NGƯỜI VIẾT HÓA ĐƠN\n" + '\n' + '\n' + '\n' + '\n', f));
                                cell2.HorizontalAlignment = 1;
                                pdfTableTitle2.AddCell(cell2);
                                pdfDoc.Add(pdfTableTitle2);

                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Dữ liệu Export thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
        }
        #endregion

        #region Các sự kiện khác
        private void DGVSearch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClickCell_dGV();
        }

        private void TBDoiTac_Enter(object sender, EventArgs e)
        {
            if (tBDoiTac.Text == "Nhập tên đối tác cho hóa đơn")
            {
                tBDoiTac.Text = "";
                tBDoiTac.ForeColor = Color.Black;
            }
        }

        private void TBDoiTac_Leave(object sender, EventArgs e)
        {
            if (tBDoiTac.Text == "")
            {
                tBDoiTac.Text = "Nhập tên đối tác cho hóa đơn";
                tBDoiTac.ForeColor = Color.Gray;
            }
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

        private void dGVSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickCell_dGV();
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

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            if (tBSearch.Text == "" && isSearched == true)
            {
                dGVSearch.DataSource = controller.Load_On(UKEY);
                isSearched = false;
            }
        }

        private void buttonTimer_Tick(object sender, EventArgs e)
        {
            i++;
            switch (i)
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
                default:
                    break;
            }
            if (i == 6)
            {
                i = 0;
                buttonTimer.Stop();
            }
        }
        #endregion
    }
}