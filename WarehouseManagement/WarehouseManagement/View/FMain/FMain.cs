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
            //panelNhay.Height = buttonSTOCK.Height;
            panelNhay.Top = buttonSTOCK.Top + 3;
            StockPage.Show();
            AccPage.Hide();
            HelpUserPage.Hide();
            OrderPage.Hide();
            StatisticsPage.Hide();
            UserPage.Hide();

        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            StockPage.Show();
            AccPage.Hide();
            HelpUserPage.Hide();
            OrderPage.Hide();
            StatisticsPage.Hide();
            UserPage.Hide();
        }

        private void buttonORDER_Click(object sender, EventArgs e)
        {
            //panelNhay.Height = buttonORDER.Height;
            panelNhay.Top = buttonORDER.Top + 3;
            StockPage.Hide();
            AccPage.Hide();
            HelpUserPage.Hide();
            OrderPage.Show();
            StatisticsPage.Hide();
            UserPage.Hide();
        }

        private void buttonSTATISTICS_Click(object sender, EventArgs e)
        {
            //panelNhay.Height = buttonSTATISTICS.Height;
            panelNhay.Top = buttonSTATISTICS.Top + 3;
            StockPage.Hide();
            AccPage.Hide();
            HelpUserPage.Hide();
            OrderPage.Hide();
            StatisticsPage.Show();
            UserPage.Hide();
        }

        private void buttonACCOUNT_Click(object sender, EventArgs e)
        {
            //panelNhay.Height = buttonACCOUNT.Height;
            panelNhay.Top = buttonACCOUNT.Top + 3;
            StockPage.Hide();
            AccPage.Show();
            HelpUserPage.Hide();
            OrderPage.Hide();
            StatisticsPage.Hide();
            UserPage.Hide();
        }
    }
}
