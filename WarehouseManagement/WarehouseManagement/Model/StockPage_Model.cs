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
        public DataTable Load_On(string UName)
        {
            DataTable re;
            string sql_select = "Select HANGHOA.MAHANG,TENHANG,DVT,SOLUONG,DONGIA,NGNHAP,NGSANXUAT,HSD from HANGHOA inner join USERACC on USERACC.UKEY=HANGHOA.UKEY where USERNAME = '" + UName + "'";
            re = Process.createTable(sql_select);
            return re;
        }

        public bool Them_HangHoa(string MAHANG, string TENHANG, string DVT, int SOLUONG, int DONGIA, DateTime NGNHAP, DateTime NGSANXUAT, DateTime HSD, int UKEY)
        {
            string sql_insert = "insert [HANGHOA] values " +
                "('" + MAHANG + "', '" + TENHANG + "', '" + DVT + "', " + SOLUONG + ", " + DONGIA + ", '" +
                NGNHAP + "', '" + NGSANXUAT + "', '" + HSD + "', " + UKEY + ")";
            bool re = false;

            if (Process.ExecutiveNonQuery(sql_insert) > 0)
            {
                re = true;
            }
            return re;
        }

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
            string sql_del = "delete from HANGHOA where MAHANG = '" + MAHANG + "';";
            bool re = false;
            if (Process.ExecutiveNonQuery(sql_del) > 0)
            {
                re = true;
            }
            return re;
        }
    }
}