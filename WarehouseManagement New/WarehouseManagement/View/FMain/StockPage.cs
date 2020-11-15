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
        StockPage_Controller stock = new StockPage_Controller();
        List<Stock> listEdit = new List<Stock>();

        //tạo 2 biến chứa thông tin Username và Ukey
        public string UserName;
        public int UKey;

        //Khởi tạo user control với đầu vào là Username và Ukey
        public StockPage(string Username, int Ukey)
        {
            InitializeComponent();
            UserName = Username;
            UKey = Ukey;
            set_AccessButtonCancel();
            
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }

        public string TenCot;   //lấy tên cột cần sửa đổi
        public string Value;    //Lấy giá trị đã sửa đổi
        public string MaHang;   //lấy mã hàng cũ trước khi sửa mã hàng
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TenCot = dataGridView1.CurrentCell.OwningColumn.Name;
            MaHang = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Value = dataGridView1.SelectedRows[0].Cells[TenCot].Value.ToString();
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;    //lấy giá trị hàng đã chọn
            string[] donGia = dataGridView1.Rows[n].Cells[4].Value.ToString().Split('.');
            
            listEdit.Add(new Stock
            {
                TENCOT = TenCot,
                value = Value,
                //MAHANG = dataGridView1.Rows[n].Cells[0].Value.ToString(),
                //TENHANG = dataGridView1.Rows[n].Cells[1].Value.ToString(),
                //DVT = dataGridView1.Rows[n].Cells[2].Value.ToString(),
                //SOLUONG = Convert.ToInt32(dataGridView1.Rows[n].Cells[3].Value),
                //DONGIA = Convert.ToInt32(donGia[0]),
                //NGNHAP = Convert.ToDateTime(dataGridView1.Rows[n].Cells[5].Value.ToString()),
                //NGSANXUAT = Convert.ToDateTime(dataGridView1.Rows[n].Cells[6].Value.ToString()),
                //HSD = Convert.ToDateTime(dataGridView1.Rows[n].Cells[7].Value.ToString()),
                MAHANGCU = MaHang
            });
            //for (int i = 0; i < listEdit.Count(); i++)
            //{
            //    MessageBox.Show(listEdit[i].TENCOT + listEdit[i].value + listEdit[i].MAHANGCU);
            //}
            //MessageBox.Show(listEdit[0].TENCOT + "=" + MaHang);
        }

        
        //Set truy cập button
        public void set_AccessButtonEdit()
        {
            btAdd.Enabled = false;      //chặn
            btDel.Enabled = false;      //chặn
            btEdit.Enabled = false;     //chặn
            btPrint.Enabled = false;    //chặn
            btCancel.Enabled = true;    //mở
            btSave.Enabled = true;      //mở
        }
        public void set_AccessButtonCancel()
        {
            btAdd.Enabled = true;       //mở   
            btDel.Enabled = true;       //mở
            btEdit.Enabled = true;      //mở
            btPrint.Enabled = true;     //mở
            btCancel.Enabled = false;   //chặn
            btSave.Enabled = false;     //chặn
        }
        //

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        

        //Load data của mỗi tài khoản bằng Ukey đã Get được
        private void StockUser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = stock.Load_On(UKey);
            dataGridView1.ReadOnly = true;                      //Set datagridview chỉ được đọc
            dataGridView1.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;    //khi click vào ô bất kì thì hàng đó sẽ được chọn
        }

        //Search data
        private void buttonSeach_Click(object sender, EventArgs e)
        {
            if (comboBoxSeach.Text == "Mã hàng")
                dataGridView1.DataSource = stock.Load_MA(Search.Text, UKey); // Load các hàng hóa có mã trùng nhau ( nhưng chắc là 1 cái thôi )
            if (comboBoxSeach.Text == "Tên hàng")
                dataGridView1.DataSource = stock.Load_TENHANG(Search.Text, UKey); // Load các hàng hóa có  tên trung nhau một phần nào đó
            if (comboBoxSeach.Text == "Ngày nhập")
                dataGridView1.DataSource = stock.Load_NGAYNHAP(Search.Text, UKey); // Load các hàng hóa có  tên trung nhau một phần nào đó
            dataGridView1.ReadOnly = true;                      //Set datagridview chỉ được đọc
        }

        //Click vào button ADD sẽ đưa đến form add thông tin hàng hóa
        private void BtAdd_Click(object sender, EventArgs e)
        {
            FAdd f = new FAdd(UKey);
            f.ShowDialog();
            this.Show();
            dataGridView1.DataSource = stock.Load_On(UKey); //Load lại datagridview sau khi add

        }

        //Click vào button EDIT sẽ mở tính năng edit hàng hóa trên datagridview
        private void btEdit_Click(object sender, EventArgs e)
        {
            set_AccessButtonEdit();     //chặn truy cập các button ADD, DELETE, EDIT, PRINT và mở truy cập SAVE, CANCEL
            dataGridView1.ReadOnly = false;     //Set datagridview được quyền sửa
            
        }

        //Click vào button SAVE sẽ lưu lại những thay đổi đã sửa trong datagridview
        private void btSave_Click(object sender, EventArgs e)
        {
            if (listEdit.Count() != 0)
            {
                bool check = false;
                for (int i = 0; i < listEdit.Count(); i++)
                {
                    if (stock.Sua_HangHoa(listEdit[i].TENCOT, listEdit[i].value, listEdit[i].MAHANGCU) == false)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra!");
                        dataGridView1.DataSource = stock.Load_On(UKey); //Load lại datagridview sau khi sửa thành công
                    }
                    check = true;
                }    
                if (check == true)
                {
                    MessageBox.Show("Đã lưu lại sửa đổi thành công!");
                    dataGridView1.DataSource = stock.Load_On(UKey); //Load lại datagridview sau khi sửa thành công
                }    
            }    
        }

        //Click vào button CANCEL sẽ thoát khỏi tính năng edit hàng hóa
        private void btCancel_Click(object sender, EventArgs e)
        {
            set_AccessButtonCancel();   //mở truy cập các button ADD, DELETE, EDIT, PRINT và chặn truy cập SAVE, CANCEL
            dataGridView1.ReadOnly = true;     //Set datagridview chỉ được đọc
            listEdit.Clear();
        }

        //Click vào button DELETE sẽ xóa hàng đã chọn trong datagridview
        private void btDel_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;    //lấy giá trị hàng đã chọn
            if (stock.Xoa_HangHoa(dataGridView1.Rows[n].Cells["MAHANG"].Value.ToString()) == true)
            {
                MessageBox.Show("Chúc mừng đã xóa thành công!");
                dataGridView1.Refresh();
                dataGridView1.DataSource = stock.Load_On(UKey); //Load lại datagridview sau khi xóa thành công
            }
        }

        

        
    }
}
