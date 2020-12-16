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
            TbName.ForeColor = Color.Gray;
            TbName.Text = "Nhập họ tên";
            this.TbName.Leave += new System.EventHandler(this.TbName_Leave);
            this.TbName.Enter += new System.EventHandler(this.TbName_Enter);

            TbPhone.ForeColor = Color.Gray;
            TbPhone.Text = "Nhập số điện thoại";
            this.TbPhone.Leave += new System.EventHandler(this.TbPhone_Leave);
            this.TbPhone.Enter += new System.EventHandler(this.TbPhone_Enter);

            TbPass.ForeColor = Color.Gray;
            TbPass.Text = "Nhập mật khẩu";
            this.TbPass.Leave += new System.EventHandler(this.TbPass_Leave);
            this.TbPass.Enter += new System.EventHandler(this.TbPass_Enter);

            TbRePass.ForeColor = Color.Gray;
            TbRePass.Text = "Xác nhận lại mật khẩu";
            this.TbRePass.Leave += new System.EventHandler(this.TbRePass_Leave);
            this.TbRePass.Enter += new System.EventHandler(this.TbRePass_Enter);

            TbUserName.ForeColor = Color.Gray;
            TbUserName.Text = "Nhập tên tài khoản";
            this.TbUserName.Leave += new System.EventHandler(this.TbUserName_Leave);
            this.TbUserName.Enter += new System.EventHandler(this.TbUserName_Enter);

            TbKey.ForeColor = Color.Gray;
            TbKey.Text = "Nhập mã bản quyền";
            this.TbKey.Leave += new System.EventHandler(this.TbKey_Leave);
            this.TbKey.Enter += new System.EventHandler(this.TbKey_Enter);
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
            if (TbName.Text == "")
            {
                TbName.Text = "Nhập họ tên";
                TbName.ForeColor = Color.Gray;
            }
        }

        private void TbName_Enter(object sender, EventArgs e)
        {
            if (TbName.Text == "Nhập họ tên")
            {
                TbName.Text = "";
                TbName.ForeColor = Color.Black;
            }
        }

        private void TbUserName_Leave(object sender, EventArgs e)
        {
            if (controller.CheckVietKey(TbUserName.Text) == false)
            {
                TbUserName.ForeColor = Color.Red;
                TbUserName.Text = "Không được nhập chữ có dấu";
            }
            if (TbUserName.Text == "")
            {
                TbUserName.Text = "Nhập tên tài khoản";
                TbUserName.ForeColor = Color.Gray;
            }
        }

        private void TbUserName_Enter(object sender, EventArgs e)
        {
            if ((TbUserName.Text == "Nhập tên tài khoản") || (TbUserName.Text == "Không được nhập chữ có dấu"))
            {
                TbUserName.Text = "";
                TbUserName.ForeColor = Color.Black;
            }
        }

        private void TbPhone_Leave(object sender, EventArgs e)
        {
            if (TbPhone.Text == "")
            {
                TbPhone.Text = "Nhập số điện thoại";
                TbPhone.ForeColor = Color.Gray;
            }
        }

        private void TbPhone_Enter(object sender, EventArgs e)
        {
            if (TbPhone.Text == "Nhập số điện thoại")
            {
                TbPhone.Text = "";
                TbPhone.ForeColor = Color.Black;
            }
        }

        private void TbPass_Enter(object sender, EventArgs e)
        {
            if (TbPass.Text == "Nhập mật khẩu")
            {
                TbPass.Text = "";
                TbPass.ForeColor = Color.Black;
                this.TbPass.PasswordChar = '\u25CF';
            }
        }

        private void TbPass_Leave(object sender, EventArgs e)
        {
            if (TbPass.Text == "")
            {
                this.TbPass.PasswordChar = '\0';
                TbPass.Text = "Nhập mật khẩu";
                TbPass.ForeColor = Color.Gray;
            }
        }

        private void TbRePass_Leave(object sender, EventArgs e)
        {
            if (TbRePass.Text == "")
            {
                this.TbRePass.PasswordChar = '\0';
                TbRePass.Text = "Xác nhận lại mật khẩu";
                TbRePass.ForeColor = Color.Gray;
            }
        }

        private void TbRePass_Enter(object sender, EventArgs e)
        {
            if (TbRePass.Text == "Xác nhận lại mật khẩu")
            {
                this.TbRePass.PasswordChar = '\u25CF';               
                TbRePass.Text = "";
                TbRePass.ForeColor = Color.Black;
            }
        }


        private void TbKey_Leave(object sender, EventArgs e)
        {
            if (TbKey.Text == "")
            {
                TbKey.Text = "Nhập mã bản quyền";
                TbKey.ForeColor = Color.Gray;
            }
        }

        private void TbKey_Enter(object sender, EventArgs e)
        {
            if (TbKey.Text == "Nhập mã bản quyền")
            {
                TbKey.Text = "";
                TbKey.ForeColor = Color.Black;
            }
        }
        #endregion

        public bool checkNull(string TEN, string SDT, string USERNAME, string PASS, string RE_PASS, string UKEY)
        {
            bool ck = true;
            if (TEN == "" || SDT == "" || USERNAME == "" || PASS == "" || RE_PASS == "" || UKEY == "")
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
            if (checkNull(TbName.Text, TbPhone.Text,TbUserName.Text, TbPass.Text, TbRePass.Text, TbKey.Text) == false)
            {
                MessageBox.Show("Có gì đó sai.");
            }    
            else
            {
                if (controller.CheckUserExist(TbUserName.Text) == true)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng thử tên khác!");
                }   
                else
                { 
                    if (controller.CheckRePassword(TbPass.Text, TbRePass.Text) == false)
                    {
                        MessageBox.Show("Xác nhận lại mật khẩu không chính xác.");
                    }    
                    else
                    {
                        if (!controller.checkUkeyExist(TbKey.Text))
                        {
                            MessageBox.Show("Mã bản quyền không tồn tại.");
                            return;
                        }    
                        if (controller.SignUpAccount(TbName.Text, TbPhone.Text, TbUserName.Text, TbPass.Text, Convert.ToInt32(TbKey.Text)) == true)
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
            TbPhone.KeyPress += textBox_KeyPress;
        }

        private void TbKey_TextChanged(object sender, EventArgs e)
        {
            TbKey.KeyPress += textBox_KeyPress;
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
