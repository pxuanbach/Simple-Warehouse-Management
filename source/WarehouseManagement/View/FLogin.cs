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
            tBUName.ForeColor = Color.Gray;
            tBUName.Text = "Nhập tên tài khoản";
            this.tBUName.Leave += new System.EventHandler(this.textBoxUName_Leave);
            this.tBUName.Enter += new System.EventHandler(this.textBoxUName_Enter);
            //Set textbox Password
            tBUPass.ForeColor = Color.Gray;
            tBUPass.Text = "Nhập mật khẩu";
            this.tBUPass.Leave += new System.EventHandler(this.textBoxUPass_Leave);
            this.tBUPass.Enter += new System.EventHandler(this.textBoxUPass_Enter);

            tBUPass.KeyPress += TextBoxUPass_KeyPress;
            tBUPass.KeyDown += TextBoxUPass_KeyDown;
        }

        private void TextBoxUPass_KeyDown(object sender, KeyEventArgs e)    // Sự kiện ấn nút enter => login
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtSignIn.PerformClick();
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
            if (tBUPass.Text == "" || tBUName.Text == ""
                || tBUName.Text == "Nhập tên tài khoản" || tBUPass.Text == "Nhập mật khẩu")  //check trường hợp sai cơ bản
            {
                MessageBox.Show("Có gì đó sai.");
                return;
            }
            else
            {
                if (controller.checkExistUsername(tBUName.Text) == false)   //check Username đã tồn tại chưa? để check Password
                {
                    MessageBox.Show("Tên tài khoản không tồn tại.");
                    return;
                }  
                else if (controller.checkUser(tBUName.Text, tBUPass.Text) == true)  //check Username và Password đăng nhập đúng ko?
                {
                    int KEY = controller.GetUkey(tBUName.Text);
                    int n = controller.getPosition(KEY.ToString());

                    if (n == 0)
                    {
                        FMain admin = new FMain(tBUName.Text, KEY, 0);
                        this.Hide();
                        admin.ShowDialog();
                        this.Show();
                    }   
                    else
                    {
                        if (controller.getStatus(KEY.ToString()) == 0)
                        {
                            MessageBox.Show("Tài khoản của bạn đã bị chặn." +
                                            "\nNếu có bất kì thắc mắc nào vui lòng liên hệ Quản trị viên." +
                                            "\nHoặc liên hệ công ty qua: BDTCompanyUIT@gmail.com");
                            return;
                        }
                        FMain f = new FMain(tBUName.Text, KEY, n);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }    
                    
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
            if (controller.CheckVietKey(tBUName.Text) == false)
            {
                tBUName.ForeColor = Color.Red;
                tBUName.Text = "Không được nhập chữ có dấu";
            }
            if (tBUName.Text == "")
            {
                tBUName.Text = "Nhập tên tài khoản";
                tBUName.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox Username
        private void textBoxUName_Enter(object sender, EventArgs e)
        {
            if ((tBUName.Text == "Nhập tên tài khoản")|| (tBUName.Text == "Không được nhập chữ có dấu"))
            {
                tBUName.Text = "";
                tBUName.ForeColor = Color.Black;
            }
        }

        //Khi chọn vào textbox Password
        private void textBoxUPass_Enter(object sender, EventArgs e)
        {
            if (tBUPass.Text == "Nhập mật khẩu")
            {
                tBUPass.Text = "";
                tBUPass.ForeColor = Color.Black;
                this.tBUPass.PasswordChar = '\u25CF';
            }
        }

        //Khi không chọn vào textbox Password
        private void textBoxUPass_Leave(object sender, EventArgs e)
        {
            if (tBUPass.Text == "")
            {
                this.tBUPass.PasswordChar = '\0';
                tBUPass.Text = "Nhập mật khẩu";
                tBUPass.ForeColor = Color.Gray;

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



