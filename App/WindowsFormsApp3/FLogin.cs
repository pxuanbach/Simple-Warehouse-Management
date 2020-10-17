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
            UserText.ForeColor = Color.LightGray;
            UserText.Text = "Please Enter Name";
            this.UserText.Leave += new System.EventHandler(this.textBox1_Leave);
            this.UserText.Enter += new System.EventHandler(this.textBox1_Enter);

            textBox2.ForeColor = Color.LightGray;
            textBox2.Text = "Please Enter Address";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.PasswordChar =  '\u25CF';
        }

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
            FMain f3 = new FMain();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (UserText.Text == "")
            {
                UserText.Text = "Please Enter Name";
                UserText.ForeColor = Color.Gray;
            }
         }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (UserText.Text == "Please Enter Name")
            {
                UserText.Text = "";
                UserText.ForeColor = Color.Black;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


