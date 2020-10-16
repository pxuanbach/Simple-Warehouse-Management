using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace MVCproject.Model
{
    class Process
    {
        public static SqlConnection conn;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public static DataTable data;
        public static string connectLink = @"Server=LAPTOP-ADHV1Q9P\SQLEXPRESS;Database=WarehouseManagement;User Id=sa;Password=1;";

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

        public static int ExecutiveNonQuery(string sql)
        {
            conn = new SqlConnection(connectLink);
            conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);
            int rs = command.ExecuteNonQuery();
            conn.Close();
            return rs;
        }
    }
}
