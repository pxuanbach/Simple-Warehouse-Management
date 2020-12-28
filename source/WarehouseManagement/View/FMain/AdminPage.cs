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
    public partial class AdminPage : UserControl
    {
        Admin_Controller controller = new Admin_Controller();
        bool isSearched = false;
        int Position;   
        //Position = 0 tương đương ADMIN, = 1 là quản lý, = 2 là nhân viên
        public AdminPage(int UKEY, int Position, bool ck)
        {
            InitializeComponent();
            this.Position = Position;
            
            //load ngay khi Page khởi tạo
            dGVPersonel.DataSource = controller.load_on(Position);

            //chọn Item ban đầu cho các combobox
            cBPosition.SelectedIndex = 0;
            cBStatusData.SelectedIndex = 1;
            cBPositionData.SelectedIndex = 1;
            cBSearch.SelectedIndex = 0;
        }

        #region Hàm hỗ trợ
        //Hàm có chức năng đổi màu hàng có tài khoản bị chặn
        void makeColorAccBlocked()
        {
            for (int i = 0; i < dGVPersonel.Rows.Count; i++)    //Duyệt qua tất cả hàng của dataGridView
            {
                if (dGVPersonel.Rows[i].Cells["STATUS"].Value.ToString() == "Chặn")
                    dGVPersonel.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        //Hàm dùng để thay đổi Chức vụ và Tình trạng tài khoản
        void changeStaPos(string sta, string pos)   //sta = Tình trạng cần thay đổi, pos = Chức vụ cần thay đổi
        {
            if (dGVPersonel.SelectedRows.Count > 0) //dataGridView phải có hàng được chọn
            {
                //Kiểm tra tài khoản cần thay đổi là Quản trị viên hay không? Nếu là Quản trị viên thì không thể thay đổi
                if (dGVPersonel.SelectedRows[0].Cells["POS"].Value.ToString() == "Quản trị viên")
                {
                    MessageBox.Show("Đây là quản trị viên.", "Thông báo");
                    return;
                }
                //Kiểm tra nếu chức vụ Quản lý thì không thể thay đổi Nhân viên thành Quản lý
                if (Position == 1 && pos == "Quản lý")
                {
                    MessageBox.Show("Bạn không thể thay đổi chức vụ của người khác ngang với chức của bạn.", "Thông báo");
                    return;
                }
                //Nếu 1 trong 2 giá trị đầu vào lựa chọn Item khác "Không thay đổi" thì thực thi lệnh trong if
                if (pos != "Không thay đổi" || sta != "Không thay đổi")
                {
                    controller.set_Status_Position(dGVPersonel.SelectedRows[0].Cells["KEY"].Value.ToString(), sta, pos);
                    dGVPersonel.DataSource = controller.load_on(Position);
                    makeColorAccBlocked();  //Đổi màu tài khoản bị chặn
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản để thay đổi thông tin.", "Thông báo");
            }
        }

        //Hàm dùng để lấy thông tin nhân viên
        void getInfo_dGV()
        {
            if (dGVPersonel.SelectedRows.Count > 0) //Kiểm tra dataGridView có hàng đã được chọn chưa?
            {
                int n = dGVPersonel.SelectedRows[0].Index;  //Lấy số của hàng chọn
                //Lưu thông tin vào đối tượng acc 
                Account acc = controller.getInformation(dGVPersonel.Rows[n].Cells["HOTEN"].Value.ToString(),
                    Convert.ToInt32(dGVPersonel.Rows[n].Cells["KEY"].Value));
                //Điền thông tin đã lấy được qua các label
                labelName.Text = acc.Name1;
                labelPhoneNumber.Text = acc.Phone1;
                labelGender.Text = acc.Gender1;
                labelBirthDay.Text = acc.Birthday1.ToString("dd/MM/yyyy");
                labelEmail.Text = acc.Email1;
                labelPosition.Text = acc.Position1;
            }
        }

        //Khi Click button Mail sử dụng hàm này hoặc contextMenuStrip-Item-Mail (chuột phải)
        void sendMail()
        {
            if (labelEmail.Text == "")  //Phải có mail mới gửi được
                MessageBox.Show("Chưa có email để gửi");
            else
            {
                FSendMail email = new FSendMail(labelEmail.Text, labelName.Text, Position); //Gọi form mail
                email.ShowDialog();
                this.Show();
            }
        }
        #endregion

        #region Sự kiện của các Control
        //Khi Click vào button Tạo Mã (Chỉ cho phép Quản trị viên tạo)
        private void BtAddKey_Click(object sender, EventArgs e)
        {
            if (Position == 0)  //Là Quản trị viên
            {
                int key = controller.getNewKey(cBPosition.Text);
                MessageBox.Show("Thêm thành công");
                tBUkey.Text = key.ToString();
                dGVPersonel.DataSource = controller.load_on(Position);  // load lại data sau khi add
                makeColorAccBlocked();
                List<int> soLuong = controller.getCountPosition();  //List số lượng nhân sự của từng chức vụ
                labelNhanVien.Text = soLuong[0].ToString(); //Số lượng Nhân viên
                labelQuanLy.Text = soLuong[1].ToString();   //Số lượng Quản lý
                labelQTV.Text = soLuong[2].ToString();      //Số lượng Quản trị viên
            }    
            else
            {
                MessageBox.Show("Bạn không đủ quyền để tạo mã.", "Thông báo");
            }    
        }

        //Load của page
        private void AdminPage_Load(object sender, EventArgs e)
        {
            List<int> soLuong = controller.getCountPosition();  //List số lượng nhân sự của từng chức vụ
            labelNhanVien.Text = soLuong[0].ToString(); //Số lượng Nhân viên
            labelQuanLy.Text = soLuong[1].ToString();   //Số lượng Quản lý
            labelQTV.Text = soLuong[2].ToString();      //Số lượng Quản trị viên
            dGVPersonel.ReadOnly = true;
            dGVPersonel.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;    //khi click vào ô bất kì thì hàng đó sẽ được chọn
            makeColorAccBlocked();
        }

        //Khi Click vào button Thay Đổi
        private void BtChange_Click(object sender, EventArgs e)
        {
            changeStaPos(cBStatusData.Text, cBPositionData.Text);
        }

        //Khi Click vào button Mail
        private void BtMail_Click(object sender, EventArgs e)
        {
            sendMail();
        }

        //contextMenuStrip-Item-Chặn (chuột phải)
        private void BlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeStaPos("Chặn", "Không thay đổi"); 
        }
        //contextMenuStrip-Item-Bỏ Chặn (chuột phải)
        private void UnblockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeStaPos("Bình thường", "Không thay đổi");
        }
        //contextMenuStrip-Item-Mail (chuột phải)
        private void EmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendMail();
        }

        //Sự kiện chuột click vào bất kì ô nào (để bắt sự kiện click = chuột phải)
        private void dGVPersonel_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Click = chuột phải và Kiểm tra nếu không chọn được hàng nào hoặc dataGridView trống
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                dGVPersonel.MultiSelect = false;
                dGVPersonel.Rows[e.RowIndex].Selected = true;
                getInfo_dGV();  //lấy thông tin tài khoản đã đc chọn điền vào Thông tin nhân viên bên cạch dataGridView
            }
        }

        //Sự kiện chuột click 1 lần vào bất kì ô nào
        private void dGVPersonel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            getInfo_dGV();
        }

        //Khi Click vào button Search
        private void BtSearch_Click(object sender, EventArgs e)
        {
            if (tBSeach.Text != "") //Nếu không có giá trị để search thì show messbox nhắc nhở
            {
                dGVPersonel.DataSource = controller.Load_Search(cBSearch.Text, tBSeach.Text, Position); //Load data đã lấy được từ database
                makeColorAccBlocked();
                isSearched = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo");
            }
        }

        //Sự kiện thay đổi giá trị của textbox
        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            if (tBSeach.Text == "" && isSearched == true)   //bắt sự kiện sau khi click button tìm kiếm 
            {                                               //và giá trị textbox = "" thì load lại dataGridView
                dGVPersonel.DataSource = controller.load_on(Position);
                makeColorAccBlocked();
                isSearched = false;
            }
        }

        //Khi Click vào button Refresh thì load lại dataGridView
        private void BtRefresh_Click(object sender, EventArgs e)
        {
            dGVPersonel.DataSource = controller.load_on(Position);
            makeColorAccBlocked();
        }
        #endregion
    }
}
