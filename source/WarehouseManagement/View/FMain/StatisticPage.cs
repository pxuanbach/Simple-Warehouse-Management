using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WarehouseManagement.Controller;

namespace WarehouseManagement
{
    public partial class StatisticsPage : UserControl
    {
        StatisticsPage_Controller controller = new StatisticsPage_Controller();

        public StatisticsPage()
        {
            InitializeComponent();

            panelNoteD.Visible = false;
            panelNoteM.Visible = false;
            panelNoteY.Visible = false;

            string nam = DateTime.Now.Year.ToString();
            tBNamM.Text = nam;
            tBThangD.Text = DateTime.Now.Month.ToString();
            tBNamD.Text = nam;
            tBNamTop.Text = nam;
            cBSLTop.SelectedIndex = 0;
            cBTopType.SelectedIndex = 0;

            tBNamTop.KeyPress += textBox_KeyPress;
            tBNamM.KeyPress += textBox_KeyPress;
            tBThangD.KeyPress += textBox_KeyPress;
            tBNamD.KeyPress += textBox_KeyPress;
        }

        //Bắt sự kiện khi nhấn phím bất kì, chỉ cho phép nhập các phím số và phím control (để Backspace được)
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void BtShowChartY_Click(object sender, EventArgs e)
        {
            chartY.Series["Doanh Thu"].Points.Clear();
            try
            {
                DataTable dt = controller.Load_Data();
                chartY.ChartAreas["ChartArea1"].AxisX.Title = "Thời Gian (Năm)";
                chartY.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Microsoft Sans Serif", 11);
                chartY.ChartAreas["ChartArea1"].AxisY.Title = "Giá Tiền (VNĐ) ";
                chartY.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Microsoft Sans Serif", 11);
                panelNoteY.Visible = true;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chartY.Series["Doanh Thu"].Points.AddXY(dt.Rows[i]["ThoiGian"], dt.Rows[i]["DoanhThu"]);
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }

        private void BtShowChartM_Click(object sender, EventArgs e)
        {
            if ((IsNumber(tBNamM.Text) == false) || (tBNamM.Text == ""))
            {
                MessageBox.Show("Nhập sai mời nhập lại");
            }
            else
            {
                if (Convert.ToInt32(tBNamM.Text) <= DateTime.Now.Year)
                {
                    chartM.Series["Doanh Thu"].Points.Clear();
                    try
                    {
                        DataTable dt = controller.Load_Data_Year(tBNamM.Text);
                        chartM.ChartAreas["ChartArea1"].AxisX.Title = "Thời Gian (Tháng)";
                        chartM.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Microsoft Sans Serif", 11);
                        chartM.ChartAreas["ChartArea1"].AxisY.Title = "Giá Tiền (VNĐ) ";
                        chartM.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Microsoft Sans Serif", 11);
                        panelNoteM.Visible = true;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            chartM.Series["Doanh Thu"].Points.AddXY(dt.Rows[i]["ThoiGian"], dt.Rows[i]["DoanhThu"]);
                        }
                    }
                    catch (Exception exp)
                    {
                        throw exp;
                    }
                }
                else
                {
                    MessageBox.Show("Thòi gian bạn nhập lớn hơn thời gian hiện tại", "Thông báo");
                }
            }
        }

        private void BtShowChartD_Click(object sender, EventArgs e)
        {
            if (tBNamD.Text == "" || tBThangD.Text == "")
            {
                MessageBox.Show("Nhập sai mời nhập lại", "Thông báo");
            }
            else
            {
                if (Convert.ToInt32(tBThangD.Text) <= DateTime.Now.Month && Convert.ToInt32(tBNamD.Text) <= DateTime.Now.Year)
                {
                    chartD.Series["Doanh Thu"].Points.Clear();
                    try
                    {
                        DataTable dt = controller.Load_Data_Month(tBThangD.Text, tBNamD.Text);
                        chartD.ChartAreas["ChartArea1"].AxisX.Title = "Thời Gian (Ngày)";
                        chartD.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Microsoft Sans Serif", 11);
                        chartD.ChartAreas["ChartArea1"].AxisY.Title = "Giá Tiền (VNĐ) ";
                        chartD.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Microsoft Sans Serif", 11);
                        panelNoteD.Visible = true;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            chartD.Series["Doanh Thu"].Points.AddXY(dt.Rows[i]["ThoiGian"], dt.Rows[i]["DoanhThu"]);
                        }
                    }
                    catch (Exception exp)
                    {
                        throw exp;
                    }
                }
                else
                {
                    MessageBox.Show("Thòi gian bạn nhập lớn hơn thời gian hiện tại", "Thông báo");
                }
            }
        }

