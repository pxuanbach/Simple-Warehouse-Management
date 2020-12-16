using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WarehouseManagement.Model
{
    class History_Model
    {
        public DataTable Load_On_Admin(string dd, string MM, string yyyy, int Type)   //Đầu vào cần 1 mã Ukey 
        {
            DataTable re;
            string sql_select = "";
            string sql_where = "";
            if (Type == 0)
            {
                sql_select = "Select USERACC.UKEY, HOTEN, HANGHOA.MAHANG,TENHANG,NGNHAP " +
                            "From HANGHOA inner join USERACC on HANGHOA.UKEY = USERACC.UKEY ";
                sql_where = "Where DAY(HANGHOA.NGNHAP) = " + dd +
                            " and Year(HANGHOA.NGNHAP) = " + yyyy + " and Month(HANGHOA.NGNHAP) = " + MM;
            }
            else
            {
                sql_select = "Select HOADON.MAHOADON, TENDOITAC, TRIGIA, USERACC.UKEY, HOTEN " +
                            "From HOADON inner join USERACC on HOADON.UKEY = USERACC.UKEY ";
                sql_where = "Where DAY(HOADON.THOIGIAN) = " + dd +
                            " and Year(HOADON.THOIGIAN) = " + yyyy + " and Month(HOADON.THOIGIAN) = " + MM;
            }    

            if (dd != null)
            {
                sql_select = sql_select + sql_where;
            }    
                
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable hàng hóa có số lượng hàng hóa > 0
        }

        public DataTable Load_On_User(int UKEY, string dd, string MM, string yyyy, int Type)   //Đầu vào cần 1 mã Ukey 
        {
            DataTable re;
            string sql_select = "";
            string sql_where = "";
            if (Type == 0)
            {
                sql_select = "Select USERACC.UKEY, HOTEN, HANGHOA.MAHANG,TENHANG,NGNHAP " +
                            "From HANGHOA inner join USERACC on HANGHOA.UKEY = USERACC.UKEY " +
                            "Where HANGHOA.UKEY = " + UKEY;
                sql_where = " and DAY(HANGHOA.NGNHAP) = " + dd +
                            " and Year(HANGHOA.NGNHAP) = " + yyyy + " and Month(HANGHOA.NGNHAP) = " + MM;
            }
            else
            {
                sql_select = "Select HOADON.MAHOADON, TENDOITAC, TRIGIA, USERACC.UKEY, HOTEN " +
                            "From HOADON inner join USERACC on HOADON.UKEY = USERACC.UKEY " +
                            "Where HOADON.UKEY = " + UKEY;
                sql_where = " and DAY(HOADON.THOIGIAN) = " + dd +
                            " and Year(HOADON.THOIGIAN) = " + yyyy + " and Month(HOADON.THOIGIAN) = " + MM;
            }

            if (dd != null)
            {
                sql_select = sql_select + sql_where;
            }
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable hàng hóa có số lượng hàng hóa > 0
        }

        public List<CTHD> GetCTHDs(int MAHD, int UKEY)
        {
            string sql_select = "Select CTHD.MAHANG, CTHD.SOLUONG, HANGHOA.DONGIA From CTHD inner join HANGHOA " +
                "on CTHD.MAHANG = HANGHOA.MAHANG " +
                "Where CTHD.MAHOADON = " + MAHD + " and CTHD.UKEY = " + UKEY;

            return Process.GetCTHDs(sql_select);
        }
    }
}
