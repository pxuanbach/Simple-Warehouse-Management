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
        //Tạo 1 đối tượng controller của MainForm
        MainForm_Controller main = new MainForm_Controller();

        //2 biến chứa thông tin Username và Ukey
        public string MyUserName;
        public int UKey;

        public FMain(string Username)   //Đầu vào Username
        {
            InitializeComponent();
            MyUserName = Username;
            UKey = main.GetUkey(Username);  //Hàm GetUkey từ username
            this.FormClosed += FMain_FormClosed;
        }

        private void FMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public bool ckBT = false;

        //Lúc đăng nhập vào sẽ load page UserWelcome
        private void FMain_Load(object sender, EventArgs e)
        {
            UserWelcome pgWelcome = new UserWelcome();
            this.panelMain.Controls.Add(pgWelcome);
            pgWelcome.Show();
            if (ckBT == true)
                pgWelcome.Hide();
        }

        //Click vào button Stock sẽ load page StockPage
        private void BtStock_Click(object sender, EventArgs e)
        {
            ckBT = true;
            StockPage pg = new StockPage(MyUserName, UKey, panelMain.ClientSize);
            this.panelMain.Controls.Add(pg);
            pg.ClientSize = panelMain.ClientSize;
            pg.BringToFront();
            pg.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            PanelLeft.Show();
            PanelLeft.Height = BtStock.Height;
            PanelLeft.Top = BtStock.Top;
        }

        //Click vào button Order sẽ load page OderUser 
        private void BtOder_Click(object sender, EventArgs e)
        {
            OderUser pg = new OderUser(UKey);
            this.panelMain.Controls.Add(pg);
            pg.ClientSize = panelMain.ClientSize;
            pg.BringToFront();
            pg.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            PanelLeft.Show();
            PanelLeft.Height = BtOder.Height;
            PanelLeft.Top = BtOder.Top;
            
        }

        private void panelL_Paint(object sender, PaintEventArgs e)
        {

        }

        //Click vào button Statistics sẽ load page StatisticsPage 
        private void BtSta_Click(object sender, EventArgs e)
        {
            StatisticsPage pg = new StatisticsPage();
            this.panelMain.Controls.Add(pg);
            pg.ClientSize = panelMain.ClientSize;
            pg.BringToFront();
            pg.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            PanelLeft.Show();
            PanelLeft.Height = BtSta.Height;
            PanelLeft.Top = BtSta.Top;
        }

        //Click vào button About sẽ load page HelpUser 
        private void BtHelp_Click(object sender, EventArgs e)
        {
            HelpUser pg = new HelpUser();
            this.panelMain.Controls.Add(pg);
            pg.ClientSize = panelMain.ClientSize;
            pg.BringToFront();
            pg.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            PanelLeft.Show();
            PanelLeft.Height = BtAbout.Height;
            PanelLeft.Top = BtAbout.Top;
        }

        //Click vào button Account sẽ load page AccountUser 
        private void BtAcc_Click(object sender, EventArgs e)
        {
            AccountUser pg = new AccountUser(MyUserName, panelMain.ClientSize);
            this.panelMain.Controls.Add(pg);
            pg.ClientSize = panelMain.ClientSize;
            pg.BringToFront();
            pg.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            PanelLeft.Show();
            PanelLeft.Height = BtAcc.Height;
            PanelLeft.Top = BtAcc.Top;
        }

        //Click button Logout sẽ quay về màn hình đăng nhập
        private void BtLogout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
    }
}   
