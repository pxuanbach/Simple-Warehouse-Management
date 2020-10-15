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
    public partial class FMain : Form
    {
        public object OrderUser { get; private set; }

        public FMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Stock_Click(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stockForm1_Load(object sender, EventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stockForm1_Load_1(object sender, EventArgs e)
        {

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
            PanelLeft.Height = BtHelp.Height;
            PanelLeft.Top = BtHelp.Top;
            StPage.Hide();
            OrderPage.Hide();
            StaPage.Hide();
            AccPage.Hide();
            HelpPage.Show();
        }

        private void AccPage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Copyright_Click(object sender, EventArgs e)
        {

        }

        private void AccPage_Load_1(object sender, EventArgs e)
        {

        }

        private void timeDate1_Load(object sender, EventArgs e)
        {

        }
    }
}
