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
            textBoxUName.ForeColor = Color.LightGray;
            textBoxUName.Text = "Please Enter Name";
            this.textBoxUName.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBoxUName.Enter += new System.EventHandler(this.textBox1_Enter);

            textBoxUPass.ForeColor = Color.LightGray;
            textBoxUPass.Text = "Please Enter Address";
            this.textBoxUPass.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBoxUPass.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBoxUPass.PasswordChar = '\u25CF';
        }
        private string MyCode { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBoxUName.Text == "")
            {
                textBoxUName.Text = "Please Enter Name";
                textBoxUName.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBoxUName.Text == "Please Enter Name")
            {
                textBoxUName.Text = "";
                textBoxUName.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBoxUPass.Text == "Please Enter Address")
            {
                textBoxUPass.Text = "";
                textBoxUPass.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBoxUPass.Text == "")
            {
                textBoxUPass.Text = "Please Enter Address";
                textBoxUPass.ForeColor = Color.Gray;
            }
        }
    }
}
