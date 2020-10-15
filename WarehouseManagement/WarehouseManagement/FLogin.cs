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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            textBox1.ForeColor = Color.LightGray;
            textBox1.Text = "Please Enter Name";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);

            textBox2.ForeColor = Color.LightGray;
            textBox2.Text = "Please Enter Address";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.PasswordChar = '\u25CF';
        }
        private string MyCode { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FSignUp f2 = new FSignUp();
            this.Hide();
            f2.ShowDialog();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool kt = true, kt2 = true;
            ListAccount a = new ListAccount();
            kt = a.Check_user(textBox1.Text);
            if (kt == false)
            {
                MessageBox.Show("Your account not exited, Please created your accout ");
            }
            else
            {

                kt2 = a.Check_Pass(textBox2.Text);
                if (kt2 == false)
                {
                    MessageBox.Show("Your password incorrect ");
                }
                else
                {
                    MainForm f3 = new MainForm();
                    //f3.MyProperty = textBox1.Text( User ID) ;
                    f3.ShowDialog();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
            if (textBox2.Text == "Please Enter Address")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Please Enter Address";
                textBox2.ForeColor = Color.Gray;
            }
        }
    }
}


