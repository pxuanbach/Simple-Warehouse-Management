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
        public string MyAccount { get; set; }

        public AccountUser(string username, Size t) //Đầu vào là username từ Main Form
        {
            InitializeComponent();
            MyAccount = username;

            panelAccPage.ClientSize = t;
            TbOldPass.ForeColor = Color.Gray;
            TbOldPass.Text = "Enter Current Password";
            this.TbOldPass.Leave += new System.EventHandler(this.TbOldPass_Leave);
            this.TbOldPass.Enter += new System.EventHandler(this.TbOldPass_Enter);

            TbNewPass.ForeColor = Color.Gray;
            TbNewPass.Text = "Enter New Password";
            this.TbNewPass.Leave += new System.EventHandler(this.TbNewPass_Leave);
            this.TbNewPass.Enter += new System.EventHandler(this.TbNewPass_Enter);

            TbRePass.ForeColor = Color.Gray;
            TbRePass.Text = "Enter Re-Password";
            this.TbRePass.Leave += new System.EventHandler(this.TbRePass_Leave);
            this.TbRePass.Enter += new System.EventHandler(this.TbRePass_Enter);
        }
        

        //Load thông tin account từ SQL Server lên page
        private void AccountUser_Load(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc = controller.getInformation(MyAccount);

            labelName.Text = acc.Name1;
            textBoxPNumber.Text = acc.Phone1;
            dateTimePickerBDay.Value = acc.Birthday1;
            comboBoxGTinh.Text = acc.Gender1;
            textBoxEmail.Text = acc.Email1;
            labelViTri.Text = acc.Position1;

            textBoxEmail.ReadOnly = true;
            textBoxPNumber.ReadOnly = true;

        }

        #region Cài đặt các textbox đổi password
        //Khi không chọn vào textbox Current Password
        private void TbOldPass_Leave(object sender, EventArgs e)
        {
            if (TbOldPass.Text == "")
            {
                this.TbOldPass.PasswordChar = '\0';
                TbOldPass.Text = "Enter Current Password";
                TbOldPass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox Current Password
        private void TbOldPass_Enter(object sender, EventArgs e)
        {
            if (TbOldPass.Text == "Enter Current Password")
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
                TbNewPass.Text = "Enter New Password";
                TbNewPass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox New Password
        private void TbNewPass_Enter(object sender, EventArgs e)
        {
            if (TbNewPass.Text == "Enter New Password")
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
                TbRePass.Text = "Enter Re-Password";
                TbRePass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox Re-Password
        private void TbRePass_Enter(object sender, EventArgs e)
        {
            if (TbRePass.Text == "Enter Re-Password")
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
            AccountPage_Controller acc = new AccountPage_Controller();
            MessageBox.Show("Do you want to change password?");
            if (TbNewPass.Text != TbRePass.Text)
            {
                MessageBox.Show("Your re-password is incorrect.");
            }
            else
            {

                if (account.checkUser(MyAccount, TbOldPass.Text) == false)
                {
                    MessageBox.Show("Your current password is incorrect.");
                }
                else
                {
                    acc.changeUserPass(TbOldPass.Text, TbNewPass.Text, MyAccount);
                    MessageBox.Show("Your change successfully");
                    TbNewPass.Text = "";
                    TbOldPass.Text = "";
                    TbRePass.Text = "";
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxEmail.ReadOnly = false;
            textBoxPNumber.ReadOnly = false;
        }

        private void BtSaveInfor_Click(object sender, EventArgs e)
        {
            textBoxEmail.ReadOnly = true;
            textBoxPNumber.ReadOnly = true;
        }
    }
}
