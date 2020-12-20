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
using System.Globalization;

namespace WarehouseManagement
{
    public partial class FLogin : Form
    {
        //tạo 1 đối tượng controller
        Login_Controller controller = new Login_Controller();
        public FLogin()
        {
            InitializeComponent();

            //Set textbox Username
            textBoxUName.ForeColor = Color.Gray;
            textBoxUName.Text = "Nhập tên tài khoản";
            this.textBoxUName.Leave += new System.EventHandler(this.textBoxUName_Leave);
            this.textBoxUName.Enter += new System.EventHandler(this.textBoxUName_Enter);
            //Set textbox Password
            textBoxUPass.ForeColor = Color.Gray;
            textBoxUPass.Text = "Nhập mật khẩu";
            this.textBoxUPass.Leave += new System.EventHandler(this.textBoxUPass_Leave);
            this.textBoxUPass.Enter += new System.EventHandler(this.textBoxUPass_Enter);

            textBoxUPass.KeyPress += TextBoxUPass_KeyPress;
            textBoxUPass.KeyDown += TextBoxUPass_KeyDown;
        }

        private void TextBoxUPass_KeyDown(object sender, KeyEventArgs e)    // Sự kiện ấn nút enter => login
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSignIn.PerformClick();
            }
        }


        private void TextBoxUPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) 
                e.Handled = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }  

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0;
        }

        //Click vào button Sign In
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxUPass.Text == "" || textBoxUName.Text == ""
                || textBoxUName.Text == "Nhập tên tài khoản" || textBoxUPass.Text == "Nhập mật khẩu")  //check trường hợp sai cơ bản
            {
                MessageBox.Show("Có gì đó sai.");
                return;
            }
            else
            {
                if (textBoxUName.Text == "admin" && controller.checkUser(textBoxUName.Text, textBoxUPass.Text) == true)
                {
                    FMain admin = new FMain(textBoxUName.Text, 0);
                    this.Hide();
                    admin.ShowDialog();
                    this.Show();
                }
                else if (controller.checkExistUsername(textBoxUName.Text) == false)   //check Username đã tồn tại chưa? để check Password
                {
                    MessageBox.Show("Tên tài khoản không tồn tại.");
                    return;
                }
                else if (controller.checkUser(textBoxUName.Text, textBoxUPass.Text) == true)  //check Username và Password đăng nhập đúng ko?
                {
                    FMain f = new FMain(textBoxUName.Text, 2);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng. Vui lòng thử lại!");    //thông báo Password sai
                }
            }

        }

        //thoát khỏi ứng dụng
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Khi không chọn vào textbox Username
        private void textBoxUName_Leave(object sender, EventArgs e)
        {
            if (controller.CheckVietKey(textBoxUName.Text) == false)
            {
                textBoxUName.ForeColor = Color.Red;
                textBoxUName.Text = "Không được nhập chữ có dấu";
            }
            if (textBoxUName.Text == "")
            {
                textBoxUName.Text = "Nhập tên tài khoản";
                textBoxUName.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox Username
        private void textBoxUName_Enter(object sender, EventArgs e)
        {
            if ((textBoxUName.Text == "Nhập tên tài khoản")|| (textBoxUName.Text == "Không được nhập chữ có dấu"))
            {
                textBoxUName.Text = "";
                textBoxUName.ForeColor = Color.Black;
            }
        }

        //Khi chọn vào textbox Password
        private void textBoxUPass_Enter(object sender, EventArgs e)
        {
            if (textBoxUPass.Text == "Nhập mật khẩu")
            {
                textBoxUPass.Text = "";
                textBoxUPass.ForeColor = Color.Black;
                this.textBoxUPass.PasswordChar = '\u25CF';
            }
        }

        //Khi không chọn vào textbox Password
        private void textBoxUPass_Leave(object sender, EventArgs e)
        {
            if (textBoxUPass.Text == "")
            {
                this.textBoxUPass.PasswordChar = '\0';
                textBoxUPass.Text = "Nhập mật khẩu";
                textBoxUPass.ForeColor = Color.Gray;

            }
        }

        //Click button Sign Up sẽ chuyển đến form Sign Up
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FSignUp f = new FSignUp();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1 )
            {
                timer1.Stop();
            }
            Opacity += 0.1;
        }
    }
}



