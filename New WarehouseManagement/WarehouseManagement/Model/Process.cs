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
        //Link SQL Server nhớ vào AccountPage đổi nữa ..(`~.`)~
        public static string connectLink = @"Server=LAPTOP-ADHV1Q9P\SQLEXPRESS;Database=WarehouseManagement;User Id=sa;Password=1;";

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
            while (reader.HasRows)          //reader sẽ đọc những hàng được câu lệnh SQL Server lấy ra từ table
            {
                if (reader.Read() == false) break;
                else
                    ck++;
            }
            conn.Close();
            return ck;      //trả về số hàng đã đọc được. Nếu không có hàng nào thì trả về 0
        }

        //Function lấy Ukey từ table
        public static int GetNumber(string sql)
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
            return i;       //trả về Ukey
        }

        //Function lấy thông tin của user từ database
        public static Account getInfo(string sql)
        {
            Account acc = new Account();
            conn = new SqlConnection(connectLink);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                acc.Name1 = reader.GetValue(0).ToString();
                acc.Phone1 = reader.GetValue(1).ToString();
                acc.Birthday1 = reader.GetDateTime(2);
                acc.Gender1 = reader.GetValue(3).ToString();
                acc.Email1 = reader.GetValue(4).ToString();
                acc.Position1 = reader.GetValue(5).ToString();
            }
            return acc;
        }

        public static List<CTHD> GetCTHDs(string sql)
        {
            conn = new SqlConnection(connectLink);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            List<CTHD> CTHDs = new List<CTHD>();

            while (reader.Read())
            {
                CTHD f = new CTHD();
                f.MAHANG = reader["MAHANG"].ToString();
                f.SOLUONG = (int)reader["SOLUONG"];
                string[] donGia = reader["DONGIA"].ToString().Split('.');
                f.DONGIA = Convert.ToInt32(donGia[0]);

                CTHDs.Add(f);
            }
            return CTHDs;
        }

        public static string splitPoint(string str)
        {
            string[] temp = str.Split('.');
            return temp[0];
        }

        public static bool CheckVietKey(string chucodau)
        {
            const string FindText = "áàảãạâấầẩẫậăắằẳẵặđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴ";
            int n;
            int m = chucodau.Length;
            char[] arrS = chucodau.ToCharArray();
            for (int i = 0; i < m; i++)
            {
                n = FindText.IndexOf(arrS[i]);
                if (n != -1) return false;
            }

            return true;
        }
    }
}
