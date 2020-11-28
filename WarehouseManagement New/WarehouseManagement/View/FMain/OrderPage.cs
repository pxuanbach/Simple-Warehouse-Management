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
        bool isClickedButtonMain = false;
        bool isClickedButtonEdit = false;
        ToolTip toolTip = new ToolTip();
        public OderUser(int ukey)
        {
            InitializeComponent();
            setButtonHide();
            cBSelect.SelectedIndex = 0;
            UKEY = ukey;
            
            toolTip.SetToolTip(btMain, "Click to show list button.");
            toolTip.SetToolTip(btEdit, "EDIT\nClick to edit order.");
            toolTip.SetToolTip(btSave, "SAVE\nClick to save ORDER.");
            toolTip.SetToolTip(btCancel, "CANCEL\nClick to exit edit mode.");
            toolTip.SetToolTip(btDelete, "DELETE\nClick to delete row in order.");
            toolTip.SetToolTip(btPrint, "PRINT\nClick to print order.");
        }

        private void OderUser_Load(object sender, EventArgs e)
        {
            dGVSearch.DataSource = controller.Load_On(UKEY);
            dGVSearch.ReadOnly = true;                      //Set datagridview chỉ được đọc
            dGVSearch.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;    //khi click vào ô bất kì thì hàng đó sẽ được chọn
        }

        void setAccessButton(bool check)
        {
            btEdit.Enabled = check;
            btSave.Enabled = check;
            btCancel.Enabled = !check;
            btDelete.Enabled = check;
            btPrint.Enabled = check;
        }

        void setButtonHide()
        {
            setAccessButton(true);
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
                if(btSave.Enabled == true)
                {
                    //code
                }
                toolTip.SetToolTip(btMain, "Click to show list button.");
                setButtonHide();
                isClickedButtonMain = false;
            } 
            else
            {
                buttonTimer.Start();
                toolTip.SetToolTip(btMain, "Click to hide list button.");
                isClickedButtonMain = true;
            }    
        }

        private void buttonTimer_Tick(object sender, EventArgs e)
        {
            
            i++;
            switch(i)
            {
                case 1:
                    btEdit.Show(); break;
                case 2:
                    btSave.Show(); break;
                case 3:
                    btDelete.Show(); break;
                case 4:
                    btPrint.Show(); break;
                case 5:
                    btCancel.Show(); break;
                default:
                    break;
            }
            if (i == 5)
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
            dTPNgNhap.Value = Convert.ToDateTime(dGVSearch.Rows[n].Cells["NGNHAP"].Value);
            tBDonGia.Text = donGia[0];
            tBSoLuong.Text = dGVSearch.Rows[n].Cells["SoLuong"].Value.ToString();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            setAccessButton(false);
            btSave.Enabled = true;
            toolTip.SetToolTip(btSave, "SAVE\nClick to save CHANGES.");
            isClickedButtonEdit = true;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            setAccessButton(true);
            toolTip.SetToolTip(btSave, "SAVE\nClick to save ORDER.");
            isClickedButtonEdit = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tBMaHang.Text == "" || tBTenHang.Text == "" || tBDonGia.Text == "" || tBSoLuong.Text == "")
            {
                MessageBox.Show("Something wrong!");
                return;
            }
            else
            {

            }    
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (isClickedButtonEdit)    //đã chuyển qua chế độ chỉnh sửa: chức năng lưu chỉnh sửa vào database
            {
                
            }
            else                        //đang ở chế độ bình thường: chức năng lưu hóa đơn vào database        
            {
                
            }    
        }
    }
}