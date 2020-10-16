using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WarehouseManagement.Model
{
    class Process
    {
        public static SqlConnection conn;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public static DataTable data;
        public static string connectLink = @"Server=LAPTOP-ADHV1Q9P\SQLEXPRESS;Database=WarehouseManagement;User Id=sa;Password=1;";


    }
}
