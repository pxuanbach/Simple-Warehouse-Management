using System;
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
    public partial class HelpUser : UserControl
    {
        public HelpUser()
        {
            InitializeComponent();
        }

        private void BtFb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/xuanbach.pham.10/");
        }
    }
}