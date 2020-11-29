﻿using System;
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
        public DataTable Load_On(int Ukey)   //Đầu vào cần 1 mã Ukey 
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD from HANGHOA where SOLUONG <> 0 and UKEY = " + Ukey;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }

        //Function có chức năng thêm 1 hàng hóa vào database
        public bool Them_HangHoa(string MAHANG, string TENHANG, string DVT, int SOLUONG, int DONGIA, DateTime NGNHAP, DateTime NGSANXUAT, DateTime HSD, int UKEY)
        {
            string sql_insert = "insert [HANGHOA] values " + "('" + MAHANG 
                + "', N'" + TENHANG + "', N'" + DVT + "', " + SOLUONG + ", " + DONGIA + ", '" 
                + NGNHAP + "', '" + NGSANXUAT + "', '" + HSD + "', " + UKEY + ")";
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_insert) > 0)
            {
                re = true;
            }
            return re;
        }

        //Function có chức năng sửa 1 hàng hóa trong database
        public bool Sua_HangHoa(string TENCOT, string value, string MAHANG)
        {
            string sql_update;
            if (TENCOT == "TENHANG" || TENCOT == "DVT")
                sql_update = "UPDATE HANGHOA SET " + TENCOT + " = N'" + value 
                            + "' WHERE MAHANG = '" + MAHANG + "'";
            else
                sql_update = "UPDATE HANGHOA SET " + TENCOT + " = '" + value
                            + "' WHERE MAHANG = '" + MAHANG + "'";
            bool re = false;
            if (Process.ExecutiveNonQuery(sql_update) > 0)
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
        public DataTable Load_MA(string MAHANG, int UKEY)   //Đầu vào cần 1 mã Ukey và tên mã hàng
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD from HANGHOA " +
                "where CHARINDEX('" + MAHANG + "', MAHANG) != 0 AND UKEY =" + UKEY;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }
        public DataTable Load_TENHANG(string TENHANG, int UKEY)   //Đầu vào cần 1 mã Ukey và tên hàng hóa
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD from HANGHOA where CHARINDEX(N'" + TENHANG + "', TENHANG) != 0 AND UKEY =" + UKEY;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }
        public DataTable Load_NGAYNHAP(string NGNHAP, int UKEY)   //Đầu vào cần 1 mã Ukey và tên hàng hóa
        {
            DataTable re;
            string sql_select = "Select MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD from HANGHOA " +
                "where CHARINDEX('" + NGNHAP + "', NGNHAP) != 0 AND UKEY =" + UKEY;
            re = Process.createTable(sql_select);
            return re;  //Trả về 1 DataTable
        }

        public bool Check_HangHoa(string MAHANG, int UKEY)
        {
            string sql_select = "Select * From HANGHOA Where UKEY = " + UKEY +
                " and MAHANG = '" + MAHANG + "'";
            bool re = false;
            if (Process.ExecutiveReader(sql_select) > 0)
            {
                re = true;
            }
            return re;
        }

        public bool Update_HangHoa(string MAHANG, string TENHANG, string DVT, int SOLUONG, int DONGIA, DateTime NGNHAP, DateTime NGSANXUAT, DateTime HSD, int UKEY)
        {
            string sql_update = "UPDATE HANGHOA " +
                "SET SOLUONG = " + SOLUONG + ", TENHANG = N'" + TENHANG + "', " + "DVT = N'" + DVT + "', " +
                "DONGIA = " + DONGIA + ", NGNHAP = '" + NGNHAP + "', NGSANXUAT = '" + NGSANXUAT + "', " +
                "HSD = '" + HSD + "'" +
                " WHERE MAHANG = '" + MAHANG + "' AND UKEY = " + UKEY;
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_update) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}
