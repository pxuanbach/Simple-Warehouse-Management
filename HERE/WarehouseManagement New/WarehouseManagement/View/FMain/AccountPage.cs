using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement.Controller;
using System.Data.SqlClient;

namespace WarehouseManagement
{
    public partial class AccountUser : UserControl
    {
        //tạo 1 đối tượng controller
        AccountPage_Controller Acc = new AccountPage_Controller();
        public string connectLink = @"Server=LAPTOP-MSFEGU0S\SQLEXPRESS01;Database=WarehouseManagement;User Id=sa;Password=19521334;";

        public AccountUser(string username) //Đầu vào là username từ Main Form
        {
            InitializeComponent();
            MyAccount = username;
            
            TbOldPass.ForeColor = Color.Gray;
            TbOldPass.Text = "Enter Current Password";
            this.TbOldPass.Leave += new System.EventHandler(this.TbOldPass_Leave);
            this.TbOldPass.Enter += new System.EventHandler(this.TbOldPass_Enter);

            TbNewPass.ForeColor = Color.Gray;
            TbNewPass.Text = "Enter New Password";
            this.TbNewPass.Leave += new System.EventHandler(this.TbNewPass_Leave);
            this.TbNewPass.Enter += new System.EventHandler(this.TbNewPass_Enter);

            TbRePass.ForeColor = Color.Gray;
            TbRePass.Text = "Enter Re-Password";
            this.TbRePass.Leave += new System.EventHandler(this.TbRePass_Leave);
            this.TbRePass.Enter += new System.EventHandler(this.TbRePass_Enter);
        }
        public string MyAccount { get; set; }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Load thông tin account từ SQL Server lên page
        private void AccountUser_Load(object sender, EventArgs e)
        {
            #region LoadData lên nhớ vào để đổi link connect. 
           
            string sql_sel_email_position = "Select EMAIL, POSITION, SDT , GIOITINH, HOTEN, BIRTHDAY  From USERACC Where USERNAME = '" + MyAccount + "'";
            
            SqlConnection Conn = new SqlConnection(connectLink);
            SqlCommand Comm1 = new SqlCommand(sql_sel_email_position, Conn);
            Conn.Open();
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                textBoxEmail.Text = DR1.GetValue(0).ToString();
                labelViTri.Text = DR1.GetValue(1).ToString();
                textBoxPNumber.Text = DR1.GetValue(2).ToString();
                comboBoxGTinh.Text = DR1.GetValue(3).ToString();
                labelName.Text = DR1.GetValue(4).ToString();
                dateTimePickerBDay.Value = DR1.GetDateTime(5);
            }
            Conn.Close();
            #endregion 

            textBoxEmail.ReadOnly = true;
            textBoxPNumber.ReadOnly = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

      


        private void TbOldPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbRePass_TextChanged(object sender, EventArgs e)
        {

        }

        //Khi không chọn vào textbox Old Password
        private void TbOldPass_Leave(object sender, EventArgs e)
        {
            if (TbOldPass.Text == "")
            {
                this.TbOldPass.PasswordChar = '\0';
                TbOldPass.Text = "Enter Current Password";
                TbOldPass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox Old Password
        private void TbOldPass_Enter(object sender, EventArgs e)
        {
            if (TbOldPass.Text == "Enter Current Password")
            {
                TbOldPass.Text = "";
                TbOldPass.ForeColor = Color.Black;
                this.TbOldPass.PasswordChar = '\u25CF';
            }
        }

        //Khi không chọn vào textbox New Password
        private void TbNewPass_Leave(object sender, EventArgs e)
        {
            if (TbNewPass.Text == "")
            {
                this.TbNewPass.PasswordChar = '\0';
                TbNewPass.Text = "Enter New Password";
                TbNewPass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox New Password
        private void TbNewPass_Enter(object sender, EventArgs e)
        {
            if (TbNewPass.Text == "Enter New Password")
            {
                TbNewPass.Text = "";
                TbNewPass.ForeColor = Color.Black;
                this.TbNewPass.PasswordChar = '\u25CF';
            }
        }

        //Khi không chọn vào textbox Re-Password
        private void TbRePass_Leave(object sender, EventArgs e)
        {
            if (TbRePass.Text == "")
            {
                this.TbRePass.PasswordChar = '\0';
                TbRePass.Text = "Enter Re-Password";
                TbRePass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox Re-Password
        private void TbRePass_Enter(object sender, EventArgs e)
        {
            if (TbRePass.Text == "Enter Re-Password")
            {
                TbRePass.Text = "";
                TbRePass.ForeColor = Color.Black;
                this.TbRePass.PasswordChar = '\u25CF';
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtSavePass_Click(object sender, EventArgs e)
        {
            Login_Controller account = new Login_Controller();
            AccountPage_Controller acc = new AccountPage_Controller();
            MessageBox.Show("You really change your password ?");
            if (TbNewPass.Text != TbRePass.Text)
            {
                MessageBox.Show("Your re password not correct.");
            }
            else
            {

                if (account.checkUser(MyAccount, TbOldPass.Text) == false)
                {
                    MessageBox.Show("Your old pass was wrong.");
                }
                else
                {
                    acc.changeUserPass(TbOldPass.Text, TbNewPass.Text, MyAccount);
                    MessageBox.Show("Your change successfully");
                    TbNewPass.Text = "";
                    TbOldPass.Text = "";
                    TbRePass.Text = "";
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxEmail.ReadOnly = false;
            textBoxPNumber.ReadOnly = false;
        }

        private void BtSaveInfor_Click(object sender, EventArgs e)
        {

        }
    }
}
