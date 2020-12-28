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
    public partial class FSignUp : Form
    {
        SignUp_Controller controller = new SignUp_Controller();
        public FSignUp()
        {
            InitializeComponent();

            #region Tùy chỉnh textbox
            tBName.ForeColor = Color.Gray;
            tBName.Text = "Nhập họ tên";
            this.tBName.Leave += new System.EventHandler(this.TbName_Leave);
            this.tBName.Enter += new System.EventHandler(this.TbName_Enter);

            tBPhone.ForeColor = Color.Gray;
            tBPhone.Text = "Nhập số điện thoại";
            this.tBPhone.Leave += new System.EventHandler(this.TbPhone_Leave);
            this.tBPhone.Enter += new System.EventHandler(this.TbPhone_Enter);

            tBPass.ForeColor = Color.Gray;
            tBPass.Text = "Nhập mật khẩu";
            this.tBPass.Leave += new System.EventHandler(this.TbPass_Leave);
            this.tBPass.Enter += new System.EventHandler(this.TbPass_Enter);

            tBRePass.ForeColor = Color.Gray;
            tBRePass.Text = "Xác nhận lại mật khẩu";
            this.tBRePass.Leave += new System.EventHandler(this.TbRePass_Leave);
            this.tBRePass.Enter += new System.EventHandler(this.TbRePass_Enter);

            tBUserName.ForeColor = Color.Gray;
            tBUserName.Text = "Nhập tên tài khoản";
            this.tBUserName.Leave += new System.EventHandler(this.TbUserName_Leave);
            this.tBUserName.Enter += new System.EventHandler(this.TbUserName_Enter);

            tBKey.ForeColor = Color.Gray;
            tBKey.Text = "Nhập mã bản quyền";
            this.tBKey.Leave += new System.EventHandler(this.TbKey_Leave);
            this.tBKey.Enter += new System.EventHandler(this.TbKey_Enter);
            #endregion

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Sự kiện Enter và Leave của các textbox
        private void TbName_Leave(object sender, EventArgs e)
        {
            if (tBName.Text == "")
            {
                tBName.Text = "Nhập họ tên";
                tBName.ForeColor = Color.Gray;
            }
        }

        private void TbName_Enter(object sender, EventArgs e)
        {
            if (tBName.Text == "Nhập họ tên")
            {
                tBName.Text = "";
                tBName.ForeColor = Color.Black;
            }
        }

        private void TbUserName_Leave(object sender, EventArgs e)
        {
            if (controller.CheckVietKey(tBUserName.Text) == false)
            {
                tBUserName.ForeColor = Color.Red;
                tBUserName.Text = "Không được nhập chữ có dấu";
            }
            if (tBUserName.Text == "")
            {
                tBUserName.Text = "Nhập tên tài khoản";
                tBUserName.ForeColor = Color.Gray;
            }
        }

        private void TbUserName_Enter(object sender, EventArgs e)
        {
            if ((tBUserName.Text == "Nhập tên tài khoản") || (tBUserName.Text == "Không được nhập chữ có dấu"))
            {
                tBUserName.Text = "";
                tBUserName.ForeColor = Color.Black;
            }
        }

        private void TbPhone_Leave(object sender, EventArgs e)
        {
            if (tBPhone.Text == "")
            {
                tBPhone.Text = "Nhập số điện thoại";
                tBPhone.ForeColor = Color.Gray;
            }
        }

        private void TbPhone_Enter(object sender, EventArgs e)
        {
            if (tBPhone.Text == "Nhập số điện thoại")
            {
                tBPhone.Text = "";
                tBPhone.ForeColor = Color.Black;
            }
        }

        private void TbPass_Enter(object sender, EventArgs e)
        {
            if (tBPass.Text == "Nhập mật khẩu")
            {
                tBPass.Text = "";
                tBPass.ForeColor = Color.Black;
                this.tBPass.PasswordChar = '\u25CF';
            }
        }

        private void TbPass_Leave(object sender, EventArgs e)
        {
            if (tBPass.Text == "")
            {
                this.tBPass.PasswordChar = '\0';
                tBPass.Text = "Nhập mật khẩu";
                tBPass.ForeColor = Color.Gray;
            }
        }

        private void TbRePass_Leave(object sender, EventArgs e)
        {
            if (tBRePass.Text == "")
            {
                this.tBRePass.PasswordChar = '\0';
                tBRePass.Text = "Xác nhận lại mật khẩu";
                tBRePass.ForeColor = Color.Gray;
            }
        }

        private void TbRePass_Enter(object sender, EventArgs e)
        {
            if (tBRePass.Text == "Xác nhận lại mật khẩu")
            {
                this.tBRePass.PasswordChar = '\u25CF';               
                tBRePass.Text = "";
                tBRePass.ForeColor = Color.Black;
            }
        }


        private void TbKey_Leave(object sender, EventArgs e)
        {
            if (tBKey.Text == "")
            {
                tBKey.Text = "Nhập mã bản quyền";
                tBKey.ForeColor = Color.Gray;
            }
        }

        private void TbKey_Enter(object sender, EventArgs e)
        {
            if (tBKey.Text == "Nhập mã bản quyền")
            {
                tBKey.Text = "";
                tBKey.ForeColor = Color.Black;
            }
        }
        #endregion

        bool allCharactersSame(string s, char c)
        {
            int n = s.Length;
            for (int i = 0; i < n; i++)
                if (s[i] != c)
                    return false;

            return true;
        }

        public bool checkNull(string TEN, string SDT, string USERNAME, string PASS, string RE_PASS, string UKEY)
        {
            bool ck = true;
            if (TEN == "" || SDT == "" || USERNAME == "" || PASS == "" || RE_PASS == "" || UKEY == "")
            {
                ck = false;
            }
            else if ((allCharactersSame(TEN, ' ') == true)||(allCharactersSame(USERNAME, ' ') == true)
                ||(allCharactersSame(PASS, ' ') == true)||(allCharactersSame(RE_PASS, ' ') == true)
                ||(allCharactersSame(UKEY, ' ') == true))
            {
                ck = false;
            }    
            else if (TEN == "Nhập họ tên" || SDT == "Nhập số điện thoại"
                || USERNAME == "Nhập tên tài khoản" || PASS == "Nhập mật khẩu"
                || RE_PASS == "Xác nhận lại mật khẩu" || UKEY == "Nhập mã bản quyền")
            {
                ck = false;
            }
            return ck;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (checkNull(tBName.Text, tBPhone.Text,tBUserName.Text, tBPass.Text, tBRePass.Text, tBKey.Text) == false)
            {
                MessageBox.Show("Thông tin đăng kí không hợp lệ.");
            }    
            else
            {
                if (controller.CheckUserExist(tBUserName.Text) == true)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng thử tên khác!");
                }   
                else
                { 
                    if (controller.CheckRePassword(tBPass.Text, tBRePass.Text) == false)
                    {
                        MessageBox.Show("Xác nhận lại mật khẩu không chính xác.");
                    }    
                    else
                    {
                        if (!controller.checkUkeyExist(tBKey.Text))
                        {
                            MessageBox.Show("Mã bản quyền không tồn tại.");
                            return;
                        }
                        else if (controller.getUsername(tBKey.Text) != "")
                        {
                            MessageBox.Show("Mã bản quyền đã sử dụng cho tài khoản khác.");
                            return;
                        }    
                        if (controller.SignUpAccount(tBName.Text, tBPhone.Text, tBUserName.Text, tBPass.Text, Convert.ToInt32(tBKey.Text)) == true)
                        {
                            MessageBox.Show("Tài khoản đã được tạo thành công!");
                            this.Close(); // Quay lại form login sau khi add account vào database
                        }
                        else
                        {
                            MessageBox.Show("Có gì đó sai.");
                        }    
                    }    
                }    
            }    
        }

        private void TbPhone_TextChanged(object sender, EventArgs e)
        {
            tBPhone.KeyPress += textBox_KeyPress;
        }

        private void TbKey_TextChanged(object sender, EventArgs e)
        {
            tBKey.KeyPress += textBox_KeyPress;
        }

        //Bắt sự kiện khi nhấn phím bất kì, chỉ cho phép nhập các phím số và phím control (để Backspace được)
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }
    }

}
