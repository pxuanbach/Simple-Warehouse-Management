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
using System.Globalization;

namespace WarehouseManagement
{
    public partial class OrderUser : UserControl
    {
        OrderPage_Controller controller = new OrderPage_Controller();
        int UKEY;
        bool isSaved = false;
        int Position;
        bool isSearched = false;
        bool isHistory = false;
        bool isNewOrder = true;
        HoaDon hoaDon = new HoaDon();
        List<CTHD> listCTHDs = new List<CTHD>();

        ToolTip toolTip = new ToolTip();

        //Position = 0 tương đương ADMIN, = 1 là quản lý, = 2 là nhân viên
        public OrderUser(int ukey, int Pos)
        {
            InitializeComponent();
            setButtonHide();
            cBSearch.SelectedIndex = 0;
            UKEY = ukey;
            Position = Pos;
            hoaDon.ListCTHD = new List<CTHD>();

            //Thêm tooltip cho các button
            toolTip.SetToolTip(BtMain, "Nhấn vào để hiện danh sách nút thao tác hóa đơn.");
            toolTip.SetToolTip(BtCreateOrder, "HÓA ĐƠN MỚI\nNhấn để tạo hóa đơn mới.");
            toolTip.SetToolTip(BtEdit, "SỬA\nNhấn để sửa chi tiết hóa đơn.");
            toolTip.SetToolTip(BtSave, "LƯU\nNhấn để lưu hóa đơn hiện tại.");
            toolTip.SetToolTip(BtDelete, "XÓA\nNhấn để xóa hóa đơn hiện tại.");
            toolTip.SetToolTip(BtPrint, "IN\nNhấn để in hóa đơn.");

            //Bắt các sự kiện cần thiết
            tBDonGia.KeyPress += textBox_KeyPress;
            tBSoLuong.KeyPress += textBox_KeyPress;
            tBSearch.KeyPress += TextBoxSearch_KeyPress;
            tBSearch.KeyDown += TextBoxSearch_KeyDown;
            dGVSearch.CellMouseClick += DGVSearch_CellMouseClick;
            
            tBDoiTac.Text = "Nhập tên đối tác cho hóa đơn";
            tBDoiTac.ForeColor = Color.Gray;
            tBDoiTac.Leave += TBDoiTac_Leave;
            tBDoiTac.Enter += TBDoiTac_Enter;
            tBLienHe.Text = "Nhập số điện thoại hoặc địa chỉ của đối tác";
            tBLienHe.ForeColor = Color.Gray;
            tBLienHe.Leave += TBLienHe_Leave;
            tBLienHe.Enter += TBLienHe_Enter; ;
            dGVOrders.KeyPress += textBox_KeyPress;
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
        #endregion

        #region Sự kiện Click các button

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (isHistory == true)
            {
                MessageBox.Show("Không thể thêm hàng vào hóa đơn cũ.", "Thông báo");
                return;
            }
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
                else if (!controller.Check_SoLuong_HangHoa(hoaDon.ListCTHD, tBMaHang.Text, UKEY, Convert.ToInt32(tBSoLuong.Text), Position))
                {
                    MessageBox.Show("Số lượng hàng hóa yêu cầu lớn hơn số lượng hàng hóa có sẵn." +
                                "\nVui lòng điều chỉnh số lượng hàng hóa lại.", "Thông báo");
                    tBSoLuong.Text = "";
                }
                else
                {
                         //Kiểm tra đã tồn tại hàng hóa chưa? Nếu đã tồn tại thì + vào và trả về true, ngược lại false
                    if (!controller.Sum_SOLUONG(hoaDon.ListCTHD, tBMaHang.Text, Convert.ToInt32(tBSoLuong.Text)))  
                    {
                        //Hàng hóa mới tạo phần tử mới trong list
                        hoaDon.ListCTHD.Add(new CTHD
                        {
                            MAHANG = tBMaHang.Text,
                            TENHANG = tBTenHang.Text,
                            DONGIA = Convert.ToInt32(tBDonGia.Text),
                            SOLUONG = Convert.ToInt32(tBSoLuong.Text)
                        });
                    }

                    if (BtMain.IconChar == FontAwesome.Sharp.IconChar.AngleDown)
                        BtMain.PerformClick();
                    var ListBinding = new BindingList<CTHD>(hoaDon.ListCTHD);
                    dGVOrders.DataSource = ListBinding;
                    dGVOrders.Columns["NGNHAP"].Visible = false;
                    labelThanhTien.Text = controller.Sum_DONGIA(hoaDon.ListCTHD).ToString(); //Trị giá
                    BtPrint.Enabled = false;
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
                toolTip.SetToolTip(BtMain, "Nhấn vào để HIỆN danh sách nút thao tác hóa đơn.");
                setButtonHide();
            }
            else            //Chưa click
            {
                this.BtMain.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
                buttonTimer.Start();
                toolTip.SetToolTip(BtMain, "Nhấn vào để ẨN danh sách nút thao tác hóa đơn.");
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
                        setAccessButton(true, true, true, true, true, true);
                    }    
                }    
            }
            #endregion   
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            //load page Edit của hóa đơn
            FOrderPageEdit fope = new FOrderPageEdit(UKEY, Position);
            fope.getValue(hoaDon);
            DialogResult result = fope.ShowDialog();
            if (result == DialogResult.OK)  //Lưu tất cả
            {
                hoaDon = fope.returnHoaDon();
                if (hoaDon.ListCTHD != null)    //Nếu List chi tiết hóa đơn không rỗng
                {   
                    var ListBinding = new BindingList<CTHD>(hoaDon.ListCTHD);
                    dGVOrders.DataSource = ListBinding;
                    dGVOrders.Columns["NGNHAP"].Visible = false;
                    labelMaDon.Text = Convert.ToString(hoaDon.MaHD);

                    labelThanhTien.Text = hoaDon.GiaTri;
                    //Update vào database giá của hóa đơn
                    controller.Update_Order(hoaDon.MaHD, labelThanhTien.Text, "TRIGIA");
                }
                else           //Nếu List chi tiết hóa đơn rỗng
                {
                    dGVOrders.Rows.Clear();
                    labelThanhTien.Text = "0";
                    controller.Update_Order(hoaDon.MaHD, labelThanhTien.Text, "TRIGIA");
                }

                tBDoiTac.Text = hoaDon.TenDoiTac;
                //Update vào database tên đối tác của hóa đơn
                controller.Update_Order(hoaDon.MaHD, "N'" + tBDoiTac.Text + "'", "TENDOITAC");

                tBLienHe.Text = hoaDon.LienHe;
                //Update vào database liên hệ của hóa đơn
                controller.Update_Order(hoaDon.MaHD, "N'" + tBLienHe.Text + "'", "LIENHE");

                dTPTime.Value = hoaDon.ThoiGian;
                //Update vào database thời gian tạo của hóa đơn
                controller.Update_Order(hoaDon.MaHD, "'" + hoaDon.ThoiGian.ToString("yyyy/MM/dd") + "'", "THOIGIAN");
                //click button Save để lưu list chi tiết hóa đơn vào database
                BtSave.PerformClick();
            }
            else
            {
                hoaDon.ListCTHD = controller.GetCTHDs(hoaDon.MaHD);
                var ListBinding = new BindingList<CTHD>(hoaDon.ListCTHD);
                dGVOrders.DataSource = ListBinding;
                dGVOrders.Columns["NGNHAP"].Visible = false;
                labelThanhTien.Text = controller.Sum_DONGIA(hoaDon.ListCTHD).ToString();
            }    
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if (!check_Wrong(tBDoiTac.Text, tBLienHe.Text, dTPTime.Value))
            {
                return;
            }
            else
            {
                if (isNewOrder)
                {
                    if (hoaDon.ListCTHD == null)
                    {
                        MessageBox.Show("Hóa đơn trống!", "Thông báo");
                        return;

                    }    
                    int n = controller.Add_Order(tBDoiTac.Text, tBLienHe.Text, dTPTime.Value, UKEY);
                    if (n != 0)
                    {
                        MessageBox.Show("Lưu hóa đơn mới thành công.", "Thông báo");
                        labelMaDon.Text = n.ToString();
                        //Đối tượng hóa đơn
                        hoaDon.MaHD = n;
                        hoaDon.TenDoiTac = tBDoiTac.Text;
                        hoaDon.LienHe = tBLienHe.Text;
                        hoaDon.ThoiGian = dTPTime.Value;
                        //UI
                        tBDoiTac.ReadOnly = true;
                        tBLienHe.ReadOnly = true;
                        dTPTime.Enabled = false;
                        isNewOrder = false;
                    }
                }
            }

