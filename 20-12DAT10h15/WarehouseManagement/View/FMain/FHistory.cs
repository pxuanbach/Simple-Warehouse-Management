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
    public partial class FHistory : Form
    {
        History_Controller controller = new History_Controller();
        List<CTHD> listCTHD;
        string tenDoiTac;
        DateTime thoiGian;
        string giaTri;
        Stock stock;
        int Ukey;
        int Position;
        int Type;

        //Position = 0 tương đương ADMIN, = 1 là quản lý, = 2 là nhân viên
        //Type = 0 là Lịch sử của Kho, = 1 là lịch sử hóa đơn
        public FHistory(int Ukey, int Pos, int Type)
        {
            InitializeComponent();
            this.Ukey = Ukey;
            Position = Pos;
            this.Type = Type;
            CbAll.Checked = true;
            dTPThoiGian.Enabled = false;
            cusTomDGV(Type);

            //Sự kiện click vào cell bất kì
            dGVHistory.CellMouseDown += DGVHistory_CellMouseDown;

            this.FormClosing += FHistory_FormClosing;
            dGVHistory.MouseDoubleClick += DGVHistory_MouseDoubleClick;
        }

        private void DGVHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PosDefine_dGV();
        }

        private void FHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            dGVHistory.Columns.Clear();
        }

        void cusTomDGV(int Type)
        {
            dGVHistory.Columns.Clear();
            if (Type == 1)
            {
                dGVHistory.Columns.Add("MAHD", "Mã Hóa Đơn");
                dGVHistory.Columns["MAHD"].DataPropertyName = "MAHOADON";

                dGVHistory.Columns.Add("TENDT", "Tên Đối Tác");
                dGVHistory.Columns["TENDT"].DataPropertyName = "TENDOITAC";

                dGVHistory.Columns.Add("NGAYNHAP", "Ngày Nhập");
                dGVHistory.Columns["NGAYNHAP"].DataPropertyName = "THOIGIAN";

                dGVHistory.Columns.Add("GIA", "Trị Giá");
                dGVHistory.Columns["GIA"].DataPropertyName = "TRIGIA";

                dGVHistory.Columns.Add("KEY", "Mã Người Thêm");
                dGVHistory.Columns["KEY"].DataPropertyName = "UKEY";

                dGVHistory.Columns.Add("TEN", "Người Thêm");
                dGVHistory.Columns["TEN"].DataPropertyName = "HOTEN";
            }
            else
            {
                dGVHistory.Columns.Add("MAHANG", "Mã Hàng");
                dGVHistory.Columns["MAHANG"].DataPropertyName = "MAHANG";

                dGVHistory.Columns.Add("TENHANG" ,"Tên Hàng");
                dGVHistory.Columns["TENHANG"].DataPropertyName = "TENHANG";

                dGVHistory.Columns.Add("NGNHAP", "Ngày Nhập");
                dGVHistory.Columns["NGNHAP"].DataPropertyName = "NGNHAP";

                dGVHistory.Columns.Add("UKEY", "Mã Người Thêm");
                dGVHistory.Columns["UKEY"].DataPropertyName = "UKEY";

                dGVHistory.Columns.Add("HOTEN", "Người Thêm");
                dGVHistory.Columns["HOTEN"].DataPropertyName = "HOTEN";
            }    
            
        }

        private void DGVHistory_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                dGVHistory.MultiSelect = false;
                dGVHistory.Rows[e.RowIndex].Selected = true;
            }
        }

        //Truyền thông tin hàng hóa sang page khác
        public Stock getStockDefine()
        {
            return stock;
        }

        //Truyền thông tin hóa đơn sang page khác
        public List<CTHD> getCTHDDefine()
        {
            return listCTHD;
        }

        public string getTenDoiTac()
        {
            return tenDoiTac;
        }

        public DateTime getThoiGian()
        {
            return thoiGian;
        }

        public string getGiaTri()
        {
            return giaTri;
        }

        private void CbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (CbAll.Checked == true)
            {
                dTPThoiGian.Enabled = false;
                if (Position != 2)
                    dGVHistory.DataSource = controller.Load_On_QuanLy(null, null, null, Type);
                else
                    dGVHistory.DataSource = controller.Load_On_NhanVien(Ukey, null, null, null, Type);
            }
            else
            {
                dTPThoiGian.Enabled = true;
                string dd = dTPThoiGian.Value.Day.ToString();
                string MM = dTPThoiGian.Value.Month.ToString();
                string yyyy = dTPThoiGian.Value.Year.ToString();
                if (Position != 2)
                    dGVHistory.DataSource = controller.Load_On_QuanLy(dd, MM, yyyy, Type);
                else
                    dGVHistory.DataSource = controller.Load_On_NhanVien(Ukey, dd, MM, yyyy, Type);
            }
        }

        private void FHistory_Load(object sender, EventArgs e)
        {
            if (Position != 2)
                dGVHistory.DataSource = controller.Load_On_QuanLy(null, null, null, Type);
            else
                dGVHistory.DataSource = controller.Load_On_NhanVien(Ukey, null, null, null, Type);  
            
            dGVHistory.ReadOnly = true;                      //Set datagridview chỉ được đọc
            dGVHistory.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;    //khi click vào ô bất kì thì hàng đó sẽ được chọn
        }

        void PosDefine_dGV()
        {
            if (dGVHistory.SelectedRows.Count > 0)
            {
                if (Type == 0)
                {
                    int currentRow = dGVHistory.SelectedRows[0].Index;
                    stock = new Stock();
                    stock.MAHANG = dGVHistory.Rows[currentRow].Cells["MAHANG"].Value.ToString();
                    stock.UKEY1 = Convert.ToInt32(dGVHistory.Rows[currentRow].Cells["UKEY"].Value);
                }
                else
                {
                    int currentRow = dGVHistory.SelectedRows[0].Index;
                    int MAHD = Convert.ToInt32(dGVHistory.Rows[currentRow].Cells["MAHD"].Value);
                    tenDoiTac = dGVHistory.Rows[currentRow].Cells["TENDT"].Value.ToString();
                    thoiGian = DateTime.ParseExact(dGVHistory.Rows[currentRow].Cells["NGAYNHAP"].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    giaTri = dGVHistory.Rows[currentRow].Cells["GIA"].Value.ToString();
                    int KEY = Convert.ToInt32(dGVHistory.Rows[currentRow].Cells["KEY"].Value);
                    listCTHD = controller.GetCTHDs(MAHD, KEY);
                }
                this.Close();
            }
        }

        private void BtPosDefine_Click(object sender, EventArgs e)
        {
            PosDefine_dGV();
        }

        private void dTPThoiGian_ValueChanged(object sender, EventArgs e)
        {
            if (CbAll.Checked == false)
            {
                string dd = dTPThoiGian.Value.Day.ToString();
                string MM = dTPThoiGian.Value.Month.ToString();
                string yyyy = dTPThoiGian.Value.Year.ToString();
                if (Position != 2)
                    dGVHistory.DataSource = controller.Load_On_QuanLy(dd, MM, yyyy, Type);
                else
                    dGVHistory.DataSource = controller.Load_On_NhanVien(Ukey, dd, MM, yyyy, Type);
            }    
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosDefine_dGV();
        }
    }
}
