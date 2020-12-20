using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using WarehouseManagement.Controller;
using System.Drawing.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WarehouseManagement
{
    public partial class StockPage : UserControl
    {
        //tạo 1 đối tượng controller
        StockPage_Controller controller = new StockPage_Controller();
        List<Stock> listEdit = new List<Stock>();

        //tạo 2 biến chứa thông tin Username và Ukey
        public string UserName;
        public int UKey;
        int Position;
        bool isSearched = false;
        bool isClickedBin = false;

        //Position = 0 tương đương ADMIN, = 1 là quản lý, = 2 là nhân viên
        //Khởi tạo user control với đầu vào là Username, Ukey và Position
        public StockPage(string Username, int Ukey, int Position)
        {
            InitializeComponent();
            comboBoxSeach.SelectedIndex = 0;
            UserName = Username;
            UKey = Ukey;
            this.Position = Position;

            if (Position == 2)
            {
                dataGridView1.Columns["MA_NGTHEM"].Visible = false;
            }

            dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
            tBSearch.KeyDown += TBSearch_KeyDown;
        }

        private void TBSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                BtSearch.PerformClick();

            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                dataGridView1.MultiSelect = false;
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tBSearch.Text == "" && isSearched == true)
            {
                dataGridView1.DataSource = controller.Load_On(UKey, 0, Position);
                isSearched = false;
            }    
        }

        //Load data của mỗi tài khoản bằng Ukey đã Get được
        private void StockUser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.Load_On(UKey, 0, Position);
            dataGridView1.ReadOnly = true;                      //Set datagridview chỉ được đọc
            dataGridView1.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;    //khi click vào ô bất kì thì hàng đó sẽ được chọn
        }

        //Search data
        private void BtSearch_Click(object sender, EventArgs e)
        {
            if (tBSearch.Text != "")
            {
                dataGridView1.DataSource = controller.Load_Search(comboBoxSeach.Text, tBSearch.Text, UKey, Position);
                isSearched = true;
            }
        }

        //Click vào button ADD sẽ đưa đến form add thông tin hàng hóa
        private void BtAdd_Click(object sender, EventArgs e)
        {
            FStock f = new FStock(UKey, 0, null);
            f.ShowDialog();
            this.Show();
            dataGridView1.DataSource = controller.Load_On(UKey, 0, Position); //Load lại datagridview sau khi add
        }

        void Edit_dGV()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int n = dataGridView1.SelectedRows[0].Index;    //lấy giá trị hàng đã chọn
                Stock g = new Stock();
                g.MAHANG = dataGridView1.Rows[n].Cells[0].Value.ToString();
                g.TENHANG = dataGridView1.Rows[n].Cells[1].Value.ToString();
                g.DVT = dataGridView1.Rows[n].Cells[2].Value.ToString();
                g.SOLUONG = dataGridView1.Rows[n].Cells[3].Value.ToString();
                g.DONGIA = dataGridView1.Rows[n].Cells[4].Value.ToString();
                g.NGNHAP = DateTime.ParseExact(dataGridView1.Rows[n].Cells[5].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                g.NGSANXUAT = dataGridView1.Rows[n].Cells[6].Value.ToString();
                g.HSD = dataGridView1.Rows[n].Cells[7].Value.ToString();
                g.UKEY1 = Convert.ToInt32(dataGridView1.Rows[n].Cells["MA_NGTHEM"].Value);
                FStock f = new FStock(UKey, 1, g);
                f.ShowDialog();
                this.Show();
                dataGridView1.DataSource = controller.Load_On(UKey, 0, Position); //Load lại datagridview sau khi edit
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng muốn sửa!");
            }
        }

        //Click vào button EDIT sẽ mở tính năng edit hàng hóa trên datagridview
        private void BtEdit_Click(object sender, EventArgs e)
        {
            Edit_dGV();
        }

        //Click vào button CANCEL sẽ thoát khỏi tính năng edit hàng hóa
        private void BtCancel_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;     //Set datagridview chỉ được đọc
            dataGridView1.DataSource = controller.Load_On(UKey, 0, Position); //Load lại datagridview
            listEdit.Clear();
        }

        void Delete_dGV()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int n = dataGridView1.SelectedRows[0].Index;    //lấy giá trị hàng đã chọn
                try
                {
                    if (controller.Xoa_HangHoa(dataGridView1.Rows[n].Cells["MAHANG"].Value.ToString(), UKey) == true)
                    {
                        MessageBox.Show("Đã xóa thành công!");
                        dataGridView1.Refresh();
                        dataGridView1.DataSource = controller.Load_On(UKey, 0, Position); //Load lại datagridview sau khi xóa thành công
                    }
                }
                catch (Exception g)
                {
                    MessageBox.Show("Hàng hóa này không thể xóa.\nVì nó đã tồn tại trong hóa đơn.");
                }
            }
            else
                MessageBox.Show("Vui lòng chọn hàng muốn xóa!");
        }

        //Click vào button DELETE sẽ xóa hàng đã chọn trong datagridview
        private void BtDel_Click(object sender, EventArgs e)
        {
            Delete_dGV();
        }

        void History_dGV()
        {
            FHistory f = new FHistory(UKey, Position, 0);
            f.ShowDialog();
            Stock stockDef = f.getStockDefine();

            if (stockDef != null)
            {
                dataGridView1.DataSource = controller.Load_Search("Mã Hàng", stockDef.MAHANG, stockDef.UKEY1, Position);  //Load các hàng hóa có mã trùng nhau
            }

            this.Show();
        }

        private void BtHistory_Click(object sender, EventArgs e)
        {
            History_dGV();
        }

        void Bin_dGV()
        {
            if (isClickedBin == false)
            {
                dataGridView1.DataSource = controller.Load_On(UKey, 1, Position);
                isClickedBin = true;
            }
            else
            {
                dataGridView1.DataSource = controller.Load_On(UKey, 0, Position);
                isClickedBin = false;
            }
        }

        private void BtBin_Click(object sender, EventArgs e)
        {
            Bin_dGV();
        }

        private void BtSearch_Enter(object sender, EventArgs e)
        {
            BtSearch.BorderColor = Color.DeepSkyBlue;
        }

        private void BtSearch_Leave(object sender, EventArgs e)
        {
            BtSearch.BorderColor = Color.Silver;
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FStock f = new FStock(UKey, 0, null);
            f.ShowDialog();
            this.Show();
            dataGridView1.DataSource = controller.Load_On(UKey, 0, Position); //Load lại datagridview sau khi add
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_dGV();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_dGV();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History_dGV();
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isClickedBin == false)      //Mode bình thường
            {
                dataGridView1.DataSource = controller.Load_On(UKey, 0, Position);
            }
            else //Mode thùng rác
            {
                dataGridView1.DataSource = controller.Load_On(UKey, 1, Position);
            }
        }

        private void comboBoxSeach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "HANGHOA.pdf";
                bool fileError = false;
                //Full path to the Unicode Arial file
                string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.TTF");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //Create a specific font object
                iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                string TimeNewRoman = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "pala.ttf");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf_timeNR = BaseFont.CreateFont(TimeNewRoman, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

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
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count-1);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Thêm tên cột
                           foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                if (column.Name != "MA_NGTHEM")
                                { 
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, f));
                                    cell.BackgroundColor = new iTextSharp.text.BaseColor(199, 231, 223);
                    
                                    pdfTable.AddCell(cell);
                                }    
                            }
                            // Thêm dữ liệu trong từng cột
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {  
                                    if (cell.ColumnIndex != 8)
                                    {
                                        if (cell.Value == null)
                                        {
                                            pdfTable.AddCell(new Phrase("", f));
                                        }
                                        else
                                        {
                                            pdfTable.AddCell(new Phrase(cell.Value.ToString(), f));
                                        }
                                    }     
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.NORMAL);
                                iTextSharp.text.Font f2 = new iTextSharp.text.Font(bf_timeNR, 12, iTextSharp.text.Font.NORMAL);
                                // Thêm tên của cột
                                PdfPTable pdfTableTitle = new PdfPTable(2);
                                pdfTableTitle.AddCell(new Phrase("BDT Comany", titleFont));
                                pdfTableTitle.AddCell(new Phrase("Địa chỉ: Trường Đại học Công nghệ Thông tin." +
                                                                    " Khu phố 6, P.Linh Trung, Q.Thủ Đức, TP.Hồ Chí Minh.\n"
                                                                    + "         ------------------------------------", f2));
                                pdfDoc.Add(pdfTableTitle);
                                pdfDoc.Add(new Phrase("DANH SÁCH HÀNG HÓA", titleFont));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(new Phrase("Thời gian:" + DateTime.Now.ToString(), f2));
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
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Info");
            }
        }
    }
}