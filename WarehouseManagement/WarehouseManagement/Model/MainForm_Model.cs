using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WarehouseManagement.Model
{
    class MainForm_Model
    {
        public int GetUkey(string username)
        {
            string sql_sel = "Select UKEY From USERACC Where USERNAME = '" + username + "'";
            return Process.GetUkey(sql_sel);
        }

        /*
        public bool Sua_HangHoa(string MAHANG, string TENHANG, string DVT, int SOLUONG, int DONGIA, DateTime NGNHAP, DateTime NGSANXUAT, DateTime HSD, int UKEY)
        {
            string sql_update = "update HANGHOA set MAHANG='" + MAHANG + "', TENHANG='" + TENHANG + "', DVT ='" + DVT + "', SOLUONG ='" + SOLUONG + "',DONGIA='" + DONGIA + "',NGNHAP='" + NGNHAP + "',NGSANXUAT='" + NGSANXUAT + "',HSD='" + HSD + "',UKEY='" + UKEY + "'";

            bool re = false;
            if (Process.ExecutiveNonQuery(sql_update) > 0)
            {
                re = true;
            }
            return re;
        }
        public bool Xoa_HangHoa(string MAHANG)
        {
            string sql_del = "delete form HANGHOA where MAHANG='" + MAHANG + "'";
            bool re = false;
            if (Process.ExecutiveNonQuery(sql_del) > 0)
            {
                re = true;
            }
            return re;
        }
        */
    }
}
