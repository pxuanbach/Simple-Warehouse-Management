using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WarehouseManagement.Model
{
    class StatisticsPage_Model
    {
        public DataTable Load_Data_Year(string THOIGIAN)
        {
            DataTable dt;
            string sql_select = "SELECT MONTH(THOIGIAN) AS ThoiGian, SUM(TRIGIA) AS 'DoanhThu' FROM HOADON WHERE  YEAR(THOIGIAN) = '" + THOIGIAN + "' GROUP BY MONTH(THOIGIAN);";
            dt = Process.createTable(sql_select);
            return dt;
        }

        public DataTable Load_Data_Month(string THOIGIAN, string nam)
        {
            DataTable dt;
            string sql_select = "SELECT DAY(THOIGIAN) AS ThoiGian, SUM(TRIGIA) AS 'DoanhThu' FROM HOADON WHERE  MONTH(THOIGIAN) = '" + THOIGIAN + "' AND  YEAR(THOIGIAN) = '" + nam + "'GROUP BY DAY(THOIGIAN); ";
            dt = Process.createTable(sql_select);
            return dt;
        }

        public DataTable Load_Data()
        {
            DataTable dt;
            string sql_select = "SELECT YEAR(THOIGIAN) AS ThoiGian, SUM(TRIGIA) AS 'DoanhThu' FROM HOADON GROUP BY YEAR(THOIGIAN); ";
            dt = Process.createTable(sql_select);
            return dt;
        }
        public DataTable Load_Top_HANGHOA(string top, string nam)
        {
            DataTable dt;
            if (top == "Tất cả")
            {
                top = "";
            }    
            string sql_select = "Select " + top + " B.TENHANG, SUM(A.SOLUONG)AS SOLUONG," +
                    "SUM(A.SOLUONG * B.DONGIA) as DOANHTHU From CTHD A, HANGHOA B, HOADON C " +
                    "Where A.MAHANG = B.MAHANG and A.MAHOADON = C.MAHOADON AND YEAR(C.THOIGIAN) = " + nam + " " +
                    "group by A.MAHANG, B.TENHANG Order by DOANHTHU desc";
            
            dt = Process.createTable(sql_select);
            return dt;
        }
        public DataTable Load_Top_DOITAC(string top, string nam)
        {
            DataTable dt;
            if (top == "Tất cả")
            {
                top = "";
            }
            string sql_select = "Select " + top + " TENDOITAC, count(MAHOADON) as SODON, SUM(TRIGIA) as DOANHSO " +
                                "From HOADON Where year(THOIGIAN) = " + nam + " and TRIGIA > 0 group by TENDOITAC Order by DOANHSO desc";
            
            dt = Process.createTable(sql_select);
            return dt;
        }
    }
}

