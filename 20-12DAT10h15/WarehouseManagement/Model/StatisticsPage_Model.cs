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

        public DataTable Load_Data_Month(string THOIGIAN)
        {
            DataTable dt;
            string sql_select = "SELECT DAY(THOIGIAN) AS ThoiGian, SUM(TRIGIA) AS 'DoanhThu' FROM HOADON WHERE  MONTH(THOIGIAN) = '" + THOIGIAN + "' GROUP BY DAY(THOIGIAN); ";
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
    }
}

