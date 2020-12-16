using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WarehouseManagement.Model
{
    class StockPage_Model
    { 
        //Function có chức năng load data từ SQL Server
        public DataTable Load_On_01(int Ukey, int Position)   //Đầu vào cần 1 mã Ukey 
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD,UKEY from HANGHOA ";
            if (Position == 0)
                sql_select = sql_select + "where SOLUONG > 0";
            else
                sql_select = sql_select + "where SOLUONG > 0 and UKEY = " + Ukey;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable hàng hóa có số lượng hàng hóa > 0
        }

        public DataTable Load_On_02(int Ukey, int Position)   //Đầu vào cần 1 mã Ukey 
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD,UKEY from HANGHOA ";
            if (Position == 0)
                sql_select = sql_select + "where SOLUONG = 0";
            else
                sql_select = sql_select + "where SOLUONG = 0 and UKEY = " + Ukey;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable hàng hóa có số lượng hàng hóa = 0
        }

        //Function có chức năng thêm 1 hàng hóa vào database
        public bool Them_HangHoa(string TENHANG, string DVT, int SOLUONG, int DONGIA, DateTime NGNHAP, string NGSANXUAT, string HSD, int UKEY)
        {
            if (NGSANXUAT != "null")
            {
                NGSANXUAT = "'" + NGSANXUAT + "'";
            }
            if (HSD != "null")
            {
                HSD = "'" + HSD + "'";
            }    
            string sql_insert = "insert [HANGHOA] values " 
                + "(N'" + TENHANG + "', N'" + DVT + "', " + SOLUONG + ", " + DONGIA + ", '" 
                + NGNHAP + "', " + NGSANXUAT + ", " + HSD + ", " + UKEY + ")";
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_insert) > 0)
            {
                re = true;
            }
            return re;
        }

        //Function có chức năng xóa 1 hàng hóa trong database
        public bool Xoa_HangHoa(string MAHANG, int UKEY)
        {
            string sql_del = $"delete from HANGHOA where MAHANG = '{MAHANG}' AND UKEY = {UKEY};";
            bool re = false;
            if (Process.ExecutiveNonQuery(sql_del) > 0)
            {
                re = true;
            }
            return re;
        }
        public DataTable Load_MA(string MAHANG, int UKEY, int Position)   //Đầu vào cần 1 mã Ukey và tên mã hàng
        {
            DataTable re;
            string sql_select = $"Select MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD,UKEY from HANGHOA where CHARINDEX('{MAHANG}', MAHANG) != 0 ";
            if (Position != 0)
                sql_select = sql_select + "AND UKEY = " + UKEY;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }
        public DataTable Load_TENHANG(string TENHANG, int UKEY, int Position)   //Đầu vào cần 1 mã Ukey và tên hàng hóa
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD,UKEY from HANGHOA where CHARINDEX(N'" + TENHANG + "', TENHANG) != 0 ";
            if (Position != 0)
                sql_select = sql_select + "AND UKEY = " + UKEY;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }
        public DataTable Load_NGAYNHAP(string NGNHAP, int UKEY, int Position)   //Đầu vào cần 1 mã Ukey và tên hàng hóa
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD,UKEY from HANGHOA " +
                "where CHARINDEX('" + NGNHAP + "', NGNHAP) != 0 ";
            if (Position != 0)
                sql_select = sql_select + "AND UKEY = " + UKEY;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }

        public bool Check_HangHoa(string MAHANG, int UKEY)
        {
            string sql_select = "Select * From HANGHOA Where UKEY = " + UKEY +
                " and MAHANG = " + MAHANG;
            bool re = false;
            if (Process.ExecutiveReader(sql_select) > 0)
            {
                re = true;
            }
            return re;
        }

        public bool Update_HangHoa(string MAHANG, string TENHANG, string DVT, int SOLUONG, int DONGIA, string NGSANXUAT, string HSD, int UKEY)
        {
            if (NGSANXUAT != "null")
            {
                NGSANXUAT = "'" + NGSANXUAT + "'";
            }
            if (HSD != "null")
            {
                HSD = "'" + HSD + "'";
            }
            string sql_update = "UPDATE HANGHOA " +
                "SET SOLUONG = " + SOLUONG + ", TENHANG = N'" + TENHANG + "', " + "DVT = N'" + DVT + "', " +
                "DONGIA = " + DONGIA + ", NGSANXUAT = " + NGSANXUAT + ", " +
                "HSD = " + HSD + " WHERE MAHANG = '" + MAHANG + "' AND UKEY = " + UKEY;
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_update) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
