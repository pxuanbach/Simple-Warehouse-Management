﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagement
{
    public partial class UserWelcome : UserControl
    {
        public UserWelcome()
        {
            InitializeComponent();
        }

        private void UserWelcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToLongTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e) // hàm này ko bị gọi,.
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
