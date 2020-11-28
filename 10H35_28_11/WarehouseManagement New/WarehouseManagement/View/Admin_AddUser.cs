using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using WarehouseManagement.Controller;
using System.Drawing.Text;

namespace WarehouseManagement
{
    public partial class Admin_AddUser : Form
    {
        Admin_Controller ad = new Admin_Controller();
        public Admin_AddUser(int ukey)
        {
            InitializeComponent();
        }
        
        private void Admin_AddUser_Load(object sender, EventArgs e)
        {

        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ad.them_UKEY( Convert.ToInt32(textBoxUkey.Text) );
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
