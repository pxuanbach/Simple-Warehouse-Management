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

        //Khai báo các page UserControl
        UserWelcome pgWelcome;
        StockPage pgStock;
        OrderUser pgOrder;
        StatisticsPage pgSta;
        HelpUser pgHelpUser;
        AccountUser pgAcc;
        AdminPage pgAd;
        

        //2 biến chứa thông tin Username và Ukey
        string MyUserName;
        int UKey;
        int Position;
        bool isLogout = false;

        //Position = 0 tương đương ADMIN, = 1 là quản lý, = 2 là nhân viên
        public FMain(string Username, int UKEY, int Position)   //Đầu vào Username. Position
        {
            InitializeComponent();
            MyUserName = Username;
            this.Position = Position;
            UKey = UKEY;  //Hàm GetUkey từ username
            BtAdmin.Hide();

            //Khởi tạo các page với đối số là thông tin tài khoản đăng nhập
            pgWelcome = new UserWelcome();
            pgStock = new StockPage(MyUserName, UKey, Position);
            pgHelpUser = new HelpUser();
            pgAcc = new AccountUser(MyUserName, UKey);
            pgOrder = new OrderUser(UKey, Position);
            

            //Thêm page vào panelMain
            this.panelMain.Controls.Add(pgWelcome);
            this.panelMain.Controls.Add(pgStock); 
            this.panelMain.Controls.Add(pgHelpUser);
            this.panelMain.Controls.Add(pgAcc);
            this.panelMain.Controls.Add(pgOrder);

            if (Position != 2)
            {
                BtAdmin.Show();
                pgAd = new AdminPage(UKEY, Position, true);
                pgSta = new StatisticsPage();
                this.panelMain.Controls.Add(pgAd);
                this.panelMain.Controls.Add(pgSta);
            }    
            

            pgWelcome.ClientSize = panelMain.ClientSize;
            pgWelcome.BringToFront();
            pgWelcome.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            //Thêm các sự kiện
            this.FormClosed += FMain_FormClosed;
            this.FormClosing += FMain_FormClosing;
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogout == false)
            {
                var window = MessageBox.Show("Bạn có chắc muốn thoát khỏi ứng dụng?", "Thoát Ứng Dụng", MessageBoxButtons.YesNo);

                e.Cancel = (window == DialogResult.No);
            }
        }

        private void FMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (isLogout == false)
            {
                Application.Exit();
            }
            else
                this.Close();
        }

        public bool ckBT = false;

        //Lúc đăng nhập vào sẽ load page UserWelcome
        private void FMain_Load(object sender, EventArgs e)
        {
            
            if (ckBT == true)
                pgWelcome.Hide();
            
        }

        //Click vào button Stock sẽ load page StockPage
        private void BtStock_Click(object sender, EventArgs e)
        {
            // Đổi màu và font của button Stock
            BtAdmin.BackColor = Color.FromArgb(239, 242, 235);
            BtAdmin.ForeColor = Color.FromArgb(73, 80, 87);
            BtAdmin.IconColor = Color.FromArgb(73, 80, 87);
            BtAdmin.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtStock.BackColor = Color.FromArgb(58, 197, 158);// CHuyển màu button Stock
            BtStock.ForeColor = Color.FromArgb(255, 255, 255);
            BtStock.IconColor = Color.FromArgb(255, 255, 255);
            BtStock.Font = new Font("Calibri", 16, FontStyle.Bold);

            #region Trả lại màu button khác
            BtOder.BackColor = Color.FromArgb(239, 242, 235);
            BtOder.ForeColor = Color.FromArgb(73, 80, 87);
            BtOder.IconColor = Color.FromArgb(73, 80, 87);
            BtOder.Font = new Font("Calibri", 15, FontStyle.Bold);


            BtStatistic.BackColor = Color.FromArgb(239, 242, 235);
            BtStatistic.ForeColor = Color.FromArgb(73, 80, 87);
            BtStatistic.IconColor = Color.FromArgb(73, 80, 87);
            BtStatistic.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtAcc.BackColor = Color.FromArgb(239, 242, 235);
            BtAcc.ForeColor = Color.FromArgb(73, 80, 87);
            BtAcc.IconColor = Color.FromArgb(73, 80, 87);
            BtAcc.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtDetails.BackColor = Color.FromArgb(239, 242, 235);// CHuyển màu button Oder
            BtDetails.ForeColor = Color.FromArgb(73, 80, 87);
            BtDetails.IconColor = Color.FromArgb(73, 80, 87);
            BtDetails.Font = new Font("Calibri", 15, FontStyle.Bold);
            #endregion

            #region //Click vào button Stock sẽ load page StockPage
            ckBT = true;
            
            pgStock.ClientSize = panelMain.ClientSize;
            pgStock.BringToFront();
            pgStock.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            PanelLeft.Show();
            PanelLeft.Height = BtStock.Height;
            PanelLeft.Top = BtStock.Top;
            #endregion
        }

        //Click vào button Order sẽ load page OderUser 
        private void BtOrder_Click(object sender, EventArgs e)
        {

            // Đổi màu bt Back
            BtOder.BackColor = Color.FromArgb(82, 201, 189);// CHuyển màu button Oder
            BtOder.ForeColor = Color.FromArgb(255, 255, 255);
            BtOder.IconColor = Color.FromArgb(255, 255, 255);
            BtOder.Font = new Font("Calibri", 16, FontStyle.Bold);

            #region Trả lại màu button khác

            BtAdmin.BackColor = Color.FromArgb(239, 242, 235);
            BtAdmin.ForeColor = Color.FromArgb(73, 80, 87);
            BtAdmin.IconColor = Color.FromArgb(73, 80, 87);
            BtAdmin.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtStatistic.BackColor = Color.FromArgb(239, 242, 235);
            BtStatistic.ForeColor = Color.FromArgb(73, 80, 87);
            BtStatistic.IconColor = Color.FromArgb(73, 80, 87);
            BtStatistic.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtAcc.BackColor = Color.FromArgb(239, 242, 235);
            BtAcc.ForeColor = Color.FromArgb(73, 80, 87);
            BtAcc.IconColor = Color.FromArgb(73, 80, 87);
            BtAcc.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtDetails.BackColor = Color.FromArgb(239, 242, 235);// CHuyển màu button Oder
            BtDetails.ForeColor = Color.FromArgb(73, 80, 87);
            BtDetails.IconColor = Color.FromArgb(73, 80, 87);
            BtDetails.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtStock.BackColor = Color.FromArgb(239, 242, 235);// CHuyển màu button Oder
            BtStock.ForeColor = Color.FromArgb(73, 80, 87);
            BtStock.IconColor = Color.FromArgb(73, 80, 87);
            BtStock.Font = new Font("Calibri", 15, FontStyle.Bold);



            #endregion

            #region         //Click vào button Order sẽ load page OderUser 
            pgOrder.ClientSize = panelMain.ClientSize;
            pgOrder.BringToFront();
            pgOrder.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            PanelLeft.Show();
            PanelLeft.Height = BtOder.Height;
            PanelLeft.Top = BtOder.Top;

            #endregion

        }

        private void panelL_Paint(object sender, PaintEventArgs e)
        {

        }

        //Click vào button Statistics sẽ load page StatisticsPage 
        private void BtSta_Click(object sender, EventArgs e)
        {
            #region//Click vào button Statistics sẽ load page StatisticsPage 

            if (Position != 2)
            {
                //Đổi màu bt Sta
                BtStatistic.BackColor = Color.FromArgb(223, 159, 163);// CHuyển màu button Sta
                BtStatistic.ForeColor = Color.FromArgb(255, 255, 255);
                BtStatistic.IconColor = Color.FromArgb(255, 255, 255);
                BtStatistic.Font = new Font("Calibri", 16, FontStyle.Bold);

                #region Trả lại màu button khác
                BtAdmin.BackColor = Color.FromArgb(239, 242, 235);
                BtAdmin.ForeColor = Color.FromArgb(73, 80, 87);
                BtAdmin.IconColor = Color.FromArgb(73, 80, 87);
                BtAdmin.Font = new Font("Calibri", 15, FontStyle.Bold);


                BtOder.BackColor = Color.FromArgb(239, 242, 235);
                BtOder.ForeColor = Color.FromArgb(73, 80, 87);
                BtOder.IconColor = Color.FromArgb(73, 80, 87);
                BtOder.Font = new Font("Calibri", 15, FontStyle.Bold);


                BtAcc.BackColor = Color.FromArgb(239, 242, 235);
                BtAcc.ForeColor = Color.FromArgb(73, 80, 87);
                BtAcc.IconColor = Color.FromArgb(73, 80, 87);
                BtAcc.Font = new Font("Calibri", 15, FontStyle.Bold);

                BtDetails.BackColor = Color.FromArgb(239, 242, 235);// CHuyển màu button Oder
                BtDetails.ForeColor = Color.FromArgb(73, 80, 87);
                BtDetails.IconColor = Color.FromArgb(73, 80, 87);
                BtDetails.Font = new Font("Calibri", 15, FontStyle.Bold);

                BtStock.BackColor = Color.FromArgb(239, 242, 235);// CHuyển màu button Oder
                BtStock.ForeColor = Color.FromArgb(73, 80, 87);
                BtStock.IconColor = Color.FromArgb(73, 80, 87);
                BtStock.Font = new Font("Calibri", 15, FontStyle.Bold);
                #endregion

                pgSta.ClientSize = panelMain.ClientSize;
                pgSta.BringToFront();
                pgSta.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

                PanelLeft.Show();
                PanelLeft.Height = BtStatistic.Height;
                PanelLeft.Top = BtStatistic.Top;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập trang này!", "Thông báo");
            }
            
            #endregion
        }

        //Click vào button About sẽ load page HelpUser 
        private void BtAbout_Click(object sender, EventArgs e)
        {
            // Đổi màu Button About
            BtDetails.BackColor = Color.FromArgb(162, 172, 164);// CHuyển màu button About
            BtDetails.ForeColor = Color.FromArgb(255, 255, 255);
            BtDetails.IconColor = Color.FromArgb(255, 255, 255);
            BtDetails.Font = new Font("Calibri", 16, FontStyle.Bold);


            #region Trả lại màu button khác

            BtAdmin.BackColor = Color.FromArgb(239, 242, 235);
            BtAdmin.ForeColor = Color.FromArgb(73, 80, 87);
            BtAdmin.IconColor = Color.FromArgb(73, 80, 87);
            BtAdmin.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtOder.BackColor = Color.FromArgb(239, 242, 235);
            BtOder.ForeColor = Color.FromArgb(73, 80, 87);
            BtOder.IconColor = Color.FromArgb(73, 80, 87);
            BtOder.Font = new Font("Calibri", 15, FontStyle.Bold);


            BtStatistic.BackColor = Color.FromArgb(239, 242, 235);
            BtStatistic.ForeColor = Color.FromArgb(73, 80, 87);
            BtStatistic.IconColor = Color.FromArgb(73, 80, 87);
            BtStatistic.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtAcc.BackColor = Color.FromArgb(239, 242, 235);
            BtAcc.ForeColor = Color.FromArgb(73, 80, 87);
            BtAcc.IconColor = Color.FromArgb(73, 80, 87);
            BtAcc.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtStock.BackColor = Color.FromArgb(239, 242, 235);// CHuyển màu button Oder
            BtStock.ForeColor = Color.FromArgb(73, 80, 87);
            BtStock.IconColor = Color.FromArgb(73, 80, 87);
            BtStock.Font = new Font("Calibri", 15, FontStyle.Bold);



            #endregion

            #region About--- load page HelpUser 
            
            pgHelpUser.ClientSize = panelMain.ClientSize;
            pgHelpUser.BringToFront();
            pgHelpUser.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

            PanelLeft.Show();
            PanelLeft.Height = BtDetails.Height;
            PanelLeft.Top = BtDetails.Top;
            #endregion
        }

        //Click vào button Account sẽ load page AccountUser 
        private void BtAcc_Click(object sender, EventArgs e)
        {
            // Đổi màu button Acc
            BtAcc.BackColor = Color.FromArgb(214, 158, 137);// CHuyển màu button Acc
            BtAcc.ForeColor = Color.FromArgb(255, 255, 255);
            BtAcc.IconColor = Color.FromArgb(255, 255, 255);
            BtAcc.Font = new Font("Calibri", 16, FontStyle.Bold);

            #region Trả lại màu button khác
            BtAdmin.BackColor = Color.FromArgb(239, 242, 235);
            BtAdmin.ForeColor = Color.FromArgb(73, 80, 87);
            BtAdmin.IconColor = Color.FromArgb(73, 80, 87);
            BtAdmin.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtOder.BackColor = Color.FromArgb(239, 242, 235);
            BtOder.ForeColor = Color.FromArgb(73, 80, 87);
            BtOder.IconColor = Color.FromArgb(73, 80, 87);
            BtOder.Font = new Font("Calibri", 15, FontStyle.Bold);


            BtStatistic.BackColor = Color.FromArgb(239, 242, 235);
            BtStatistic.ForeColor = Color.FromArgb(73, 80, 87);
            BtStatistic.IconColor = Color.FromArgb(73, 80, 87);
            BtStatistic.Font = new Font("Calibri", 15, FontStyle.Bold);


            BtDetails.BackColor = Color.FromArgb(239, 242, 235);// CHuyển màu button Oder
            BtDetails.ForeColor = Color.FromArgb(73, 80, 87);
            BtDetails.IconColor = Color.FromArgb(73, 80, 87);
            BtDetails.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtStock.BackColor = Color.FromArgb(239, 242, 235);// CHuyển màu button Oder
            BtStock.ForeColor = Color.FromArgb(73, 80, 87);
            BtStock.IconColor = Color.FromArgb(73, 80, 87);
            BtStock.Font = new Font("Calibri", 15, FontStyle.Bold);
            #endregion
           
           
            #region //Click vào button Account sẽ load page AccountUser của User, page AdminManage của Admin
            
            pgAcc.ClientSize = panelMain.ClientSize;
            pgAcc.BringToFront();
            pgAcc.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);    
            PanelLeft.Show();
            PanelLeft.Height = BtAcc.Height;
            PanelLeft.Top = BtAcc.Top;
            #endregion
        }

        //Click button Logout sẽ quay về màn hình đăng nhập
        private void BtLogout_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng Xuất", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                isLogout = true;
                this.Close();
            }
        }

        private void BtAdmin_Click(object sender, EventArgs e)
        {
            BtAdmin.BackColor = Color.FromArgb(50, 174, 184);// CHuyển màu button Admin
            BtAdmin.ForeColor = Color.FromArgb(255, 255, 255);
            BtAdmin.IconColor = Color.FromArgb(255, 255, 255);
            #region Trả lại màu button khác
            BtAcc.BackColor = Color.FromArgb(239, 242, 235);
            BtAcc.ForeColor = Color.FromArgb(73, 80, 87);
            BtAcc.IconColor = Color.FromArgb(73, 80, 87);
            BtAcc.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtOder.BackColor = Color.FromArgb(239, 242, 235);
            BtOder.ForeColor = Color.FromArgb(73, 80, 87);
            BtOder.IconColor = Color.FromArgb(73, 80, 87);
            BtOder.Font = new Font("Calibri", 15, FontStyle.Bold);


            BtStatistic.BackColor = Color.FromArgb(239, 242, 235);
            BtStatistic.ForeColor = Color.FromArgb(73, 80, 87);
            BtStatistic.IconColor = Color.FromArgb(73, 80, 87);
            BtStatistic.Font = new Font("Calibri", 15, FontStyle.Bold);


            BtDetails.BackColor = Color.FromArgb(239, 242, 235);// CHuyển màu button Oder
            BtDetails.ForeColor = Color.FromArgb(73, 80, 87);
            BtDetails.IconColor = Color.FromArgb(73, 80, 87);
            BtDetails.Font = new Font("Calibri", 15, FontStyle.Bold);

            BtStock.BackColor = Color.FromArgb(239, 242, 235);// CHuyển màu button Oder
            BtStock.ForeColor = Color.FromArgb(73, 80, 87);
            BtStock.IconColor = Color.FromArgb(73, 80, 87);
            BtStock.Font = new Font("Calibri", 15, FontStyle.Bold);
            #endregion

            #region //Click vào button QUẢN LI sẽ load page  AdminManage của Admin
            pgAd.ClientSize = panelMain.ClientSize;
            pgAd.BringToFront();
            pgAd.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            PanelLeft.Show();
            PanelLeft.Height = BtAdmin.Height;
            PanelLeft.Top = BtAdmin.Top;
            #endregion  
        }
    }
}   
