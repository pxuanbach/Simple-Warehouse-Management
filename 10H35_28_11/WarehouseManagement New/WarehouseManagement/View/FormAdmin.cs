using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using WarehouseManagement.Controller;
using System.Drawing.Text;
namespace WarehouseManagement
{
    public partial class FormAdmin : Form
    {
        Admin_Controller admin = new Admin_Controller();
        
        public string UserName;
        public int UKey;
        public FormAdmin(string Username)
        {
            InitializeComponent();
           
            UserName = Username;
            UKey = 19521334;
            
            dataGridViewAdmin.CellEndEdit += DataGridView1_CellEndEdit;     //sự kiện ô đã sửa xong
            dataGridViewAdmin.CellBeginEdit += DataGridView1_CellBeginEdit;
            dataGridViewAdmin.CellValueChanged += DataGridView1_CellValueChanged;
        }
        public string TenCot;   //lấy tên cột cần sửa đổi
        public string Value;    //Lấy giá trị đã sửa đổi
        public int OLD_Ukey;   //lấy ukey cũ trước khi sửa ukey

        //Khi giá trị của 1 ô bất kì thay đổi hàm này được thực thi 
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TenCot = dataGridViewAdmin.CurrentCell.OwningColumn.Name;
            Value = dataGridViewAdmin.SelectedRows[0].Cells[TenCot].Value.ToString();
        }

        //Khi bắt đầu vào chế độ sửa 1 ô hàm này được thực thi
        private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            TenCot = dataGridViewAdmin.CurrentCell.OwningColumn.Name;
            OLD_Ukey = Convert.ToInt32(dataGridViewAdmin.SelectedRows[0].Cells[0].Value.ToString());
            Value = dataGridViewAdmin.SelectedRows[0].Cells[TenCot].Value.ToString();
        }

        //Khi kết thúc sửa đổi 1 ô bất kì hàm này được thực thi
        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           // int n = dataGridViewAdmin.SelectedRows[0].Index;    //lấy giá trị hàng đã chọn
           // string[] donGia = dataGridViewAdmin.Rows[n].Cells[4].Value.ToString().Split('.');           
        }


        private void FormAdmin_Load(object sender, EventArgs e)
        {
            dataGridViewAdmin.DataSource = admin.load_on(UKey);
            dataGridViewAdmin.ReadOnly = true;                      //Set datagridview chỉ được đọc
            dataGridViewAdmin.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;    //khi click vào ô bất kì thì hàng đó sẽ được chọn
            buttonSave.Enabled = false;
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            Admin_AddUser ad = new Admin_AddUser(UKey);
            ad.ShowDialog();
            this.Show();
            dataGridViewAdmin.DataSource = admin.load_on(UKey); //Load lại datagridview sau khi add
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you really want to change this");
            dataGridViewAdmin.ReadOnly = false;
            buttonSave.Enabled = true;
            buttonEDIT.Enabled = false;
        }
        private void buttonSAVE_Click(object sender, EventArgs e)
        {
            //bool check = false;
            //for (int dtRow = 0; dtRow < dataGridViewAdmin.Rows.Count; dtRow++)
            //{
            //    OLD_Ukey = Convert.ToInt32(dataGridViewAdmin.Rows[dtRow].Cells[0].Value.ToString());
            //    if (admin.sua_useracc(Convert.ToInt32(dataGridViewAdmin.Rows[dtRow].Cells[0].Value.ToString()), dataGridViewAdmin.Rows[dtRow].Cells[1].Value.ToString(), OLD_Ukey, dataGridViewAdmin.Rows[dtRow].Cells[3].Value.ToString())  == false)
            //    {
            //        MessageBox.Show("Đã có lỗi xảy ra!");
            //        dataGridViewAdmin.DataSource = admin.load_on(UKey); //Load lại datagridview sau khi sửa thành công
            //    }
            //    check = true;
            //}
            //if (check == true)
            //{
            //    //listEdit.Clear();
            //    MessageBox.Show("Đã lưu lại sửa đổi thành công!");
            //    dataGridViewAdmin.DataSource = admin.load_on(UKey); //Load lại datagridview sau khi sửa thành công
            //}
            
            MessageBox.Show("Xuat sac ");
            dataGridViewAdmin.ReadOnly = true;
            buttonEDIT.Enabled = true;
            buttonSave.Enabled = false;
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            int n = dataGridViewAdmin.SelectedRows[0].Index;    //lấy giá trị hàng đã chọn
            if (admin.xoa_useracc(Convert.ToInt32( dataGridViewAdmin.Rows[n].Cells["UKEY"].Value.ToString())) == true)
            {
                MessageBox.Show("Chúc mừng đã xóa thành công!");
                dataGridViewAdmin.Refresh();
                dataGridViewAdmin.DataSource = admin.load_on(UKey); //Load lại datagridview sau khi xóa thành công
            }
        }
    }
}
