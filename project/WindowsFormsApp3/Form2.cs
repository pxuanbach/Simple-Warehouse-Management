using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FSignUp : Form
    {
        public FSignUp()
        {
            InitializeComponent();
            textBox1.ForeColor = Color.LightGray;
            textBox1.Text = "Please Enter Name";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);

            textBox2.ForeColor = Color.LightGray;
            textBox2.Text = "Please Enter Phone Number";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            
            textBox3.ForeColor = Color.LightGray;
            textBox3.Text = "Please Enter User Name";
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);

            textBox4.ForeColor = Color.LightGray;
            textBox4.Text = "Please Enter Password";
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            this.textBox4.PasswordChar = '\u25CF';

            textBox5.ForeColor = Color.LightGray;
            textBox5.Text = "Please Enter Password";
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
            this.textBox5.PasswordChar = '\u25CF';

            textBox6.ForeColor = Color.LightGray;
            textBox6.Text = "Please Enter Code";
            this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
            this.textBox6.Enter += new System.EventHandler(this.textBox6_Enter);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Please Enter Name";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Please Enter Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Please Enter Phone Number")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Please Enter Phone Number";
                textBox2.ForeColor = Color.Gray;
            }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Please Enter User Name")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Please Enter User Name";
                textBox3.ForeColor = Color.Gray;
            }
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Please Enter Password")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Please Enter Password";
                textBox4.ForeColor = Color.Gray;
            }
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Please Enter Password")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Please Enter Password";
                textBox5.ForeColor = Color.Gray;
            }
        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Please Enter Password")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Please Enter Password";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox5.Text != textBox6.Text) //Kiểm tra đã nhập lại mật khẩu đúng hay chưa
            {
                MessageBox.Show("Your RePassword was wrong");
            }

            //Kiểm tra User Name có bị trùng hay không.

            //Kiểm tra mã Code đúng hay chưa ( mã code coi như là UserID mà mình cấp .

            //Vừa để làm khỏa ngoại vừa là công cụ cho mình khi cấp Id cho ngươi dùng.

            this.Close(); // Đóng form này 
            /*
            FLogin f1 = new FLogin();
            f1.MyCode() = textBox6.Text; 
            Đoạn code này để lưu giá trị code của Form2 vào Flogin nhưng không được 
            Ae suy nghĩ cách thêm giá trị vào.
             */
            
        }
    }
}
