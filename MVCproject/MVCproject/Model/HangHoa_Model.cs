using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MVCproject.Model
{
    class HangHoa_Model
    {
        public DataTable Load_On()
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD from HANGHOA where UKEY = 19521233";
            re = Process.createTable(sql_select);
            return re;
        }
 
        public bool Them_HangHoa(string MAHANG, string TENHANG, string DVT, int SOLUONG, int DONGIA, DateTime NGNHAP, DateTime NGSANXUAT, DateTime HSD, int UKEY)
        {
            string sql_insert = "insert HANGHOA values " +
                "('"+ MAHANG +"', '"+ TENHANG +"', '"+ DVT +"', "+ SOLUONG + ", "+ DONGIA + ", '" +
                NGNHAP + "', '"+ NGSANXUAT + "', '"+ HSD + "', " + UKEY + ")";
            bool re = false;
            if (Process.ExecutiveNonQuery(sql_insert) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
