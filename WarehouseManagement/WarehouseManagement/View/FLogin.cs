﻿using System;
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
    public partial class FLogin : Form
    {
        Login_Controller login = new Login_Controller();
        public FLogin()
        {
            InitializeComponent();
            textBoxUName.ForeColor = Color.LightGray;
            textBoxUName.Text = "Please Enter Name";
            this.textBoxUName.Leave += new System.EventHandler(this.textBoxUName_Leave);
            this.textBoxUName.Enter += new System.EventHandler(this.textBoxUName_Enter);

            textBoxUPass.ForeColor = Color.LightGray;
            textBoxUPass.Text = "Please Enter Address";
            this.textBoxUPass.Leave += new System.EventHandler(this.textBoxUPass_Leave);
            this.textBoxUPass.Enter += new System.EventHandler(this.textBoxUPass_Enter);
            this.textBoxUPass.PasswordChar = '\u25CF';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            FMain f = new FMain();
            if (textBoxUPass.Text == "" || textBoxUName.Text == "")
            {
                MessageBox.Show("Something wrong.");
            }
            else
            {
                if (login.checkExistUsername(textBoxUName.Text) == false)
                {
                    MessageBox.Show("Username does not exist.");
                }
                else
                {
                    if (login.checkUser(textBoxUName.Text, textBoxUPass.Text) == true)
                    {
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect. Please try again.");
                    }
                }
            }    
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUName_Leave(object sender, EventArgs e)
        {
            if (textBoxUName.Text == "")
            {
                textBoxUName.Text = "Enter Name";
                textBoxUName.ForeColor = Color.Gray;
            }
        }

        private void textBoxUName_Enter(object sender, EventArgs e)
        {
            if (textBoxUName.Text == "Please Enter Name")
            {
                textBoxUName.Text = "";
                textBoxUName.ForeColor = Color.Black;
            }
        }

        private void textBoxUPass_Enter(object sender, EventArgs e)
        {
            if (textBoxUPass.Text == "Please Enter Address")
            {
                textBoxUPass.Text = "";
                textBoxUPass.ForeColor = Color.Black;
            }
        }

        private void textBoxUPass_Leave(object sender, EventArgs e)
        {
            if (textBoxUPass.Text == "")
            {
                textBoxUPass.Text = "Please Enter Address";
                textBoxUPass.ForeColor = Color.Gray;
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FSignUp f = new FSignUp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}


