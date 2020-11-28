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
    public partial class FLogin : Form
    {
        //tạo 1 đối tượng controller
        Login_Controller login = new Login_Controller();
        public FLogin()
        {
            InitializeComponent();

            //Set textbox Username
            textBoxUName.ForeColor = Color.LightGray;
            textBoxUName.Text = "Enter Username";
            this.textBoxUName.Leave += new System.EventHandler(this.textBoxUName_Leave);
            this.textBoxUName.Enter += new System.EventHandler(this.textBoxUName_Enter);
            //Set textbox Password
            textBoxUPass.ForeColor = Color.LightGray;
            textBoxUPass.Text = "Enter Password";
            this.textBoxUPass.Leave += new System.EventHandler(this.textBoxUPass_Leave);
            this.textBoxUPass.Enter += new System.EventHandler(this.textBoxUPass_Enter);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Click vào button Sign In
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            
            if (textBoxUPass.Text == "" || textBoxUName.Text == "" 
                || textBoxUName.Text == "Enter Username" || textBoxUPass.Text == "Enter Password")  //check trường hợp sai cơ bản
            {
                MessageBox.Show("Something wrong.");
            }
            else
            {
                if (login.checkExistUsername(textBoxUName.Text) == false)   //check Username đã tồn tại chưa? để check Password
                {
                    MessageBox.Show("Username does not exist.");
                }
                else
                {
                    if (login.checkUser(textBoxUName.Text, textBoxUPass.Text) == true)  //check Username và Password đăng nhập đúng ko?
                    {
                        FMain f = new FMain(textBoxUName.Text); 
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect. Please try again.");    //thông báo Password sai
                    }
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
            if (textBoxUName.Text == "")
            {
                textBoxUName.Text = "Enter Username";
                textBoxUName.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox Username
        private void textBoxUName_Enter(object sender, EventArgs e)
        {
            if (textBoxUName.Text == "Enter Username")
            {
                textBoxUName.Text = "";
                textBoxUName.ForeColor = Color.Black;
            }
        }

        //Khi chọn vào textbox Password
        private void textBoxUPass_Enter(object sender, EventArgs e)
        {
            if (textBoxUPass.Text == "Enter Password")
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
                textBoxUPass.Text = "Enter Password";
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
    }
}



