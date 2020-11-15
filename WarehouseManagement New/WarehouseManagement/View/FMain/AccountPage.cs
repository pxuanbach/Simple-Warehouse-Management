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

namespace WarehouseManagement
{
    public partial class AccountUser : UserControl
    {
        //tạo 1 đối tượng controller
        AccountPage_Controller Acc = new AccountPage_Controller();

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
            string[] DataAccount = new string[10];
            DataAccount = Acc.GetDataAcc(MyAccount);
            labelName.Text = DataAccount[0];
            textBoxPNumber.Text = DataAccount[1];
            //comboBoxGTinh.Text = DataAccount[2];
            //textBoxEmail.Text = DataAccount[3];
            //labelViTri.Text = DataAccount[4];
            //dateTimePickerBDay.Value = Acc.BIRTHDAY(MyAccount);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //FChangePassword a = new FChangePassword();
            //this.Hide();
            //a.ShowDialog();
            //this.Show();
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
            if (TbOldPass.Text == "")
            {
                this.TbOldPass.PasswordChar = '\0';
                TbOldPass.Text = "Enter New Password";
                TbOldPass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox New Password
        private void TbNewPass_Enter(object sender, EventArgs e)
        {
            if (TbOldPass.Text == "Enter New Password")
            {
                TbOldPass.Text = "";
                TbOldPass.ForeColor = Color.Black;
                this.TbOldPass.PasswordChar = '\u25CF';
            }
        }

        //Khi không chọn vào textbox Re-Password
        private void TbRePass_Leave(object sender, EventArgs e)
        {
            if (TbOldPass.Text == "")
            {
                this.TbOldPass.PasswordChar = '\0';
                TbOldPass.Text = "Enter Re-Password";
                TbOldPass.ForeColor = Color.Gray;
            }
        }

        //Khi chọn vào textbox Re-Password
        private void TbRePass_Enter(object sender, EventArgs e)
        {
            if (TbOldPass.Text == "Enter Re-Password")
            {
                TbOldPass.Text = "";
                TbOldPass.ForeColor = Color.Black;
                this.TbOldPass.PasswordChar = '\u25CF';
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
