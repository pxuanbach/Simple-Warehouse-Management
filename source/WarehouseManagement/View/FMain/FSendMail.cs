using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using WarehouseManagement.Controller;

namespace WarehouseManagement
{
    public partial class FSendMail : Form
    {
        string[] str2 = new string[30];
        bool isKeyPress = false;
        string name;
        int Position;    //Position = 0 tương đương ADMIN, = 1 là quản lý
        public FSendMail(string email, string TenNguoiGui, int Pos)
        {
            InitializeComponent();
            tbTo.Text = email;
            tbTo.ForeColor = Color.Black;
            name = TenNguoiGui;
            Position = Pos;

            tbTitle.MouseEnter += new System.EventHandler(this.tbTitle_MouseEnter);
            tbTitle.MouseLeave += new System.EventHandler(this.tbTitle_MouseLeave);
        }

        private void BtSend_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(); //
            mail.IsBodyHtml = true;
            //gửi tin nhắn
            mail.From = new MailAddress("BDTCompanyUIT@gmail.com");
            mail.To.Add(tbTo.Text);
            mail.Subject = tbTitle.Text;
            mail.Body = tbContent.Text + '\n' + "Người gửi: \n" + name;
            SmtpClient client = new SmtpClient("smtp.gmail.com"); // Mail này của Host fix cứng khỏi sửa
            client.Host = "smtp.gmail.com";
            //ta không dùng cái mặc định đâu, mà sẽ dùng cái của riêng mình
            client.UseDefaultCredentials = false;
            client.Port = 587; //vì sử dụng Gmail nên mình dùng port 587
            // thêm vào credential vì SMTP server cần nó để biết được email + password của email đó mà bạn đang dùng
            client.Credentials = new System.Net.NetworkCredential("BDTCompanyUIT@gmail.com", "BDTComp@ny");
            //------------CHECK FILE GỬI ------

            foreach (string names in str2)
            {
                if (names != null)
                {
                    mail.Attachments.Add(new Attachment(names));
                    MessageBox.Show("Have upload " + names + " succesfully!", "Upload File");
                }

            }
            //----------------------------------
            client.EnableSsl = true; //vì ta cần thiết lập kết nối SSL với SMTP server nên cần gán nó bằng true
            client.Send(mail);
            MessageBox.Show("Đã gửi tin nhắn thành công!", "Thành Công", MessageBoxButtons.OK);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void icAttach_Click(object sender, EventArgs e)
        {
            string fileName = ""; //khởi tạo ban đầu
                                  //open tệp tin với component OpenFileDialog
            using (OpenFileDialog myDialog = new OpenFileDialog())
            {
                myDialog.Multiselect = true;
                myDialog.InitialDirectory = "";
                myDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                myDialog.FilterIndex = 2;
                myDialog.RestoreDirectory = true;

                if (myDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in myDialog.FileNames)
                    //cứ sau mỗi lần lặp ta lại có được một file, điều này cho phép bạn chọn nhiều file thay vì chỉ một cái
                    {
                        //Lấy đường dẫn của file cụ thể
                        //lấy tên của file cụ thể
                        fileName = Path.GetFileName(file);
                    }

                }
                str2 = myDialog.FileNames;
                MessageBox.Show("Load lên thành công");
            }
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTitle_MouseEnter(object sender, EventArgs e)
        {
            if ((tbTitle.Text == "Nhập chủ đề"))
            {
                tbTitle.Text = "";
                tbTitle.ForeColor = Color.Black;
            }
        }

        private void tbTitle_MouseLeave(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
            {
                tbTitle.Text = "Nhập chủ đề";
                tbTitle.ForeColor = Color.Silver;
                isKeyPress = false;
            }
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void tbTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isKeyPress == false)
            {
                if (tbTitle.Text.Contains("Nhập chủ đề") && tbTitle.Text.Length == 11)
                {
                    tbTitle.Text = tbTitle.Text.Replace("Nhập chủ đề", "");
                    isKeyPress = true;
                }
            }    
        }
    }
}



