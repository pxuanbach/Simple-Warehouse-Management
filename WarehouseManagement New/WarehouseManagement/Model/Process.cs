using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Concurrent;

namespace WarehouseManagement.Model
{
    class Process
    {
        public static SqlConnection conn;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public static DataTable data;
        public static SqlDataReader reader;
        //Link SQL Server
        public static string connectLink = @"Server=JAMES-LAPTOP\SQLEXPRES;Database=WarehouseManagement;User Id=sa;Password=19521334;";

        //Function lấy data từ SQL Server load vào DataTable
        public static DataTable createTable(string sql)
        {
            conn = new SqlConnection(connectLink);
            conn.Open();
            da = new SqlDataAdapter(sql, conn);
            data = new DataTable();
            da.Fill(data);
            conn.Close();
            return data;
        }

        //Function thực hiện câu lệnh SQL Server
        public static int ExecutiveNonQuery(string sql)
        {
            conn = new SqlConnection(connectLink);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            return rs;      //Nếu thực hiện không thành công trả về 0. Ngược lại trả về số hàng bị ảnh hưởng
        }

        //Function thực hiện câu lệnh SQL Server
        public static int ExecutiveReader(string sql)
        {
            int ck = 0;
            conn = new SqlConnection(connectLink);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.HasRows)              //reader sẽ đọc những hàng được câu lệnh SQL Server lấy ra từ table
            {
                if (reader.Read() == false) break;
                else
                    ck++;
            }
            conn.Close();
            return ck;      //trả về số hàng đã đọc được. Nếu không có hàng nào thì trả về 0
        }

        //Function lấy Ukey từ table
        public static int GetUkey(string sql)
        {
            int i = 0;
            conn = new SqlConnection(connectLink);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                i = reader.GetInt32(0);
            }
            return i;                                   //trả về Ukey
        }


        ///////////////////////////// chưa làm ////////////////////////////////
        public static string[] ListData(string sql)
        {
            string[] list = new string[10];
            conn = new SqlConnection(connectLink);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                list[0] = reader[0].ToString();
                list[1] = reader.GetString(1);
                //if (reader[2] == null)
                //    list[2] = "None";
                //else
                //{
                //    list[2] = reader.GetString(2);
                //}    
                    
                //if (reader.GetString(3) == null)
                //    list[3] = "";
                //else
                //    list[3] = reader.GetString(3);
                //if (reader.GetString(4) == null)
                //    list[4] = "";
                //else
                //    list[4] = reader.GetString(4);
                //list[4] = reader.GetString(4);
                //list[5] = reader.GetString(5);
            }
            conn.Close();
            return list;
        }
        public static DateTime date(string sql)
        {
            DateTime time = new DateTime();
            conn = new SqlConnection(connectLink);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                else
                {
                    time = reader.GetDateTime(0);
                }
            }
            conn.Close();
            return time;
        }
    }
}
