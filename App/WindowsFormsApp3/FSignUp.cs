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
            TbUserName.Text = "Enter User Name";
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                TbUserName.Text = "Enter User Name";
                TbUserName.ForeColor = Color.Gray;
            }
        }

        private void TbUserName_Enter(object sender, EventArgs e)
        {
            if (TbUserName.Text == "Enter User Name")
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
            }
        }

        private void TbPass_Leave(object sender, EventArgs e)
        {
            if (TbPass.Text == "")
            {
                TbPass.Text = "Enter Password";
                TbPass.ForeColor = Color.Gray;
            }
        }

        private void TbRePass_Leave(object sender, EventArgs e)
                    {
                        if (TbRePass.Text == "")
                        {
                            TbRePass.Text = "Enter Password Again";
                            TbRePass.ForeColor = Color.Gray;
                        }
                    } 

        private void TbRePass_Enter(object sender, EventArgs e)
        {
            if (TbRePass.Text == "Enter Password Again")
            {
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
         
}
