using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement;

namespace WindowsFormsApp3
{
    public partial class FSignUp : Form
    {
        public FSignUp()
        {
            InitializeComponent();
            textBox4.ForeColor = Color.LightGray;
            textBox4.Text = "Please Enter Pass";
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            this.textBox4.PasswordChar = '\u25CF';
            textBox5.ForeColor = Color.LightGray;
            textBox5.Text = "Please Enter Pass";
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
            this.textBox5.PasswordChar = '\u25CF';
        }

        string constring = @"LAPTOP - MSFEGU0S\SQLEXPRESS01;Initial Catalog = WarehouseManagement; User ID = sa";

        SqlConnection connection = new SqlConnection(connString);
        connection.Open(); 
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Please Enter Pass")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Please Enter Pass";
                textBox4.ForeColor = Color.Gray;
            }
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Please Enter Pass")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Please Enter Pass";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Your confirm password is incorrect");
            }

            // Có hàm kiểm tra use name là Check_User kiểm tra xem user có tồn tại hay không

            ListAccount kt = new ListAccount(); // Có thể thay thế class List Account sau khi thêm sql vào.

            if (kt.Check_user(textBox6.Text) == true) 
            {
                MessageBox.Show("Your user name was used ");
            }

            if ( kt.Check_License(textBox6.Text) == false) // Có hàm kiểm tra license là Check_License
            {
                MessageBox.Show("Your lincese is incorrect");
            }

            this.Close(); // Xóa form sau khi add dữ liệu vào

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
