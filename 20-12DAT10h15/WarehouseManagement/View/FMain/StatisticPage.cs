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

            tBNam.Text = DateTime.Now.Year.ToString();
            tBThang.Text = DateTime.Now.Month.ToString();
            tBNam.KeyPress += textBox_KeyPress;
            tBThang.KeyPress += textBox_KeyPress;
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
        private void BtShowChartM_Click(object sender, EventArgs e)
        {
            if ((IsNumber(tBNam.Text) == false) || (tBNam.Text == ""))
            {
                MessageBox.Show("Nhập sai mời nhập lại");
            }
            else
            {
                if (Convert.ToInt32(tBNam.Text) <= DateTime.Now.Year)
                {
                    try
                    {
                        DataTable dt = controller.Load_Data_Year(tBNam.Text);
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
                    MessageBox.Show("Thòi gian bạn nhập lớn hơn thời gian hiện tại");
                }
            }
        }

        private void BtShowChartY_Click(object sender, EventArgs e)
        {
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

        private void BtShowChartD_Click(object sender, EventArgs e)
        {
            if ((IsNumber(tBThang.Text) == false) || (tBNam.Text == ""))
            {
                MessageBox.Show("Nhập sai mời nhập lại");
            }
            else
            {
                if (Convert.ToInt32(tBThang.Text) <= DateTime.Now.Month)
                {
                    try
                    {
                        DataTable dt = controller.Load_Data_Month(tBThang.Text);
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
                    MessageBox.Show("Thòi gian bạn nhập lớn hơn thời gian hiện tại");
                }
            }
        }
    }
}
