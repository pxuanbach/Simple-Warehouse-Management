using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WarehouseManagement.Model
{
    class MainForm_Model
    {
        //Function thực hiện câu lệnh SQL Server để lấy giá trị UKEY tương ứng với USERNAME
        public int GetUkey(string Username)
        {
            string sql_select = "Select UKEY from USERACC where USERNAME = '" + Username + "'";
            int re = Process.getNumber(sql_select);
            return re;
        }
    }
}
