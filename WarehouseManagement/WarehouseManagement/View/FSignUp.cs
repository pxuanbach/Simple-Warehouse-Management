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
    public partial class FSignUp : Form
    {
        SignUp_Controller signUp = new SignUp_Controller();
        public FSignUp()
        {
            InitializeComponent();
            TbName.ForeColor = Color.Gray;
            TbName.Text = "Enter Name";
            this.TbName.Leave += new System.EventHandler(this.TbName_Leave);
            this.TbName.Enter += new System.EventHandler(this.tbName_Enter);

            TbPhone.ForeColor = Color.Gray;
            TbPhone.Text = "Enter Your Phone Number";
            this.TbPhone.Leave += new System.EventHandler(this.TbPhone_Leave);
            this.TbPhone.Enter += new System.EventHandler(this.TbPhone_Enter);

            TbPass.ForeColor = Color.Gray;
            TbPass.Text = "Enter Password";
            this.TbPass.Leave += new System.EventHandler(this.TbPass_Leave);
            this.TbPass.Enter += new System.EventHandler(this.TbPass_Enter);

            TbRePass.ForeColor = Color.Gray;
            TbRePass.Text = "Enter Password Again";
            this.TbRePass.Leave += new System.EventHandler(this.TbRePass_Leave);
            this.TbRePass.Enter += new System.EventHandler(this.TbRePass_Enter);

            TbUserName.ForeColor = Color.Gray;
            TbUserName.Text = "Enter Username";
            this.TbUserName.Leave += new System.EventHandler(this.TbUserName_Leave);
            this.TbUserName.Enter += new System.EventHandler(this.TbUserName_Enter);



            TbKey.ForeColor = Color.Gray;
            TbKey.Text = "Enter License Key";
            this.TbKey.Leave += new System.EventHandler(this.TbKey_Leave);
            this.TbKey.Enter += new System.EventHandler(this.TbKey_Enter);


        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbName_Leave(object sender, EventArgs e)
        {
            if (TbName.Text == "")
            {
                TbName.Text = "Enter Name";
                TbName.ForeColor = Color.Gray;
            }
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            if (TbName.Text == "Enter Name")
            {
                TbName.Text = "";
                TbName.ForeColor = Color.Black;
            }
        }

        private void TbUserName_Leave(object sender, EventArgs e)
        {
            if (TbUserName.Text == "")
            {
                TbUserName.Text = "Enter Username";
                TbUserName.ForeColor = Color.Gray;
            }
        }

        private void TbUserName_Enter(object sender, EventArgs e)
        {
            if (TbUserName.Text == "Enter Username")
            {
                TbUserName.Text = "";
                TbUserName.ForeColor = Color.Black;
            }
        }

        private void TbPhone_Leave(object sender, EventArgs e)
        {
            if (TbPhone.Text == "")
            {
                TbPhone.Text = "Enter Your Phone Number";
                TbPhone.ForeColor = Color.Gray;
            }
        }

        private void TbPhone_Enter(object sender, EventArgs e)
        {
            if (TbPhone.Text == "Enter Your Phone Number")
            {
                TbPhone.Text = "";
                TbPhone.ForeColor = Color.Black;
            }
        }

        private void TbPass_Enter(object sender, EventArgs e)
        {
            if (TbPass.Text == "Enter Password")
            {
                TbPass.Text = "";
                TbPass.ForeColor = Color.Black;
                this.TbPass.PasswordChar = '\u25CF';
            }
        }

        private void TbPass_Leave(object sender, EventArgs e)
        {
            if (TbPass.Text == "")
            {
                this.TbPass.PasswordChar = '\0';
                TbPass.Text = "Enter Password";
                TbPass.ForeColor = Color.Gray;
            }
        }

        private void TbRePass_Leave(object sender, EventArgs e)
        {
            if (TbRePass.Text == "")
            {
                this.TbRePass.PasswordChar = '\0';
                TbRePass.Text = "Enter Password Again";
                TbRePass.ForeColor = Color.Gray;
            }
        }

        private void TbRePass_Enter(object sender, EventArgs e)
        {
            if (TbRePass.Text == "Enter Password Again")
            {
                this.TbRePass.PasswordChar = '\u25CF';               
                TbRePass.Text = "";
                TbRePass.ForeColor = Color.Black;
            }
        }


        private void TbKey_Leave(object sender, EventArgs e)
        {
            if (TbKey.Text == "")
            {
                TbKey.Text = "Enter License Key";
                TbKey.ForeColor = Color.Gray;
            }
        }

        private void TbKey_Enter(object sender, EventArgs e)
        {
            if (TbKey.Text == "Enter License Key")
            {
                TbKey.Text = "";
                TbKey.ForeColor = Color.Black;
            }
        }

        public bool checkNull(string TEN, string SDT, string USERNAME, string PASS, string RE_PASS, string UKEY)
        {
            bool ck = true;
            if (TEN == "" || SDT == "" || USERNAME == "" || PASS == "" || RE_PASS == "" || UKEY == "")
            {
                ck = false;
            }
            else if (TEN == "Enter Name" || SDT == "Enter Your Phone Number" 
                || USERNAME == "Enter Username" || PASS == "Enter Password" 
                || RE_PASS == "Enter Password Again" || UKEY == "Enter License Key")
            {
                ck = false;
            }
            return ck;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (checkNull(TbName.Text, TbPhone.Text,TbUserName.Text, TbPass.Text, TbRePass.Text, TbKey.Text) == false)
            {
                MessageBox.Show("Something wrong.");
            }    
            else
            {
                if (signUp.CheckUserExist(TbUserName.Text) == true)
                {
                    MessageBox.Show("Username was existed. Please try another one!");
                }   
                else
                { 
                    if (signUp.CheckRePassword(TbPass.Text, TbRePass.Text) == false)
                    {
                        MessageBox.Show("Re-password is incorrect.");
                    }    
                    else
                    {
                        if (signUp.SignUpAccount(TbName.Text, TbPhone.Text, TbUserName.Text, TbPass.Text, Convert.ToInt32(TbKey.Text)) == true)
                        {
                            MessageBox.Show("Account created successfully!");
                            this.Close(); // Xóa form sau khi add dữ liệu vào
                        }
                        else
                        {
                            MessageBox.Show("Something wrong.");
                        }    
                    }    
                }    
            }    
        }
    }

}
