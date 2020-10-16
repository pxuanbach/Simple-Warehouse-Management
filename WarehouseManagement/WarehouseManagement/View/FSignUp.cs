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

        public static String connString = @"Server=LAPTOP-MSFEGU0S\SQLEXPRESS01;Database=WarehouseManagement;User Id=sa;Password=19521334;";
        

        //ket noi csdl bang Sqlconnection 



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

            

            SqlConnection connection = new SqlConnection(connString);
            try
            {

                //Mo ket noi
                connection.Open();
                //Tạo hàm chech_user 
                bool Check_User = false;
                //Chuan bi cau lenh query viet bang SQL  
                String sqlQuery = "select USERACCOUNT.USERNAME, USERACCOUNT.PASSWORD from USERACCOUNT where USERNAME = '" + textBox3.Text + "'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    if (reader.Read() == false) break;
                    Check_User = true;
                }
                connection.Close();
                if (Check_User == true)
                {
                    MessageBox.Show("Your account was created ");
                    
                }
                else
                {
                    // insert vào bảng USERACCOUNT 
                    connection.Open();
                    string sqlQuery1 = "insert into USERACCOUNT values ('" + textBox3.Text + "','" + textBox4.Text + "')";
                    SqlCommand command1 = new SqlCommand(sqlQuery1, connection);
                    command1.ExecuteReader();
                    MessageBox.Show("Your account created successfully ");

                    // insert vào bảng STOCK
                    // Chờ code của bảng STOCK hoàn thiện 
                    connection.Close();
                }
                
                
                
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                //xu ly khi ket noi co van de
                //MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                
            }

            



            this.Close(); // Xóa form sau khi add dữ liệu vào

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
