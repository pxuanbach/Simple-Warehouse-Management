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
            cBGTinh.SelectedIndex = 0;
            cBGTinh.Visible = false;
            BtSaveInfo.Enabled = false;

            tBCurPass.ForeColor = Color.Gray;
            tBCurPass.Text = "Nhập mật khẩu hiện tại";
            this.tBCurPass.Leave += new System.EventHandler(this.tBCurPass_Leave);
            this.tBCurPass.Enter += new System.EventHandler(this.tBCurPass_Enter);

            tBNewPass.ForeColor = Color.Gray;
            tBNewPass.Text = "Nhập mật khẩu mới";
            this.tBNewPass.Leave += new System.EventHandler(this.tBNewPass_Leave);
            this.tBNewPass.Enter += new System.EventHandler(this.tBNewPass_Enter);

            tBRePass.ForeColor = Color.Gray;
            tBRePass.Text = "Xác nhận lại mật khẩu mới";
            this.tBRePass.Leave += new System.EventHandler(this.tBRePass_Leave);
            this.tBRePass.Enter += new System.EventHandler(this.tBRePass_Enter);
        }
        

        //Load thông tin account từ SQL Server lên page
        private void AccountUser_Load(object sender, EventArgs e)
        {
            //Lấy thông tin tài khoản lưu vào đối tượng acc
            acc = controller.getInformation(UKEY);
            //Lấy thông tin tài khoản điền vào các control hiển thị
            labelName.Text = acc.Name1;
            tBPhone.Text = acc.Phone1;
            dTPBDay.Value = acc.Birthday1;
            labelGender.Text = acc.Gender1;
            cBGTinh.Text = acc.Gender1;
            tBEmail.Text = acc.Email1;
            labelChucVu.Text = acc.Position1;

            tBEmail.ReadOnly = true;
            tBPhone.ReadOnly = true;
        }

        #region Cài đặt các textbox đổi password
        //Khi không chọn vào textbox Current Password
        private void tBCurPass_Leave(object sender, EventArgs e)
        {
            if (tBCurPass.Text == "")
            {
                this.tBCurPass.PasswordChar = '\0';
                tBCurPass.Text = "Nhập mật khẩu hiện tại";
                tBCurPass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox Current Password
        private void tBCurPass_Enter(object sender, EventArgs e)
        {
            if (tBCurPass.Text == "Nhập mật khẩu hiện tại")
            {
                tBCurPass.Text = "";
                tBCurPass.ForeColor = Color.Black;
                this.tBCurPass.PasswordChar = '\u25CF';
            }
        }

        //Khi không chọn vào textbox New Password
        private void tBNewPass_Leave(object sender, EventArgs e)
        {
            if (tBNewPass.Text == "")
            {
                this.tBNewPass.PasswordChar = '\0';
                tBNewPass.Text = "Nhập mật khẩu mới";
                tBNewPass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox New Password
        private void tBNewPass_Enter(object sender, EventArgs e)
        {
            if (tBNewPass.Text == "Nhập mật khẩu mới")
            {
                tBNewPass.Text = "";
                tBNewPass.ForeColor = Color.Black;
                this.tBNewPass.PasswordChar = '\u25CF';
            }
        }

        //Khi không chọn vào textbox Re-Password
        private void tBRePass_Leave(object sender, EventArgs e)
        {
            if (tBRePass.Text == "")
            {
                this.tBRePass.PasswordChar = '\0';
                tBRePass.Text = "Xác nhận lại mật khẩu mới";
                tBRePass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox Re-Password
        private void tBRePass_Enter(object sender, EventArgs e)
        {
            if (tBRePass.Text == "Xác nhận lại mật khẩu mới")
            {
                tBRePass.Text = "";
                tBRePass.ForeColor = Color.Black;
                this.tBRePass.PasswordChar = '\u25CF';
            }
        }
        #endregion

        //Click button Lưu thay đổi trong groupbox Đổi Mật Khẩu
        private void BtSavePass_Click(object sender, EventArgs e)
        {
            Login_Controller account = new Login_Controller();

            if (tBCurPass.Text == "Nhập mật khẩu hiện tại" 
                || tBNewPass.Text == "Nhập mật khẩu mới" 
                || tBRePass.Text == "Xác nhận lại mật khẩu mới")
            {
                MessageBox.Show("Thông tin trống. Vui lòng nhập đầy đủ", "Thông báo");
                return;
            }    
            if (tBNewPass.Text != tBRePass.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận lại bị sai.", "Thông báo");
            }
            else
            {
                if (account.checkUser(MyAccount, tBCurPass.Text) == false)  
                {
                    MessageBox.Show("Mật khẩu hiện tại sai.", "Thông báo");
                }
                else
                {
                    var window = MessageBox.Show("Bạn chắc chắn muốn thay đổi mật khẩu?", "Thoát Ứng Dụng", MessageBoxButtons.YesNo);
                    if (window == DialogResult.Yes)
                    {
                        controller.changeUserPass(tBCurPass.Text, tBNewPass.Text, MyAccount);
                        MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo");
                        tBNewPass.Text = "";
                        tBNewPass_Leave(sender, e);
                        tBCurPass.Text = "";
                        tBCurPass_Leave(sender, e);
                        tBRePass.Text = "";
                        tBRePass_Leave(sender, e);
                    }
                    
                }
            }
        }

        bool isEdited = false;
        //Click button Sửa trong groupbox Thông Tin Cá Nhân
        private void BtEdit_Click(object sender, EventArgs e)
        {
            //Click lần 1 
            if (isEdited == false)
            {
                BtSaveInfo.Enabled = true;
                tBEmail.ReadOnly = false;
                tBEmail.Font = new Font(tBEmail.Font, FontStyle.Regular);
                tBPhone.ReadOnly = false;
                tBPhone.Font = new Font(tBPhone.Font, FontStyle.Regular);
                cBGTinh.Visible = true;
                labelGender.Visible = false;
                isEdited = true;
            }    
            else   //Click lần 2
            {
                tBEmail.ReadOnly = true;
                tBPhone.ReadOnly = true;
                tBEmail.Font = new Font(tBEmail.Font, FontStyle.Italic);
                tBPhone.Font = new Font(tBPhone.Font, FontStyle.Italic);
                BtSaveInfo.Enabled = false;
                labelGender.Text = cBGTinh.Text;
                cBGTinh.Visible = false;
                labelGender.Visible = true;
                isEdited = false;
            }    
        }

        //Click button Lưu trong groupbox Thông Tin Cá Nhân
        private void BtSaveInfor_Click(object sender, EventArgs e)
        {
            //Lấy thông tin đã sửa đổi 
            acc.Phone1 = tBPhone.Text;
            acc.Birthday1 = dTPBDay.Value;
            acc.Gender1 = cBGTinh.Text;
            acc.Email1 = tBEmail.Text;

            //Kiểm tra email hợp lệ
            if (!IsValidEmail(acc.Email1))
            {
                MessageBox.Show("Thư điện tử của bạn không hợp lệ.", "Lỗi");
                tBEmail.Text = "";
                return;
            }    

            //Lưu thông tin vào database
            if (!controller.saveInfomation(acc, UKEY))
            {
                MessageBox.Show("Đã có lỗi xảy ra!", "Lỗi");
            }    

            //Chỉnh các control sau khi đã Lưu thành công
            tBEmail.ReadOnly = true;
            tBPhone.ReadOnly = true;
            tBEmail.Font = new Font(tBEmail.Font, FontStyle.Italic);
            tBPhone.Font = new Font(tBPhone.Font, FontStyle.Italic);
            BtSaveInfo.Enabled = false;
            labelGender.Text = cBGTinh.Text;
            cBGTinh.Visible = false;
            labelGender.Visible = true;
        }

        //Kiểm tra email đúng dạng
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