            List<CTHD> oldCTHDs = controller.GetCTHDs(hoaDon.MaHD);
            if (oldCTHDs != null)
            {
                for (int i = 0; i < oldCTHDs.Count; i++)
                {
                    //Lấy số lượng hàng hóa đã lấy trong CTHD cũ trả lại cho Kho
                    controller.Update_SoLuong_HangHoa(oldCTHDs[i].MAHANG, oldCTHDs[i].SOLUONG, '+');
                }
            }    

            //Xóa tất cả CTHD có MAHD hiện tại trong database
            controller.Delete_CTHD(hoaDon.MaHD);

            for (int i = 0; i < hoaDon.ListCTHD.Count; i++)
            {
                //Check nếu CTHD mới nào có Số Lượng = 0 thì xóa khỏi List
                if (hoaDon.ListCTHD[i].SOLUONG == 0)
                {
                    hoaDon.ListCTHD.RemoveAt(i);
                    continue;
                }

                //Thêm CTHD mới vào database
                if (!controller.Add_CTHD(hoaDon.MaHD, hoaDon.ListCTHD[i].MAHANG, hoaDon.ListCTHD[i].SOLUONG))
                {
                    MessageBox.Show("Có gì đó không đúng!", "Thông báo");
                    return;
                }

                //Update Giá trị cho hóa đơn
                controller.Update_Order(hoaDon.MaHD, labelThanhTien.Text, "TRIGIA");
                hoaDon.GiaTri = labelThanhTien.Text;

                //Trừ đi số lượng hàng hóa trong kho hàng
                controller.Update_SoLuong_HangHoa(hoaDon.ListCTHD[i].MAHANG, hoaDon.ListCTHD[i].SOLUONG, '-');
                    
            }
            //load lại data kho sau khi trừ bớt số lượng
            dGVSearch.DataSource = controller.Load_On(UKEY, Position);
                
