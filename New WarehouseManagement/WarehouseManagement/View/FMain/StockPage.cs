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
        //Khởi tạo user control với đầu vào là Username và Ukey
        public StockPage(string Username, int Ukey, int Position)
        {
            InitializeComponent();
            comboBoxSeach.SelectedIndex = 0;
            UserName = Username;
            UKey = Ukey;
            this.Position = Position;

            if (Position != 0)
            {
                dataGridView1.Columns["MA_NGTHEM"].Visible = false;
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
            dataGridView1.DataSource = controller.Load_Search(comboBoxSeach.Text, tBSearch.Text, UKey, Position);
            isSearched = true;

        }

        //Click vào button ADD sẽ đưa đến form add thông tin hàng hóa
        private void BtAdd_Click(object sender, EventArgs e)
        {
            FStock f = new FStock(UKey, 0, null);
            f.ShowDialog();
            this.Show();
            dataGridView1.DataSource = controller.Load_On(UKey, 0, Position); //Load lại datagridview sau khi add
        }

        //Click vào button EDIT sẽ mở tính năng edit hàng hóa trên datagridview
        private void BtEdit_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;    //lấy giá trị hàng đã chọn
            Stock g = new Stock();
            g.MAHANG = dataGridView1.Rows[n].Cells[0].Value.ToString();
            g.TENHANG = dataGridView1.Rows[n].Cells[1].Value.ToString();
            g.DVT = dataGridView1.Rows[n].Cells[2].Value.ToString();
            g.SOLUONG = dataGridView1.Rows[n].Cells[3].Value.ToString();
            g.DONGIA = dataGridView1.Rows[n].Cells[4].Value.ToString();
            g.NGNHAP = Convert.ToDateTime(dataGridView1.Rows[n].Cells[5].Value);
            g.NGSANXUAT = dataGridView1.Rows[n].Cells[6].Value.ToString();
            g.HSD = dataGridView1.Rows[n].Cells[7].Value.ToString();
            g.UKEY1 = Convert.ToInt32(dataGridView1.Rows[n].Cells["MA_NGTHEM"].Value);
            FStock f = new FStock(UKey, 1, g);
            f.ShowDialog();
            this.Show();
            dataGridView1.DataSource = controller.Load_On(UKey, 0, Position); //Load lại datagridview sau khi edit
        }

        //Click vào button CANCEL sẽ thoát khỏi tính năng edit hàng hóa
        private void BtCancel_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;     //Set datagridview chỉ được đọc
            dataGridView1.DataSource = controller.Load_On(UKey, 0, Position); //Load lại datagridview
            listEdit.Clear();
        }

        //Click vào button DELETE sẽ xóa hàng đã chọn trong datagridview
        private void BtDel_Click(object sender, EventArgs e)
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

        private void BtHistory_Click(object sender, EventArgs e)
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

        private void BtBin_Click(object sender, EventArgs e)
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

        private void BtSearch_Enter(object sender, EventArgs e)
        {
            BtSearch.BorderColor = Color.DeepSkyBlue;
        }

        private void BtSearch_Leave(object sender, EventArgs e)
        {
            BtSearch.BorderColor = Color.Silver;
        }
    }
}
