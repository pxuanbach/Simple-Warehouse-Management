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
    public partial class FMain : Form
    {
        MainForm_Controller main = new MainForm_Controller();
        public FMain()
        {
            InitializeComponent();
            
            
        }
        public string GetUsername(string username)
        {
            return username;
        }
        public string MyUserName { get; set; }
        //public int MyUkey { get; set; }
        //public UserWelcome pgWelcome;
        //public StockPage pg;




        private void FMain_Load(object sender, EventArgs e)
        {
            UserWelcome pgWelcome = new UserWelcome();
            this.panel5.Controls.Add(pgWelcome);
            pgWelcome.Show();
            if (ckBT == true)
                pgWelcome.Hide();
        }

        public bool ckBT = false;
        private void BtStock_Click(object sender, EventArgs e)
        {
            ckBT = true;
            StockPage pg = new StockPage(MyUserName, main.GetUkey(MyUserName));
            this.panel5.Controls.Add(pg);
            pg.BringToFront();
            pg.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            PanelLeft.Show();
            PanelLeft.Height = BtStock.Height;
            PanelLeft.Top = BtStock.Top;
            

        }

        private void panelNhay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtOder_Click(object sender, EventArgs e)
        {
            OderUser pg = new OderUser();
            this.panel5.Controls.Add(pg);
            pg.BringToFront();
            pg.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            PanelLeft.Show();
            PanelLeft.Height = BtOder.Height;
            PanelLeft.Top = BtOder.Top;
            
        }

        private void panelL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtSta_Click(object sender, EventArgs e)
        {
            StatisticsPage pg = new StatisticsPage();
            this.panel5.Controls.Add(pg);
            pg.BringToFront();
            pg.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            PanelLeft.Show();
            PanelLeft.Height = BtSta.Height;
            PanelLeft.Top = BtSta.Top;
        }

        private void BtAcc_Click(object sender, EventArgs e)
        {
            AccountUser pg = new AccountUser(MyUserName);
            this.panel5.Controls.Add(pg);
            pg.BringToFront();
            pg.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            PanelLeft.Show();
            PanelLeft.Height = BtAcc.Height;
            PanelLeft.Top = BtAcc.Top;
        }

        private void BtHelp_Click(object sender, EventArgs e)
        {
            HelpUser pg = new HelpUser();
            this.panel5.Controls.Add(pg);
            pg.BringToFront();
            pg.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            PanelLeft.Show();
            PanelLeft.Height = BtAbout.Height;
            PanelLeft.Top = BtAbout.Top;
        }

        private void BtLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}   