            MessageBox.Show("Mã hóa đơn: " + hoaDon.MaHD + "\nĐã lưu chi tiết hóa đơn thành công.", "Thông báo");
            
            var CTHDList = new BindingList<CTHD>(hoaDon.ListCTHD); // <-- BindingList
            dGVOrders.DataSource = CTHDList;
            dGVOrders.Columns["NGNHAP"].Visible = false;
            hoaDon.MaNguoiThem = UKEY;
            hoaDon.TenNguoiThem = controller.getName(UKEY);
            isSaved = true;
            setAccessButton(true, true, true, true, true, true);
            BtDelete.Click += new EventHandler(BtCreateOrder_Click);
        }

        private void BtCreateOrder_Click(object sender, EventArgs e)
        {
            
            isSaved = false;
            isNewOrder = true;
            hoaDon.ListCTHD.Clear();
            dGVOrders.Rows.Clear();

            labelThanhTien.Text = "0";
            labelMaDon.Text = "";

            tBDoiTac.Text = "Nhập tên đối tác cho hóa đơn";
            tBDoiTac.ForeColor = Color.Gray;
            tBDoiTac.ReadOnly = false;

            tBLienHe.Text = "Nhập số điện thoại hoặc địa chỉ của đối tác";
            tBLienHe.ForeColor = Color.Gray;
            tBLienHe.ReadOnly = false;

            dTPTime.Value = DateTime.Now;
            hoaDon.ThoiGian = DateTime.Now.Date;
            dTPTime.Enabled = true;
            setAccessButton(true, false, false, true, false, false);
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            List<CTHD> oldCTHDs = controller.GetCTHDs(hoaDon.MaHD);
            if (oldCTHDs != null)
            {
                for (int i = 0; i < oldCTHDs.Count; i++)
                {
                    //Lấy số lượng hàng hóa đã lấy trong CTHD cũ trả lại cho Kho
                    controller.Update_SoLuong_HangHoa(oldCTHDs[i].MAHANG, oldCTHDs[i].SOLUONG, '+');
                }
            }

            //Xóa tất cả CTHD có MAHD hiện tại trong database
            controller.Delete_CTHD(hoaDon.MaHD);

            if (controller.Delete_HoaDon(hoaDon.MaHD))
            {
                MessageBox.Show("Hóa đơn đã được hủy.", "Thông báo");
                dGVSearch.DataSource = controller.Load_On(UKEY, Position);
            }
            BtDelete.Click -= new EventHandler(BtCreateOrder_Click);
        }

        private void BtHistory_Click(object sender, EventArgs e)
        {
            if (isHistory == false)
            {
                FHistory f = new FHistory(UKEY, Position, 1);
                DialogResult re = f.ShowDialog();
                if (re == DialogResult.OK)  //Xem chi tiết
                {
                    hoaDon = f.getOrder();
                    if (hoaDon.ListCTHD != null)
                    {
                        var CTHDList = new BindingList<CTHD>(hoaDon.ListCTHD); // <-- BindingList
                        dGVOrders.DataSource = CTHDList;
                        dGVOrders.Columns["NGNHAP"].Visible = false;
                        labelMaDon.Text = Convert.ToString(hoaDon.MaHD);

                        tBDoiTac.ForeColor = Color.Black;
                        tBDoiTac.Text = hoaDon.TenDoiTac;
                        tBDoiTac.ReadOnly = true;

                        tBLienHe.ForeColor = Color.Black;
                        tBLienHe.Text = hoaDon.LienHe;
                        tBLienHe.ReadOnly = true;

                        dTPTime.Value = hoaDon.ThoiGian;
                        dTPTime.Enabled = false;

                        labelThanhTien.Text = hoaDon.GiaTri;
                        isHistory = true;
                        isSaved = false;
                        BtHistory.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
                        BtHistory.Text = "Quay lại";
                        setAccessButton(true, false, false, false, false, true);
                        BtHistory.Click += new EventHandler(BtCreateOrder_Click);
                    }
                    else
                    {
                        hoaDon.ListCTHD = new List<CTHD>();
                        hoaDon.ThoiGian = DateTime.Now.Date;
                    }
                }    
                this.Show();
            }
            else
            {
                BtHistory.IconChar = FontAwesome.Sharp.IconChar.History;
                BtHistory.Text = "Lịch sử";
                isHistory = false;
                hoaDon.ThoiGian = DateTime.Now.Date;
                BtHistory.Click -= new EventHandler(BtCreateOrder_Click);
            }

        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            if (tBSearch.Text != "")
            {
                dGVSearch.DataSource = controller.Load_Search(cBSearch.Text, tBSearch.Text, UKEY);
                isSearched = true;
            }    
        }

        private void BtPrint_Click(object sender, EventArgs e)
        {
            if (isSaved == false && isHistory == false)
            {
                return;
            }    
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
                iTextSharp.text.Font fB = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font f1 = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font f2 = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.BOLD);
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
                            PdfPTable pdfTable = new PdfPTable(dGVOrders.Columns.Count - 1);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Thêm tên cột
                            foreach (DataGridViewColumn column in dGVOrders.Columns)
                            {
                                if (column.Name != "NGNHAP")
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, f));
                                    cell.HorizontalAlignment = 1;
                                    cell.BackgroundColor = new iTextSharp.text.BaseColor(223, 244, 242);
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
                                        {
                                            if (cell.ColumnIndex == 2)
                                            {
                                                
                                                string[] value = cell.Value.ToString().Split('.');
                                                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
                                                value[0] = double.Parse(value[0]).ToString("#,###", cul.NumberFormat);
                                                pdfTable.AddCell(new Phrase(value[0], f));
                                            }
                                            else
                                            {
                                                pdfTable.AddCell(new Phrase(cell.Value.ToString(), f));
                                            }
                                        }     
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                Paragraph para3 = new Paragraph("BDTComany", f2);
                                Paragraph para4 = new Paragraph("Địa chỉ: số nhà 123, phường Đông Hòa, thị xã Dĩ An, tỉnh Bình Dương", f);
                                Paragraph para5 = new Paragraph("Điện thoại: 0808008 - 0345678989", f);
                                Paragraph para6 = new Paragraph("Email: BDTComanyUIT@gmail.com", f);
                                Paragraph para7 = new Paragraph("HÓA ĐƠN XUẤT KHO", f1);
                                Paragraph para8 = new Paragraph("* * *", f1);
                                Paragraph para9 = new Paragraph("------------------------------------------------------------", f);
                                // Paragraph para1 = new Paragraph(cbbTableName.Text, f2);
                                Paragraph c1 = new Paragraph();
                                c1.Add(new Chunk("     Mã hóa đơn: " + labelMaDon.Text, f));
                                c1.Add(Chunk.TABBING);
                                c1.Add(Chunk.TABBING);
                                c1.Add(Chunk.TABBING);
                                c1.Add(Chunk.TABBING);
                                c1.Add(new Chunk("Đối tác: " + tBDoiTac.Text + ".", f));
                                
                                Paragraph paraLienHe = new Paragraph("     Liên hệ: " + tBLienHe.Text + ".", f);
                                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
                                string a = double.Parse(labelThanhTien.Text).ToString("#,###", cul.NumberFormat);
                                Paragraph paraThanhTien = new Paragraph("Thành tiền: " + a + "đ", f);

                                Paragraph paraNgViet = new Paragraph();
                                paraNgViet.Add(new Chunk("     Mã người viết: " + hoaDon.MaNguoiThem, f));
                                paraNgViet.Add(Chunk.TABBING);
                                paraNgViet.Add(new Chunk("Tên người viết: " + hoaDon.TenNguoiThem, f));

                                Paragraph paraDateTime = new Paragraph("Ngày " + dTPTime.Value.Day + " tháng " + 
                                                                        dTPTime.Value.Month + " năm " + dTPTime.Value.Year, f);

                                Paragraph paraSign = new Paragraph();
                                paraSign.Add(Chunk.TABBING);
                                paraSign.Add(new Chunk("Người nhận", fB));
                                paraSign.Add(Chunk.TABBING);
                                paraSign.Add(Chunk.TABBING);
                                paraSign.Add(Chunk.TABBING);
                                paraSign.Add(Chunk.TABBING);
                                paraSign.Add(new Chunk("Đã nhận đủ tiền", fB));
                                paraSign.Add(Chunk.TABBING);
                                paraSign.Add(Chunk.TABBING);
                                paraSign.Add(Chunk.TABBING);
                                paraSign.Add(Chunk.TABBING);
                                paraSign.Add(new Chunk("Người viết hóa đơn", fB));

                                para3.Alignment = Element.ALIGN_CENTER;
                                para4.Alignment = Element.ALIGN_CENTER;
                                para5.Alignment = Element.ALIGN_CENTER;
                                para6.Alignment = Element.ALIGN_CENTER;
                                //para1.Alignment = Element.ALIGN_CENTER;
                                para7.Alignment = Element.ALIGN_CENTER;
                                para8.Alignment = Element.ALIGN_CENTER;
                                para9.Alignment = Element.ALIGN_CENTER;
                                //para2.Alignment = Element.ALIGN_LEFT;
                                //para.Alignment = Element.ALIGN_LEFT;
                                paraLienHe.Alignment = Element.ALIGN_LEFT;
                                paraThanhTien.Alignment = Element.ALIGN_RIGHT;
                                paraNgViet.Alignment = Element.ALIGN_RIGHT;
                                paraDateTime.Alignment = Element.ALIGN_RIGHT;

                                pdfDoc.Add(para3);
                                pdfDoc.Add(para4);
                                pdfDoc.Add(para5);
                                pdfDoc.Add(para6);
                                pdfDoc.Add(para9);
                                pdfDoc.Add(para7);
                                pdfDoc.Add(new Phrase(""));
                                //pdfDoc.Add(para1);
                                pdfDoc.Add(new Phrase("   "));
                                pdfDoc.Add(c1);
                                pdfDoc.Add(paraLienHe);
                                //pdfDoc.Add(para2);
                                pdfDoc.Add(new Phrase(""));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(new Phrase(""));
                                pdfDoc.Add(paraThanhTien);
                                pdfDoc.Add(paraNgViet);
                                pdfDoc.Add(new Phrase("\n"));
                                pdfDoc.Add(paraDateTime);
                                pdfDoc.Add(paraSign);
                                pdfDoc.Add(new Phrase("\n\n\n\n"));
                                pdfDoc.Add(para8);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Dữ liệu xuất thành công!!!", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
            }    
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            dGVSearch.DataSource = controller.Load_On(UKEY, Position);
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

        private void TBLienHe_Enter(object sender, EventArgs e)
        {
            if (tBLienHe.Text == "Nhập số điện thoại hoặc địa chỉ của đối tác")
            {
                tBLienHe.Text = "";
                tBLienHe.ForeColor = Color.Black;
            }
        }

        private void TBLienHe_Leave(object sender, EventArgs e)
        {
            if (tBLienHe.Text == "")
            {
                tBLienHe.Text = "Nhập số điện thoại hoặc địa chỉ của đối tác";
                tBLienHe.ForeColor = Color.Gray;
            }
        }

        private void dGVSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickCell_dGV();
        }

        private void OderUser_Load(object sender, EventArgs e)
        {
            dGVSearch.DataSource = controller.Load_On(UKEY, Position);
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
                dGVSearch.DataSource = controller.Load_On(UKEY, Position);
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

        

        private void tBMaHang_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e)    // Sự kiện ấn nút enter => login
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtSearch.PerformClick();
            }
        }


        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                e.Handled = true;
        }

        private void GrAddOrder_Enter(object sender, EventArgs e)
        {

        }
    }
}