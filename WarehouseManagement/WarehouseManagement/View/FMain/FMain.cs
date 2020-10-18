using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagement
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void buttonSTOCK_Click(object sender, EventArgs e)
        {



        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FMain_Load(object sender, EventArgs e)
        {
            welPage.Show();
            PanelLeft.Hide();
            StPage.Hide();
            OrderPage.Hide();
            StaPage.Hide();
            AccPage.Hide();
            HelpPage.Hide();
        }

        private void buttonORDER_Click(object sender, EventArgs e)
        {

        }

        private void buttonSTATISTICS_Click(object sender, EventArgs e)
        {

        }

        private void buttonACCOUNT_Click(object sender, EventArgs e)
        {

        }

        private void BtStock_Click(object sender, EventArgs e)
        {
            welPage.Hide();
            PanelLeft.Show();
            PanelLeft.Height = BtStock.Height;
            PanelLeft.Top = BtStock.Top;
            StPage.Show();
            OrderPage.Hide();
            StaPage.Hide();
            AccPage.Hide();
            HelpPage.Hide();

        }

        private void panelNhay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtOder_Click(object sender, EventArgs e)
        {
            welPage.Hide();
            PanelLeft.Show();
            PanelLeft.Height = BtOder.Height;
            PanelLeft.Top = BtOder.Top;
            StPage.Hide();
            OrderPage.Show();
            StaPage.Hide();
            AccPage.Hide();
            HelpPage.Hide();
        }

        private void panelL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtSta_Click(object sender, EventArgs e)
        {
            welPage.Hide();
            PanelLeft.Show();
            PanelLeft.Height = BtSta.Height;
            PanelLeft.Top = BtSta.Top;
            StPage.Hide();
            OrderPage.Hide();
            StaPage.Show();
            AccPage.Hide();
            HelpPage.Hide();
        }

        private void BtAcc_Click(object sender, EventArgs e)
        {
            welPage.Hide();
            PanelLeft.Show();
            PanelLeft.Height = BtAcc.Height;
            PanelLeft.Top = BtAcc.Top;
            StPage.Hide();
            OrderPage.Hide();
            StaPage.Hide();
            AccPage.Show();
            HelpPage.Hide();
        }

        private void BtHelp_Click(object sender, EventArgs e)
        {
            welPage.Hide();
            PanelLeft.Show();
            PanelLeft.Height = BtAbout.Height;
            PanelLeft.Top = BtAbout.Top;
            StPage.Hide();
            OrderPage.Hide();
            StaPage.Hide();
            AccPage.Hide();
            HelpPage.Show();
        }

        private void BtLogout_Click(object sender, EventArgs e)
        {

        }
    }
}   
