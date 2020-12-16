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
using System.Data.SqlClient;

namespace WarehouseManagement
{
    public partial class AccountUser : UserControl
    {
        //tạo 1 đối tượng controller
        AccountPage_Controller controller = new AccountPage_Controller();
        Account acc = new Account();
        string MyAccount;
        int UKEY;

        public AccountUser(string username, int UKEY) //Đầu vào là username từ Main Form
        {
            InitializeComponent();
            MyAccount = username;
            this.UKEY = UKEY;
            cbBGTinh.SelectedIndex = 0;
            BtSaveInfor.Enabled = false;

            TbOldPass.ForeColor = Color.Gray;
            TbOldPass.Text = "Nhập mật khẩu hiện tại";
            this.TbOldPass.Leave += new System.EventHandler(this.TbOldPass_Leave);
            this.TbOldPass.Enter += new System.EventHandler(this.TbOldPass_Enter);

            TbNewPass.ForeColor = Color.Gray;
            TbNewPass.Text = "Nhập mật khẩu mới";
            this.TbNewPass.Leave += new System.EventHandler(this.TbNewPass_Leave);
            this.TbNewPass.Enter += new System.EventHandler(this.TbNewPass_Enter);

            TbRePass.ForeColor = Color.Gray;
            TbRePass.Text = "Xác nhận lại mật khẩu mới";
            this.TbRePass.Leave += new System.EventHandler(this.TbRePass_Leave);
            this.TbRePass.Enter += new System.EventHandler(this.TbRePass_Enter);
        }
        

        //Load thông tin account từ SQL Server lên page
        private void AccountUser_Load(object sender, EventArgs e)
        {
            acc = controller.getInformation(MyAccount);

            labelName.Text = acc.Name1;
            tBPNumber.Text = acc.Phone1;
            dTPBDay.Value = acc.Birthday1;
            cbBGTinh.Text = acc.Gender1;
            tBEmail.Text = acc.Email1;
            labelViTri.Text = acc.Position1;

            tBEmail.ReadOnly = true;
            tBPNumber.ReadOnly = true;

        }

        #region Cài đặt các textbox đổi password
        //Khi không chọn vào textbox Current Password
        private void TbOldPass_Leave(object sender, EventArgs e)
        {
            if (TbOldPass.Text == "")
            {
                this.TbOldPass.PasswordChar = '\0';
                TbOldPass.Text = "Nhập mật khẩu hiện tại";
                TbOldPass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox Current Password
        private void TbOldPass_Enter(object sender, EventArgs e)
        {
            if (TbOldPass.Text == "Nhập mật khẩu hiện tại")
            {
                TbOldPass.Text = "";
                TbOldPass.ForeColor = Color.Black;
                this.TbOldPass.PasswordChar = '\u25CF';
            }
        }

        //Khi không chọn vào textbox New Password
        private void TbNewPass_Leave(object sender, EventArgs e)
        {
            if (TbNewPass.Text == "")
            {
                this.TbNewPass.PasswordChar = '\0';
                TbNewPass.Text = "Nhập mật khẩu mới";
                TbNewPass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox New Password
        private void TbNewPass_Enter(object sender, EventArgs e)
        {
            if (TbNewPass.Text == "Nhập mật khẩu mới")
            {
                TbNewPass.Text = "";
                TbNewPass.ForeColor = Color.Black;
                this.TbNewPass.PasswordChar = '\u25CF';
            }
        }

        //Khi không chọn vào textbox Re-Password
        private void TbRePass_Leave(object sender, EventArgs e)
        {
            if (TbRePass.Text == "")
            {
                this.TbRePass.PasswordChar = '\0';
                TbRePass.Text = "Xác nhận lại mật khẩu mới";
                TbRePass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox Re-Password
        private void TbRePass_Enter(object sender, EventArgs e)
        {
            if (TbRePass.Text == "Xác nhận lại mật khẩu mới")
            {
                TbRePass.Text = "";
                TbRePass.ForeColor = Color.Black;
                this.TbRePass.PasswordChar = '\u25CF';
            }
        }
        #endregion

        private void BtSavePass_Click(object sender, EventArgs e)
        {
            Login_Controller account = new Login_Controller();
           
            MessageBox.Show("Bạn chắc chắn muốn thay đổi mật khẩu?");
            if (TbNewPass.Text != TbRePass.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận lại bị sai.");
            }
            else
            {

                if (account.checkUser(MyAccount, TbOldPass.Text) == false)
                {
                    MessageBox.Show("Mật khẩu hiện tại sai.");
                }
                else
                {
                    controller.changeUserPass(TbOldPass.Text, TbNewPass.Text, MyAccount);
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                    TbNewPass.Text = "";
                    TbOldPass.Text = "";
                    TbRePass.Text = "";
                }
            }
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            BtSaveInfor.Enabled = true;
            tBEmail.ReadOnly = false;
            tBEmail.Font = new Font(tBEmail.Font, FontStyle.Regular);
            tBPNumber.ReadOnly = false;
            tBPNumber.Font = new Font(tBPNumber.Font, FontStyle.Regular);
        }

        private void BtSaveInfor_Click(object sender, EventArgs e)
        {
            acc.Phone1 = tBPNumber.Text;
            acc.Birthday1 = dTPBDay.Value;
            acc.Gender1 = cbBGTinh.Text;
            acc.Email1 = tBEmail.Text;

            if (!controller.saveInfomation(acc, UKEY))
            {
                MessageBox.Show("Đã có lỗi xảy ra!", "Lỗi");
            }    

            tBEmail.ReadOnly = true;
            tBPNumber.ReadOnly = true;
            tBEmail.Font = new Font(tBEmail.Font, FontStyle.Italic);
            tBPNumber.Font = new Font(tBPNumber.Font, FontStyle.Italic);
            BtSaveInfor.Enabled = false;
        }
    }
}
