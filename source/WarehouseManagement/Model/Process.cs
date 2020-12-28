using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Concurrent;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;

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
        public static string connectLink = ConfigurationManager.ConnectionStrings["con"].ToString();
        //public static string connectLink = @"Server=26.168.117.148,1433;Database=WarehouseManagement;User Id=sa;Password=1;";
        //@"Server=LAPTOP-ADHV1Q9P\SQLEXPRESS;Database=WarehouseManagement;User Id=sa;Password=1;";
        static string key { get; set; } = "A!9HHhi%XjjYY4YP2@Nob009X";

        public static string Encrypt(string text)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }

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
        public static int getNumber(string sql)
        {
            int i = 0;
            conn = new SqlConnection(connectLink);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                if (!reader.IsDBNull(0))
                {
                    i = reader.GetInt32(0);
                }
            }
            return i;       //trả về Ukey
        }

        public static string getString(string sql)
        {
            string str = "";
            conn = new SqlConnection(connectLink);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                if (reader.Read() == false) break;
                if (!reader.IsDBNull(0))
                {
                    str = reader.GetString(0);
                }
            }
            return str;       //trả về Ukey
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
                if (!reader.IsDBNull(0))
                {
                    acc.Name1 = reader.GetValue(0).ToString();
                }
                if (!reader.IsDBNull(1))
                {
                    acc.Phone1 = reader.GetValue(1).ToString();
                }
                if (!reader.IsDBNull(2))
                {
                    acc.Birthday1 = reader.GetDateTime(2);
                }
                if (!reader.IsDBNull(3))
                {
                    acc.Gender1 = reader.GetValue(3).ToString();
                }
                if (!reader.IsDBNull(4))
                {
                    acc.Email1 = reader.GetValue(4).ToString();
                }
                if (!reader.IsDBNull(5))
                {
                    acc.Position1 = reader.GetValue(5).ToString();
                }
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
                f.TENHANG = reader["TENHANG"].ToString();
                f.SOLUONG = (int)reader["SOLUONG"];
                f.DONGIA = Convert.ToInt32(splitPoint(reader["DONGIA"].ToString()));

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

        public static int getNewKEY(string sql)
        {
            using (var con = new SqlConnection(connectLink))
            {
                int newKEY = 0;
                using (var insertCommand = new SqlCommand(sql, con))
                {
                    insertCommand.Parameters.AddWithValue("@Value", "bar");
                    con.Open();
                    newKEY = (int)insertCommand.ExecuteScalar();
                }
                return newKEY;
            }
        }
    }
}
