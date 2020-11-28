using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WarehouseManagement.Model
{
    class OrderPage_Model
    {
        //Function có chức năng load data từ SQL Server
        public DataTable Load_On(int Ukey)   //Đầu vào cần 1 mã Ukey 
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,DONGIA,NGNHAP, SOLUONG from HANGHOA where UKEY = " + Ukey;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }

        //Function có chức năng thêm 1 hóa đơn vào database
        public bool Add_Order(string MAHANG, string TENHANG, string DVT, int SOLUONG, int DONGIA, DateTime NGNHAP, DateTime NGSANXUAT, DateTime HSD, int UKEY)
        {
            string sql_insert = "insert ORDERS values " + "('" + MAHANG
                + "', N'" + TENHANG + "', N'" + DVT + "', " + SOLUONG + ", " + DONGIA + ", '"
                + NGNHAP + "', '" + NGSANXUAT + "', '" + HSD + "', " + UKEY + ")";
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_insert) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