        void showListView(DataTable dt, string Type)
        {
            if (Type == "Hàng hóa")
            {
                listVTop.Columns.Add("Tên hàng", 140, HorizontalAlignment.Center);
                listVTop.Columns.Add("Doanh thu", 140, HorizontalAlignment.Right);
                listVTop.Columns.Add("Số lượng", 70, HorizontalAlignment.Center);
                listVTop.View = View.Details;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] s = dt.Rows[i].ItemArray[2].ToString().Split('.'); // Để lấy phần trước VD: 1000.0000 thì láy 1000 thôi
                    long so = Convert.ToInt64(s[0]);
                    string nhap = so.ToString("N0");
                    listVTop.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listVTop.Items[i].SubItems.Add(nhap);
                    listVTop.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                }
            }
            else
            {
                listVTop.Columns.Add("Tên đối tác", 140, HorizontalAlignment.Center);
                listVTop.Columns.Add("Doanh số", 140, HorizontalAlignment.Right);
                listVTop.Columns.Add("Số đơn", 70, HorizontalAlignment.Center);
                listVTop.View = View.Details;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] s = dt.Rows[i].ItemArray[2].ToString().Split('.'); // Để lấy phần trước VD: 1000.0000 thì láy 1000 thôi
                    long so = Convert.ToInt64(s[0]);
                    string nhap = so.ToString("N0");
                    listVTop.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listVTop.Items[i].SubItems.Add(nhap);
                    listVTop.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                }
            }
        }

        private void cBTop_SelectedIndexChanged(object sender, EventArgs e)
        {
            listVTop.Clear();
            DataTable dt;
            if (cBTopType.Text == "Hàng hóa")
                dt = controller.Load_Top_HANGHOA(cBSLTop.Text, tBNamTop.Text);
            else
                dt = controller.Load_Top_DOITAC(cBSLTop.Text, tBNamTop.Text);
            showListView(dt, cBTopType.Text);
            listVTop.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listVTop.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void cBSLTop_SelectedIndexChanged(object sender, EventArgs e)
        {
            listVTop.Clear();

            DataTable dt;
            if (cBTopType.Text == "Hàng hóa")
                dt = controller.Load_Top_HANGHOA(cBSLTop.Text, tBNamTop.Text);
            else
                dt = controller.Load_Top_DOITAC(cBSLTop.Text, tBNamTop.Text);
            showListView(dt, cBTopType.Text);
            listVTop.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listVTop.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void tBNamTop_TextChanged(object sender, EventArgs e)
        {
            if (tBNamTop.TextLength == 4)
            {
                listVTop.Clear();
                DataTable dt;
                if (cBTopType.Text == "Hàng hóa")
                    dt = controller.Load_Top_HANGHOA(cBSLTop.Text, tBNamTop.Text);
                else
                    dt = controller.Load_Top_DOITAC(cBSLTop.Text, tBNamTop.Text);
                showListView(dt, cBTopType.Text);
                listVTop.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listVTop.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void StatisticsPage_Resize(object sender, EventArgs e)
        {
            listVTop.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listVTop.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void StatisticsPage_Load(object sender, EventArgs e)
        {
            BtShowChartD_Click(sender, e);
            BtShowChartM_Click(sender, e);
            BtShowChartY_Click(sender, e);
        }

        private void chartM_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tBNamM.Text) <= DateTime.Now.Year)
            {
                chartM.Series["Doanh Thu"].Points.Clear();
                try
                {
                    DataTable dt = controller.Load_Data_Year(tBNamM.Text);
                    chartM.ChartAreas["ChartArea1"].AxisX.Title = "Thời Gian (Tháng)";
                    chartM.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Microsoft Sans Serif", 11);
                    chartM.ChartAreas["ChartArea1"].AxisY.Title = "Giá Tiền (VNĐ) ";
                    chartM.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Microsoft Sans Serif", 11);
                    panelNoteM.Visible = true;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        chartM.Series["Doanh Thu"].Points.AddXY(dt.Rows[i]["ThoiGian"], dt.Rows[i]["DoanhThu"]);
                    }
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
            }
    }
}
